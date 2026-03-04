using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Users;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        _ = builder.HasKey(u => u.Id);
        _ = builder.OwnsOne(i => i.FirstName);
        _ = builder.OwnsOne(i => i.LastName);
        _ = builder.OwnsOne(i => i.FullName);
        _ = builder.OwnsOne(i => i.Email);
        _ = builder.OwnsOne(i => i.UserName);
        _ = builder.OwnsOne(i => i.Password);
    }
}
