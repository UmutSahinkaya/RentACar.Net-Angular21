using RentCarServer.Application.Customers;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class CustomerModule
{
    public static void MapCustomer(this IEndpointRouteBuilder builder)
    {
        var app = builder
            .MapGroup("/customers")
            .RequireRateLimiting("fixed")
            .RequireAuthorization()
            .WithTags("Customers");

        _ = app.MapPost(string.Empty,
            async (CustomerCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var result = await sender.Send(request, cancellationToken);
                return result.IsSuccessful ? Results.Ok(result) : Results.InternalServerError(result);
            })
            .Produces<Result<string>>();

        _ = app.MapPut(string.Empty,
            async (CustomerUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var result = await sender.Send(request, cancellationToken);
                return result.IsSuccessful ? Results.Ok(result) : Results.InternalServerError(result);
            })
            .Produces<Result<string>>();

        _ = app.MapDelete("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var result = await sender.Send(new CustomerDeleteCommand(id), cancellationToken);
                return result.IsSuccessful ? Results.Ok(result) : Results.InternalServerError(result);
            })
            .Produces<Result<string>>();

        _ = app.MapGet("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var result = await sender.Send(new CustomerGetQuery(id), cancellationToken);
                return result.IsSuccessful ? Results.Ok(result) : Results.InternalServerError(result);
            })
            .Produces<Result<CustomerDto>>();

        _ = app.MapGet(string.Empty,
            async (ISender sender, CancellationToken cancellationToken) =>
            {
                var result = await sender.Send(new CustomerGetAllQuery(), cancellationToken);
                return Results.Ok(result);
            })
            .Produces<IQueryable<CustomerDto>>();
    }
}