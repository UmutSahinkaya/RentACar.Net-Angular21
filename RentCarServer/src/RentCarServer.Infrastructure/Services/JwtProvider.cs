using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RentCarServer.Application.Services;
using RentCarServer.Domain.LoginTokens;
using RentCarServer.Domain.LoginTokens.ValueObjects;
using RentCarServer.Domain.Users;
using RentCarServer.WebAPI.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RentCarServer.Infrastructure.Services;

internal sealed class JwtProvider(ILoginTokenRepository loginTokenRepository, IUnitOfWork unitOfWork, IOptions<JwtOptions> options) : IJwtProvider
{
    public async Task<string> CreateTokenAsync(User user, CancellationToken cancellationToken = default)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier,user.Id),
            new Claim("FullName",user.FullName.Value),
            new Claim("Email",user.Email.Value)
        };

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(options.Value.SecretKey));
        SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512);

        var expires = DateTime.UtcNow.AddDays(1);
        JwtSecurityToken securityToken = new(
                issuer: options.Value.Issuer,
                audience: options.Value.Audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expires,
                signingCredentials: signingCredentials
                );
        var handler = new JwtSecurityTokenHandler();
        var token = handler.WriteToken(securityToken);

        Token newToken = new(token);
        ExpiresDate expiresDate = new(expires);
        LoginToken loginToken = new(newToken, user.Id, expiresDate);

        // Önce mevcut aktif tokenları pasife çek
        var loginTokens = await loginTokenRepository
            .Where(x => x.UserId == user.Id && x.IsActive.Value == true).ToListAsync(cancellationToken);
        foreach (var item in loginTokens)
        {
            item.SetIsActive(new(false));
        }
        loginTokenRepository.UpdateRange(loginTokens);

        // Yeni tokeni ekle (eskilerin pasife çekilmesinden sonra)
        loginTokenRepository.Add(loginToken);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);
        return token;
    }
}
