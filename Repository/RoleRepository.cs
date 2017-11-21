using AccessInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoleRepository : IRoleRepository
    {
        DAL.ServiceCenter context = new DAL.ServiceCenter();

        public void AddItem(Role item)
        {
            DAL.Role dbRole = new DAL.Role()
            {
                RoleName = item.RoleName
            };
            try
            {
                context.Roles.Add(dbRole);
                context.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        public void ChangeItem(Role item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Role item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAllByDate(DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
