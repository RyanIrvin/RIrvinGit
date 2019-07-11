using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtTesting
{
    public class Transaction
    {
        public int Type { get; set; }
        public DateTime Time { get; set; }
        public int Channel { get; set; }
        public int Fm { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public int ItemStatsId { get; set; }
    }
}
