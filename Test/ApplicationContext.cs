using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=d:\\Databases\\helloapp\\helloapp.db");
    }
}