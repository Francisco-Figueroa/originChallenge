using OriginsChallenge.Interfaces;
using System;
using System.Threading.Tasks;

public interface IUnitOfWork : IDisposable
{
    ICardRepository Cards { get; }
    Task<int> Complete();
}