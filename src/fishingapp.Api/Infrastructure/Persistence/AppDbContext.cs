using fishingapp.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace fishingapp.Api.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<User> User { get; set; } = null!;
    public DbSet<Address> Address { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}