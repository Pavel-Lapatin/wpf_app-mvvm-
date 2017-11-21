using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string PassportSeria { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassprotDateOfIssue { get; set; }
        public string PassportIssuedBy { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool SMSStatus { get; set; }
        public bool EmailStatus { get; set; }
        public bool ResponsibilityStatus { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual int EmployeeId { get; set; }
        public virtual Employee Manager { get; set; }

        public virtual int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual List<ClientAppliences> Applinces { get; set; }
    }
}
