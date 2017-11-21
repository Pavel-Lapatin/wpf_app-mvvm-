using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contract
    {
        public int Id { get; set; }
        public string MalfunctionClientDescription { get; set; }
        public string MalfunctionDefinedDescription { get; set; }
        public string CompleteSet { get; set; }
        public string AdditionalInformation { get; set; }


        public virtual ICollection<Srvice> Services { get; set; }
        public virtual ICollection<SpareParts> SpareParts { get; set; }
        public virtual int StorageId { get; set; }
        public virtual Storage Storage { get; set; }
        public virtual int FirmId { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual int clientId { get; set; }
        public virtual Client ClientId { get; set; }
        public int ContractStatusId { get; set; }
        public virtual ContractStatus Status { get; set; }

    }
}
