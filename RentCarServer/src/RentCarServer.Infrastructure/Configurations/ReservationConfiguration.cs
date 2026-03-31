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

        _ = builder.OwnsOne(p => p.ReservationNumber);
        _ = builder.OwnsOne(p => p.PickUpDate);
        _ = builder.OwnsOne(p => p.PickUpTime);
        _ = builder.OwnsOne(p => p.DeliveryDate);
        _ = builder.OwnsOne(p => p.DeliveryTime);
        _ = builder.OwnsOne(p => p.TotalDay);
        _ = builder.OwnsOne(p => p.VehicleDailyPrice);
        _ = builder.OwnsOne(p => p.ProtectionPackagePrice);
        _ = builder.OwnsMany(p => p.ReservationExtras);
        _ = builder.OwnsOne(p => p.Note);
        _ = builder.OwnsOne(p => p.PaymentInformation);
        _ = builder.OwnsOne(p => p.Status);
        _ = builder.OwnsOne(p => p.Total);
        _ = builder.OwnsOne(p => p.PickUpDatetime);
        _ = builder.OwnsOne(p => p.DeliveryDatetime);
        _ = builder.OwnsMany(p => p.Histories);
        _ = builder.OwnsOne(p => p.PickUpForm, modelBuilder =>
        {
            _ = modelBuilder.OwnsOne(i => i.Kilometer);
            _ = modelBuilder.OwnsMany(i => i.ImageUrls, x =>
            {
                _ = x.ToTable("PickUpForm_ImageUrls");
            });

            _ = modelBuilder.OwnsMany(i => i.Supplies, x =>
            {
                _ = x.ToTable("PickUpForm_Supplies");
            });

            _ = modelBuilder.OwnsMany(i => i.Damages, x =>
            {
                _ = x.ToTable("PickUpForm_Damages");
            });

            _ = modelBuilder.OwnsOne(i => i.Note, x =>
            {
                _ = x.ToTable("PickUpForm_Note");
            });
        });
        _ = builder.OwnsOne(p => p.DeliveryForm, modelBuilder =>
        {
            _ = modelBuilder.OwnsOne(i => i.Kilometer);
            _ = modelBuilder.OwnsMany(i => i.ImageUrls, x =>
            {
                _ = x.ToTable("DeliveryForm_ImageUrls");
            });

            _ = modelBuilder.OwnsMany(i => i.Supplies, x =>
            {
                _ = x.ToTable("DeliveryForm_Supplies");
            });

            _ = modelBuilder.OwnsMany(i => i.Damages, x =>
            {
                _ = x.ToTable("DeliveryForm_Damages");
            });

            _ = modelBuilder.OwnsOne(i => i.Note, x =>
            {
                _ = x.ToTable("DeliveryForm_Note");
            });
        });
    }
}