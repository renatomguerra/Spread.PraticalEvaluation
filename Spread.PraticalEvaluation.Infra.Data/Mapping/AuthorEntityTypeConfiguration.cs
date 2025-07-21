using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spread.PraticalEvaluation.Domain.Entities;

namespace Spread.PraticalEvaluation.Infra.Data.Mapping
{
    public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x=> x.AuthorId);
        }
    }
}
