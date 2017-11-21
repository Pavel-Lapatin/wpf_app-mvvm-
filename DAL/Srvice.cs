using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Srvice
    {
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual int ApplienceTypeId { get; set; }
        public virtual AppliencesType ApplienceType { get; set;}
        public virtual int ServiceTypeId { get; set; }
        public virtual ServiceType Type { get; set; }
        public virtual int  ServiceStatusId { get; set; }
        public virtual ServiceStatus ServiceStatus { get; set; }
        public string AdditionalDescription { get; set; }

        public decimal cost { get; set; }
    }
}
