using HuntShowdownAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HuntShowdownAPI.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql().UseSnakeCaseNamingConvention();

    public DbSet<Weapon> Weapons { get; set; }
}