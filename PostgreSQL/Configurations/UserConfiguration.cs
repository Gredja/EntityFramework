using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSQL.Models;

namespace PostgreSQL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(e => e.Age).HasDefaultValue(0);
        builder.ToTable(t => t.HasCheckConstraint("ValidAge", "Age > 0 AND Age < 120"));
        builder.Property(e => e.Name).HasDefaultValueSql("''::text");
        builder.Property(e => e.PassportNumber).HasDefaultValue(0);
        builder.Property(e => e.PassportSeria).HasDefaultValueSql("'0000000000'::text");
    }
}