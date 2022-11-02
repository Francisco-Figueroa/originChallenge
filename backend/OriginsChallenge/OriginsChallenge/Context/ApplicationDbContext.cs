using Microsoft.EntityFrameworkCore;
using OriginsChallenge.Models;
using System.Threading.Tasks;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Card> Card { get; set; }
    public new async Task<int> SaveChanges()
    {
        return await base.SaveChangesAsync();
    }
}