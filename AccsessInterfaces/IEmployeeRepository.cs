using System;
using System.Collections.Generic;
using System.Text;

namespace AccessInterfaces
{
    public interface IEmployeeRepository : IBaseRepository<IEmployee>
    {
        IEmployee employee { get; set; }
        IEmployee GetOwner();
    }
}
