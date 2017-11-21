using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SpareParts
    {
        public string  Name { get; set; }
        public string SerialNumber { get; set; }
        public string Guarantee { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int CountryOfOrigin { get; set; }
        public CountryOfOrigin MyProperty { get; set; }

       
        public virtual ICollection<Contract> Contracts { get; set; }
       
        public virtual int ApplienceTypeId { get; set; }
        public virtual AppliencesType ApplienceType { get; set; }
        
        public virtual int ServiceTypeId { get; set; }
        public virtual ServiceType Type { get; set; }
        
        public string AdditionalDescription { get; set; }
        
        public decimal PurchaseCost { get; set; }
        public decimal ExtraCharge { get; set; }
        public decimal TotalCost { get; set; }

        public int MesurmentUinitId { get; set; }
        public MesurmentUnitId MesurmentUnit { get; set; }

        public string Discription { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
