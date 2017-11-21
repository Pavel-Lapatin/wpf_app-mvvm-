using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Client : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                bool hasError = false;
                if (ValidationOn)
                {
                    switch (columnName)
                    {
                        case nameof(Employee):
                            if (Employee == null)
                            {
                                AddError("Manager required", nameof(Employee));
                                hasError = true;
                            }
                            if (!hasError) ClearErrors(nameof(Employee));
                            break;
                        case nameof(Id):
                            break;
                        case nameof(Name):
                            //if (Name == null)
                            //{
                            //    AddError("Name required", nameof(Name));
                            //    hasError = true;
                            //}
                            //if (!hasError) ClearErrors(nameof(Name));
                            break;
                        case nameof(PassportSeria):
                            break;
                        case nameof(PassportNumber):
                            if (PassportNumber != null)
                            {
                                if (PassportNumber.Length != 7)
                                {
                                    AddError("hould be 7 digits", nameof(PassportNumber));
                                    hasError = true;
                                }
                            }
                            else
                            {
                                AddError("Empty", nameof(PassportNumber));
                                hasError = true;
                            }
                            if (!hasError) ClearErrors(nameof(PassportNumber));
                            break;
                        case nameof(Address):
                            break;
                        case nameof(Email):
                            break;
                        case nameof(Phone):
                            break;
                        case nameof(Group):
                            break;
                        case nameof(PassprotDateOfIssue):
                            break;
                        case nameof(PassportIssuedBy):
                            break;
                        case nameof(RegistrationDate):
                            break;
                        case nameof(SMSStatus):
                            break;
                        case nameof(EmailStatus):
                            break;
                        case nameof(ResponsibilityStatus):
                            break;
                        case nameof(MobilePhone):
                            break;
                        case nameof(AdditionalInfo):
                            break;
                    }
                }
                return string.Empty;
            }
        }

        public string Error => throw new NotImplementedException();
    }
}
