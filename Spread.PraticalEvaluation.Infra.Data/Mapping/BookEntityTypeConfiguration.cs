using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spread.PraticalEvaluation.Domain.Entities;

namespace Spread.PraticalEvaluation.Infra.Data.Mapping
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasColumnName("Title").IsRequired();
            builder.Property(x => x.AuthorId).HasColumnName("AuthorId").IsRequired();
            builder.Property(x => x.CategoryId).HasColumnName("CategoryId").IsRequired();
        }
    }
}
