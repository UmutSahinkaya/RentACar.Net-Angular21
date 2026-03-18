using RentCarServer.Application.Roles;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class RoleModule
{
    public static void MapRole(this IEndpointRouteBuilder routeBuilder)
    {
        var app = routeBuilder.MapGroup("/Roles").WithTags("Roles").RequireRateLimiting("fixed").RequireAuthorization();

        _ = app.MapPost(string.Empty, async (RoleCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        })
         .Produces<Result<string>>();
        _ = app.MapPut(string.Empty, async (RoleUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapDelete("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new RoleDeleteCommand(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapGet("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new RoleGetQuery(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<RoleGetAllQuery>>();

        _ = app.MapPut("update-permissions", async (RoleUpdatePermissionCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
    }
}
