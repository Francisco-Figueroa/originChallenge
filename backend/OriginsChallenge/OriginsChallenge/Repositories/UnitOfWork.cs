using OriginsChallenge.Interfaces;
using OriginsChallenge.Repositories;
using System.Threading.Tasks;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Cards = new CardRepository(_context);
    }
    public ICardRepository Cards { get; private set; }
    public Task<int> Complete()
    {
        return _context.SaveChanges();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}