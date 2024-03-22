using Microsoft.EntityFrameworkCore;
using PostgreSQL.Configurations;
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

    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<Country> Countries { get; set; }
    public virtual DbSet<Test> Tests { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=admin;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TestConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}