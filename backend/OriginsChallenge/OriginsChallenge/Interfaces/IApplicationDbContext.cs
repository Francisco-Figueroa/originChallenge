using Microsoft.EntityFrameworkCore;
using OriginsChallenge.Models;
using System.Threading.Tasks;

public interface IApplicationDbContext
{
    DbSet<Card> Card { get; set; }
    Task<int> SaveChanges();
}