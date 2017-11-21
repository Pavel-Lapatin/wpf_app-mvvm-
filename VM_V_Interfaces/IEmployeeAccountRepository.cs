using AccessInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM_V_Interfaces
{
    public interface IEmployeeAccountRepository
    {
        bool CreateAccount(string Login, string password, Employee employee, Role role);
        bool CheckOwnerAccount();
        bool Authentication(string login, string password);
        Employee GetEmployeeByLogin(string login);
    }
}
