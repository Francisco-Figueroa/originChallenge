using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OriginsChallenge.Controllers.ViewModels;
using OriginsChallenge.Interfaces;
using OriginsChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginsChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ICardController
    {
        private readonly int MaxFailedAttempts = 4;
        private readonly ILogger<CardController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public CardController(ILogger<CardController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        [HttpPost("checkCardNumber")]
        public Boolean checkCardNumber([FromBody] CheckCardNumberViewModel obj)
        {
            var exists = _unitOfWork.Cards.checkCardNumber(obj.CardNumber);
            return exists;
        }

        [HttpPost("checkPinNumber")]
        public Boolean checkPinNumber([FromBody] CheckCardNumberViewModel obj)
        {
            var exists = _unitOfWork.Cards.checkPinNumber(obj.PinNumber, obj.CardNumber);
            var card = _unitOfWork.Cards.findByCardNumber(obj.CardNumber);
            if (!exists)
            {
                card.FailedAttempts = card.FailedAttempts + 1;
                if(card.FailedAttempts >= MaxFailedAttempts)
                {
                    card.IsBlocked = true;
                }
                _unitOfWork.Cards.Update(card);
            } else
            {
                card.FailedAttempts = 0;
                _unitOfWork.Cards.Update(card);
            }
            return exists;
        }
    }
}
