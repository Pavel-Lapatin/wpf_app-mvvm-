
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;




namespace Model
{
    public partial class Client : ModelBase
    {
        private Regex passportNumberPattern = new Regex("[0-9].");
        public Client()
        {
            Employee = new Employee();
            Group = new Group();
            ValidationOn = false;
        }
        
        private Employee employee;
        [Required(AllowEmptyStrings = false)]
        public Employee Employee 
        {
            get { return employee; }
            set { Set(ref employee, value); }
        }

        private int id;
        [Required]
        public int Id
        {
            get { return id; }
            set { Set( ref id, value); }
        }
        
        private string name;
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            get { return name; }
            set {
                name = value;
                Set(ref name, value);}
        }

        private string passportSeria;
        [Required]
        public string PassportSeria
        {
            get { return passportSeria; }
            set {Set(ref passportSeria, value);}
        }

        private string passportNumber;
        [Required]
        public string PassportNumber
        {
            get { return passportNumber; }
            set
            {
                passportNumber = value;
                Set(ref passportNumber, value);
            }
        }

        private string address;
        [Required]
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                Set(ref address, value);
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { Set(ref email, value); }
        }
        private string phone;
        [Required]
        public string Phone
        {
            get { return phone; }
            set { Set(ref phone, value); }
        }

        private Group group;
        [Required]
        public Group Group
        {
            get { return group; }
            set { Set(ref group, value); }
        }

        private DateTime passprotDateOfIssue;
        [Required]
        public DateTime PassprotDateOfIssue {
            get { return passprotDateOfIssue; }
            set { Set(ref passprotDateOfIssue, value); }
        }

        private string passportIssuedBy;
        [Required]
        public string PassportIssuedBy {
            get { return passportIssuedBy; }
            set { Set(ref passportIssuedBy, value); }
        }

        private DateTime registrationDate;
        [Required]
        public DateTime RegistrationDate {
            get { return registrationDate; }
            set { Set(ref registrationDate, value); }
        }

        private bool smsStatus = false;
        public bool SMSStatus {
            get { return smsStatus; }
            set { Set(ref smsStatus, value); }
        }

        private bool emailStatus = false;
        public bool EmailStatus {
            get { return emailStatus; }
            set { Set(ref emailStatus, value); }
        }

        private bool  responsibilityStatus = false;
        public bool ResponsibilityStatus {
            get { return responsibilityStatus; }
            set { Set(ref responsibilityStatus, value); }
        }

        private string mobilePhone;
        public string MobilePhone {
            get { return mobilePhone; }
            set { Set(ref mobilePhone, value); }
        }

        private string additionalInfo;
        public string AdditionalInfo {
            get { return additionalInfo; }
            set { Set(ref additionalInfo, value); }
        }

    }
}
