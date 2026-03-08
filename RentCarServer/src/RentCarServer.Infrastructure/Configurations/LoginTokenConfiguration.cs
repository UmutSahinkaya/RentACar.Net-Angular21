using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.LoginTokens;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class LoginTokenConfiguration : IEntityTypeConfiguration<LoginToken>
{
    public void Configure(EntityTypeBuilder<LoginToken> builder)
    {
        _ = builder.HasKey(x => x.Id);
        _ = builder.OwnsOne(x => x.Token);
        _ = builder.OwnsOne(x => x.IsActive);
        _ = builder.OwnsOne(x => x.ExpiresDate);
    }
}
