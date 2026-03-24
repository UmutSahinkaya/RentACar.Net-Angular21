using RentCarServer.Application.Categories;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class CategoryModule
{
    public static void MapCategory(this IEndpointRouteBuilder routeBuilder)
    {
        var app = routeBuilder.MapGroup("/categories").WithTags("Categories").RequireRateLimiting("fixed").RequireAuthorization();

        _ = app.MapPost(string.Empty, async (CategoryCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        })
         .Produces<Result<string>>();
        _ = app.MapPut(string.Empty, async (CategoryUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(request, cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapDelete("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new CategoryDeleteCommand(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<string>>();
        _ = app.MapGet("{id}", async (Guid id, ISender sender, CancellationToken cancellationToken) =>
        {
            var res = await sender.Send(new CategoryGetQuery(id), cancellationToken);
            return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
        }).Produces<Result<CategoryDto>>();
    }
}
