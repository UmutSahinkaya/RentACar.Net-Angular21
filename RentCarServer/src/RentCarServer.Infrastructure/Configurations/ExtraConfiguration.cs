using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Extras;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class ExtraConfiguration : IEntityTypeConfiguration<Extra>
{
    public void Configure(EntityTypeBuilder<Extra> builder)
    {
        _ = builder.ToTable("Extras");
        _ = builder.HasKey(x => x.Id);
        _ = builder.OwnsOne(x => x.Name);
        _ = builder.OwnsOne(x => x.Price);
        _ = builder.OwnsOne(x => x.Description);
    }
}