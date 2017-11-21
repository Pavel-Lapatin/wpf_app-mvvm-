
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public string Position { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int SotialSecurityNumber { get; set; }
        public int WorkingStatus { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public string AdditionalInfo { get; set; }
        public int Id { get; set; }
    }
}
