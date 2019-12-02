using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalChallenge.Models
{
    public class Fixture
    {
        public int ID { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public int CourtFee { get; set; }
        public int AmountPaid { get; set; }
    }
}
