using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Roles;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        _ = builder.ToTable("Roles");
        _ = builder.HasKey(x => x.Id);
        _ = builder.OwnsOne(x => x.Name);
        _ = builder.OwnsMany(x => x.Permissions);
    }
}