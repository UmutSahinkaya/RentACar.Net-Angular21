using RentCarServer.Application.ProtectionPackages;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class ProtectionPackageModule
{
    public static void MapProtectionPackage(this IEndpointRouteBuilder builder)
    {
        var app = builder
            .MapGroup("/protection-packages")
            .RequireRateLimiting("fixed")
            .RequireAuthorization()
            .WithTags("ProtectionPackages");

        _ = app.MapPost(string.Empty,
            async (ProtectionPackageCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapPut(string.Empty,
            async (ProtectionPackageUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapDelete("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new ProtectionPackageDeleteCommand(id), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapGet("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new ProtectionPackageGetQuery(id), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<ProtectionPackageDto>>();
    }
}