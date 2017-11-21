using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Payment
    {
        public int Id { get; set; }
        public virtual int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public DateTime PaymentTime { get; set; }
        public virtual int PaymentTypeId { get; set; }
        public virtual PaymentType Type { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentSize { get; set; }
        public virtual int CurrencyId { get; set; }
        public virtual Currency PaymentCurrency  { get; set; }

        
    }
}
