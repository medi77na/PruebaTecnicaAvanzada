using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using PruebaTecnica.Seeders;

namespace PruebaTecnica.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Employee> Employees { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        RoomSeeder.Seed(modelBuilder);
        RoomTypeSeeder.Seed(modelBuilder);

        modelBuilder.Entity<Guest>()
            .HasIndex(g => g.IdentificationNumber)
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasIndex(e => e.IdentificationNumber)
            .IsUnique();
    }
}