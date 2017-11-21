using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Discount
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public decimal Total { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
