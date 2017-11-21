using AccessInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    

    public class EmployeeRepository : IEmployeeRepository
    {
        private DAL.ServiceCenter context = new DAL.ServiceCenter();

        public void AddItem(Employee item)
        {
            throw new NotImplementedException();
        }

        public void ChangeItem(Employee item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Employee item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllByDate(DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }

        public bool CheckOwnerAccount()
        {
            var dbRole = context.EmployeeAccounts.Where((em) => em.Role.RoleName == "Owner").Select((ea) => ea.Role);
            if (dbRole != null)
            {
                return true;
            }
            return false;
        }    
    }
}
