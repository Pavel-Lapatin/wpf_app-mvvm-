using GalaSoft.MvvmLight;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeRegistrationData
    {
        private string login;

        private string password;

        private int salt;

        bool doesPasswordMatch(string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        void SetPassword(string password)
        {
            
        }

    }
}
