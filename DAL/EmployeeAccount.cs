using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeAccount
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual int RoleId { get; set; }
        public virtual Role Role { get; set; }


    }
}
