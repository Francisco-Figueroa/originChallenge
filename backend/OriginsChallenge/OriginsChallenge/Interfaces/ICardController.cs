using Microsoft.AspNetCore.Mvc;
using OriginsChallenge.Controllers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginsChallenge.Interfaces
{
    interface ICardController
    {
        public Boolean checkCardNumber([FromBody] CheckCardNumberViewModel obj);
    }
}
