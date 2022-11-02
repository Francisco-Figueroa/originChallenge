using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OriginsChallenge.Models
{
    public class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long CardNumber { get; set; }
        public bool IsBlocked { get; set; }
        public int FailedAttempts { get; set;}
        public int Pin { get; set; }
    }
}
