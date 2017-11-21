using System;
using System.Collections.Generic;
using System.Text;

namespace AccessInterfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string MobilePhone { get; set; }
        string Phone { get; set; }
        string AdditionalInfo { get; set; }
    }
}
