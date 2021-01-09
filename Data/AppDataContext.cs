using EFCoreSqLite.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSqLite.Data
{
  public class AppDataContext : DbContext
  {
    public DbSet<User> Users { get; private set; }

    public AppDataContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(@"Data Source=database.sqlite");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().ToTable("users");
      modelBuilder.Entity<User>().HasKey(pre => pre.Id);
      modelBuilder.Entity<User>().Property(pre => pre.Id).HasColumnName("id");

      modelBuilder.Entity<User>()
        .Property(pre => pre.Name)
        .HasColumnName("name");

      modelBuilder.Entity<User>()
        .Property(pre => pre.Name)
        .HasColumnName("name")
        .HasMaxLength(100);

      modelBuilder.Entity<User>()
        .Property(pre => pre.Email)
        .HasColumnName("email")
        .HasMaxLength(80);

      modelBuilder.Entity<User>()
        .Property(pre => pre.BirthDate)
        .HasColumnName("birthdate");
    }
  }
}