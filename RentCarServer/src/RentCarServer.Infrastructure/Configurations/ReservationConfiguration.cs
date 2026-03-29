using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Reservations;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        _ = builder.ToTable("Reservations");
        _ = builder.HasKey(x => x.Id);

        builder.OwnsOne(p => p.PickUpDate);
        builder.OwnsOne(p => p.PickUpTime);
        builder.OwnsOne(p => p.DeliveryDate);
        builder.OwnsOne(p => p.DeliveryTime);
        builder.OwnsOne(p => p.TotalDay);
        _ = builder.OwnsOne(p => p.VehicleDailyPrice);
        _ = builder.OwnsOne(p => p.ProtectionPackagePrice);
        _ = builder.OwnsOne(p => p.ExtraPrice);
        builder.OwnsOne(p => p.Note);
        builder.OwnsOne(p => p.PaymentInformation);
        builder.OwnsOne(p => p.Status);
    }
}