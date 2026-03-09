using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Branches;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        _ = builder.HasKey(x => x.Id);
        _ = builder.OwnsOne(x => x.Name);
        _ = builder.OwnsOne(x => x.Address);
    }
}
