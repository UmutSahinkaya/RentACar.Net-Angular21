using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Customers;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        _ = builder.ToTable("Customers");
        _ = builder.HasKey(x => x.Id);

        _ = builder.OwnsOne(x => x.FirstName);
        _ = builder.OwnsOne(x => x.LastName);
        _ = builder.OwnsOne(x => x.FullName);
        _ = builder.OwnsOne(x => x.IdentityNumber);
        _ = builder.OwnsOne(x => x.DateOfBirth);
        _ = builder.OwnsOne(x => x.PhoneNumber);
        _ = builder.OwnsOne(x => x.Email);
        _ = builder.OwnsOne(x => x.DrivingLicenseIssuanceDate);
        _ = builder.OwnsOne(x => x.FullAddress);
        _ = builder.OwnsOne(x => x.Password);
    }
}