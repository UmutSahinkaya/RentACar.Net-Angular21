using RentCarServer.Application.Branches;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class BranchModule
{
    public static void MapBranch(this IEndpointRouteBuilder routeBuilder)
    {
        var app = routeBuilder.MapGroup("/branches").WithTags("branches").RequireRateLimiting("fixed").RequireAuthorization();

        _ = app.MapPost(string.Empty, async (BranchCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        })
         .Produces<Result<string>>();
        _ = app.MapPut(string.Empty, async (BranchUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapDelete("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new BranchDeleteCommand(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapGet("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new BranchGetQuery(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<BranchDto>>();
    }
}
