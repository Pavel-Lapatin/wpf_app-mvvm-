using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientAppliences
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }


        public int AppliencestypeId { get; set; }
        public AppliencesType Type { get; set; }

        public virtual int ClientId { get; set; }
        public virtual Client Client { get; set; }

    }
}
