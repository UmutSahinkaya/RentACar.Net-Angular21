using Microsoft.AspNetCore.Http;
using RentCarServer.Application.Services;
using System.Security.Claims;

namespace RentCarServer.Infrastructure.Services;

internal sealed class ClaimContext(IHttpContextAccessor httpContextAccessor) : IClaimContext
{
    public Guid GetBranchId()
    {
        var httpContext = httpContextAccessor.HttpContext;
        if (httpContext is null)
        {
            throw new ArgumentNullException("context bilgisi bulunamadı");
        }
        var claims = httpContext.User.Claims;
        string? branchId = claims.FirstOrDefault(c => c.Type == "branchId")?.Value;
        if (branchId is null)
            throw new ArgumentException("Şube bilgisi bulunamadı");
        try
        {
            Guid id = Guid.Parse(branchId);
            return id;
        }
        catch (Exception)
        {
            throw new ArgumentException("Şube Id uygun guid formatında değil");
        }
    }

    public string GetRoleName()
    {
        var httpContext = httpContextAccessor.HttpContext;
        if (httpContext is null)
        {
            throw new ArgumentNullException("context bilgisi bulunamadı");
        }
        var claims = httpContext.User.Claims;
        string? roleName = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
        if (roleName is null)
            throw new ArgumentException("Rol bilgisi bulunamadı");
        return roleName;
    }

    public Guid GetUserId()
    {
        var httpContext = httpContextAccessor.HttpContext;
        if (httpContext is null)
        {
            throw new ArgumentNullException("context bilgisi bulunamadı");
        }
        var claims = httpContext.User.Claims;
        string? userId = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        if (userId is null)
            throw new ArgumentException("Kullanıcı bilgisi bulunamadı");
        try
        {
            Guid id = Guid.Parse(userId);
            return id;
        }
        catch (Exception)
        {
            throw new ArgumentException("Kullanıcı ID uygun guid formatında değil");
        }

    }
}
