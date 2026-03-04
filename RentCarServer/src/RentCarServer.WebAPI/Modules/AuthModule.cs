using RentCarServer.Application.Auth;
using TS.MediatR;

namespace RentCarServer.WebAPI.Modules;

public static class AuthModule
{
    public static void MapAuth(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var app = endpointRouteBuilder.MapGroup("/auth");
        _ = app.MapPost("/login", async (LoginCommand req, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(req, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res.ErrorMessages);
        });
        //Produces<Result<string>>();
    }
}
