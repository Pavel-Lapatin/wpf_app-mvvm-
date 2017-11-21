using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int? GroupId { get; set; }
        public virtual Group ParentGroup { get; set; }

        public virtual List<Client> Client { get; set; }
        public virtual List<Group> Groups { get; set; }
    }
}
