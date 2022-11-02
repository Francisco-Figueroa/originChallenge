using OriginsChallenge.Interfaces;
using OriginsChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OriginsChallenge.Repositories
{
    public class CardRepository : GenericRepository<Card>, ICardRepository
    {

        public CardRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void Add(Card entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Card> entities)
        {
            throw new NotImplementedException();
        }

        public Boolean checkCardNumber(long cardNumber)
        {
            return _context.Set<Card>().Any(x => x.CardNumber == cardNumber && !x.IsBlocked);
        }
        public Boolean checkPinNumber(int pinNumber, long cardNumber)
        {
            return _context.Set<Card>().Any(x => x.Pin == pinNumber && x.CardNumber == cardNumber);
        }

        public Card findByCardNumber(long cardNumber)
        {
            var result = _context.Set<Card>().FirstOrDefault<Card>(x => x.CardNumber == cardNumber);
            _context.Entry(result);
            return result;

        }

        public IEnumerable<Card> GetAll()
        {
            return _context.Set<Card>().ToList();
        }

        public Card GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Card entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Card entity)
        {
            _context.Set<Card>().Update(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Card> entities)
        {
            throw new NotImplementedException();
        }
    }
}
