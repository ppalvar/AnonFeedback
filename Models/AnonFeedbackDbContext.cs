namespace Models;

using Microsoft.EntityFrameworkCore;

public class AnonFeedbackDbContext : DbContext
{
    public AnonFeedbackDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
}