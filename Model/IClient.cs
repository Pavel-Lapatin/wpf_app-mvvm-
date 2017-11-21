using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IClient
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string PassportSeria { get; set; }
        string PassportNumber { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Group { get; set; }

    }
}
