using Microsoft.EntityFrameworkCore;
using PostgreSQL.Models;

namespace PostgreSQL;

public partial class UsersdbContext : DbContext
{
    public UsersdbContext()
    {
    }

    public UsersdbContext(DbContextOptions<UsersdbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=admin;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property(p => p.PassportSeria).HasDefaultValue("0000000000");
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
