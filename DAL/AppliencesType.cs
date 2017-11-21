using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppliencesType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool ActiveStatus { get; set; }

        public  virtual List<ClientAppliences> MyProperty { get; set; }
    }
}
