using RentCarServer.Application.Reservations;
using RentCarServer.Application.Reservations.Forms;
using RentCarServer.Application.Vehicles;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.WebAPI.Modules;

public static class ReservationModule
{
    public static void MapReservation(this IEndpointRouteBuilder builder)
    {
        var app = builder
            .MapGroup("/reservations")
            .RequireRateLimiting("fixed")
            .RequireAuthorization()
            .WithTags("Reservations");

        _ = app.MapPost(string.Empty,
            async (ReservationCreateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapPut(string.Empty,
            async (ReservationUpdateCommand request, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(request, cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapDelete("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new ReservationDeleteCommand(id), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<string>>();

        _ = app.MapGet("{id}",
            async (Guid id, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new ReservationGetQuery(id), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<ReservationDto>>();

        _ = app.MapPost("vehicle-getall",
          async (ReservationGetAllVehicleQuery request, ISender sender, CancellationToken cancellationToken) =>
          {
              var res = await sender.Send(request, cancellationToken);
              return Results.Ok(res);
          })
          .Produces<Result<List<VehicleDto>>>();

    }
    public static void MapReservationForm(this IEndpointRouteBuilder builder)
    {
        var app = builder
            .MapGroup("/reservation-form")
            .RequireRateLimiting("fixed")
            .RequireAuthorization()
            .WithTags("ReservationForms");

        _ = app.MapGet("{reservationId}/{type}",
            async (Guid reservationId, string type, ISender sender, CancellationToken cancellationToken) =>
            {
                var res = await sender.Send(new FormGetQuery(reservationId, type), cancellationToken);
                return res.IsSuccessful ? Results.Ok(res) : Results.InternalServerError(res);
            })
            .Produces<Result<FormDto>>();
    }
}