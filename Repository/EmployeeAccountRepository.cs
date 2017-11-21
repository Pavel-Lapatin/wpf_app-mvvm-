using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessInterfaces;
using VM_V_Interfaces;
using Model;

namespace Repository
{
    public class EmployeeAccountRepository : IEmployeeAccountRepository
    {
        
        DAL.ServiceCenter context = new DAL.ServiceCenter();

        public bool Authentication(string login, string password)
        {
            try
            {
                var hashPassword = context.EmployeeAccounts.Where(ea => ea.Login == login).First().Password;
                return BCrypt.Net.BCrypt.Verify(password, hashPassword);
            } catch (Exception) { return false; }
        }
        public bool CheckOwnerAccount()
        {
            int ownerCounts = context.EmployeeAccounts.Where((em) => em.Role.RoleName == "Owner").Count();
            if (ownerCounts == 0) return false;
            else if (ownerCounts == 1) return true;
            else throw new ArgumentException();
        }
        public bool CreateAccount(string login, string password, Employee employee, Role role)
        {
            int roleCheck = context.Roles.Where((em) => em.RoleName == role.RoleName).Count();
            if (login == null || password == null) return false;
            else
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
                DAL.Role dbRole = new DAL.Role()
                {
                    RoleName = role.RoleName
                };
                DAL.EmployeeAccount dbAccount = new DAL.EmployeeAccount()
                {
                    Password = hashPassword,
                    Login = login,
                    Role = dbRole,
                    RegistrationDate = DateTime.Now,                    
                };

                if(employee != null)
                {
                    DAL.Employee dbEmployee = new DAL.Employee();
                    ConvertionsTypes.ConvertIEmployeeToDALEmployee(employee, dbEmployee);
                    dbAccount.Employee = dbEmployee;
                }

                try
                {
                    if (roleCheck == 0) context.Roles.Add(dbRole);
                    context.EmployeeAccounts.Add(dbAccount);
                    context.SaveChanges();
                }
                catch (Exception e) {
                    string masg = e.Message;
                    return false; }
            }
            return true;
        }


        public Employee GetEmployeeByLogin(string login)
        {
            try
            {
                var account = context.EmployeeAccounts.Where(c => c.Login == login).DefaultIfEmpty(null).First();
                if (account.Employee != null)
                {
                    Employee employee = new Employee();
                    if(employee != null)
                    {
                        ConvertionsTypes.ConvertDALEmployeeToIEmployee(account.Employee, employee);
                        return employee;
                    }
                }
            }
            catch (Exception) { return null; }
            return null;
        } 
        
    } 
}
