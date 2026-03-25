using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.ProtectionPackages;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class ProtectionPackageConfiguration : IEntityTypeConfiguration<ProtectionPackage>
{
    public void Configure(EntityTypeBuilder<ProtectionPackage> builder)
    {
        _ = builder.ToTable("ProtectionPackages");
        _ = builder.HasKey(x => x.Id);

        _ = builder.OwnsOne(x => x.Name);
        _ = builder.OwnsOne(x => x.Price);
        _ = builder.OwnsOne(x => x.IsRecommended);
        _ = builder.OwnsMany(x => x.Coverages);
    }
}