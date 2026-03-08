using RentCarServer.Application.Auth;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class AuthModule
{
    public static void MapAuth(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var app = endpointRouteBuilder.MapGroup("/auth");
        _ = app.MapPost("/login", async (LoginCommand request, ISender sender, CancellationToken cancellationToken) =>
       {
           var res = await sender.Send(request, cancellationToken);
           return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res.ErrorMessages);
       })
       .Produces<Result<string>>()
       .RequireRateLimiting("login-fixed"); ;


        _ = app.MapPost("/forgot-password/{email}",
            async (string email, ISender sender, CancellationToken cancellationToken) =>
          {
              var res = await sender.Send(new ForgotPasswordCommand(email), cancellationToken);
              return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res.ErrorMessages);
          })
         .Produces<Result<string>>()
         .RequireRateLimiting("forgot-password-fixed");

        _ = app.MapPost("/reset-password",
            async (ResetPasswordCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res.ErrorMessages);
            })
         .Produces<Result<string>>()
         .RequireRateLimiting("reset-password-fixed");

        _ = app.MapGet("/check-forgot-password-code/{forgotPasswordCode}",
            async (Guid forgotPasswordCode, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new CheckForgotPasswordCodeCommand(forgotPasswordCode), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res.ErrorMessages);
            })
         .Produces<Result<string>>()
         .RequireRateLimiting("check-forgot-password-code-fixed");
    }
}
