using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessInterfaces
{
    public interface IClient : IPerson
    {
        string Group { get; set; }
        string PassportSeria { get; set; }
        string PassportNumber { get; set; }
        DateTime PassprotDateOfIssue { get; set; }
        string PassportIssuedBy { get; set; }
        DateTime RegistrationDate { get; set; }
        bool SMSStatus { get; set; }
        bool EmailStatus { get; set; }
        int ResponsibilityStatus { get; set; }
    }
}
