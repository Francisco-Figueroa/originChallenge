using OriginsChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginsChallenge.Interfaces
{
    public interface ICardRepository : IGenericRepository<Card>
    {
        public Boolean checkCardNumber(long cardNumber);
        public Boolean checkPinNumber(int pinNumber, long cardNumber);
        public Card findByCardNumber(long cardNumber);
    }
}
