using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentCarServer.Domain.Categories;

namespace RentCarServer.Infrastructure.Configurations;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        _ = builder.ToTable("Categories");
        _ = builder.HasKey(x => x.Id);
        _ = builder.OwnsOne(x => x.Name);
    }
}
