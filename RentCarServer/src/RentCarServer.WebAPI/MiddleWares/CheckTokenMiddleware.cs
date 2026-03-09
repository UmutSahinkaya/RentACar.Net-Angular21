using RentCarServer.Domain.LoginTokens;
using System.Security.Claims;

namespace RentCarServer.WebAPI.MiddleWares;

public class CheckTokenMiddleware(ILoginTokenRepository loginTokenRepository) : IMiddleware
{
    public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
    {
        var token = httpContext.Request.Headers.Authorization.ToString().Replace("Bearer ", "");
        if (string.IsNullOrWhiteSpace(token))
        {
            await next(httpContext);
            return;
        }
        var userId = httpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
        if (userId is null) throw new TokenException();

        var isTokenAvaliable = await loginTokenRepository.AnyAsync(x => x.UserId == userId && x.Token.Value == token && x.IsActive.Value == true);
        if (!isTokenAvaliable) throw new TokenException();

        await next(httpContext);
    }
}
public sealed class TokenException : Exception;