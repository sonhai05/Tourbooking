using Microsoft.EntityFrameworkCore;
using Tourbooking.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Tour> Tours { get; set; }
}