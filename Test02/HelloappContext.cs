using Microsoft.EntityFrameworkCore;

namespace Test02;

public partial class HelloappContext : DbContext
{
    public HelloappContext()
    {
        //Database.EnsureDeleted();   // удаляем бд со старой схемой
        Database.EnsureCreated();   // создаем бд с новой схемой
    }

    public HelloappContext(DbContextOptions<HelloappContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=D:\\\\\\\\Databases\\\\\\\\helloapp\\\\\\\\helloapp.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
