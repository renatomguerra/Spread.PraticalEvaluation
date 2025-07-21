using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spread.PraticalEvaluation.Domain.Entities;

namespace Spread.PraticalEvaluation.Infra.Data.Mapping
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(x=> x.Books).WithOne(x => x.Category).HasForeignKey(x=>x.CategoryId);
        }
    }
}
