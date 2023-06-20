using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualStore.Core.Entities;

namespace VirtualStore.Infrastructure.Configurations
{
    internal class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
