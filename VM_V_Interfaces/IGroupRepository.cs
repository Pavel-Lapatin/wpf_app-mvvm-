using AccessInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM_V_Interfaces
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        IEnumerable<Group> GetByParent(Group group);
        IEnumerable<Group> GetByParentId(int parentId);
    }
}
