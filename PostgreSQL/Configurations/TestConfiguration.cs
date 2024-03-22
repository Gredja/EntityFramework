using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSQL.Models;

namespace PostgreSQL.Configurations;

public class TestConfiguration : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.HasKey(e => e.Id).HasName("Test_pkey");
        builder.Property(e => e.Id).ValueGeneratedNever();
    }
}