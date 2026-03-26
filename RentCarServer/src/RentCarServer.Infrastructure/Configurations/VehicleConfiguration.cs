using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Vehicles;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        _ = builder.ToTable("Vehicles");
        _ = builder.HasKey(x => x.Id);

        _ = builder.OwnsOne(x => x.Brand);
        _ = builder.OwnsOne(x => x.Model);
        _ = builder.OwnsOne(x => x.ModelYear);
        _ = builder.OwnsOne(x => x.Color);
        _ = builder.OwnsOne(x => x.Plate);
        _ = builder.OwnsOne(x => x.CategoryId);
        _ = builder.OwnsOne(x => x.BranchId);
        _ = builder.OwnsOne(x => x.VinNumber);
        _ = builder.OwnsOne(x => x.EngineNumber);
        _ = builder.OwnsOne(x => x.Description);
        _ = builder.OwnsOne(x => x.ImageUrl);
        _ = builder.OwnsOne(x => x.FuelType);
        _ = builder.OwnsOne(x => x.Transmission);

        _ = builder.OwnsOne(x => x.EngineVolume, y =>
        {
            _ = y.Property(p => p.Value).HasColumnType("decimal(18,2)");
        });
        _ = builder.OwnsOne(x => x.EnginePower);
        _ = builder.OwnsOne(x => x.TractionType);
        _ = builder.OwnsOne(x => x.FuelConsumption, y =>
        {
            _ = y.Property(p => p.Value).HasColumnType("decimal(18,2)");
        });
        _ = builder.OwnsOne(x => x.SeatCount);
        _ = builder.OwnsOne(x => x.Kilometer);

        _ = builder.OwnsOne(x => x.DailyPrice);
        _ = builder.OwnsOne(x => x.WeeklyDiscountRate, y =>
        {
            _ = y.Property(p => p.Value).HasColumnType("decimal(18,2)");
        });
        _ = builder.OwnsOne(x => x.MonthlyDiscountRate, y =>
        {
            _ = y.Property(p => p.Value).HasColumnType("decimal(18,2)");
        });

        _ = builder.OwnsOne(x => x.InsuranceType);
        _ = builder.OwnsOne(x => x.LastMaintenanceDate);
        _ = builder.OwnsOne(x => x.LastMaintenanceKm);
        _ = builder.OwnsOne(x => x.NextMaintenanceKm);
        _ = builder.OwnsOne(x => x.InspectionDate);
        _ = builder.OwnsOne(x => x.InsuranceEndDate);
        _ = builder.OwnsOne(x => x.CascoEndDate);
        _ = builder.OwnsOne(x => x.TireStatus);
        _ = builder.OwnsOne(x => x.GeneralStatus);
        _ = builder.OwnsMany(x => x.Features);
    }
}