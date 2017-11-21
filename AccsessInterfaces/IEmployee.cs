using System;
using System.Collections.Generic;
using System.Text;

namespace AccessInterfaces
{
    public interface IEmployee : IPerson
    {
        string Position { get; set; }
        DateTime RegistrationDate { get; set; }
        int SotialSecurityNumber { get; set; }
        int WorkingStatus { get; set; }
    }
}
