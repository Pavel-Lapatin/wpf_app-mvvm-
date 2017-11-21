using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using VM_V_Interfaces;

namespace Repository
{
    public class GroupRepository : IGroupRepository
    {
        DAL.ServiceCenter context = new DAL.ServiceCenter();
        public void AddItem(Group item)
        {
            throw new NotImplementedException();
        }

        public void ChangeItem(Group item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Group item)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Group> GetAll()
        {
            return context.Groups.ToArray().Select(c =>
            {
                var cl = new Group();
                ConvertionsTypes.ConvertDALGroupToIGroup(c, cl);
                return cl;
            });
        }

        public IEnumerable<Group> GetByParent(Group parentGroup)
        {
            return context.Groups.Where(c => c.ParentGroup.Id == parentGroup.Id).ToArray().Select(c =>
            {
                var cl = new Group();
                ConvertionsTypes.ConvertDALGroupToIGroup(c, cl);
                return cl;
            });
        }

        public IEnumerable<Group> GetByParentId(int parentId)
        {
            List<Group> gr = new List<Group>();
            var groups = context.Groups.Where(c => c.ParentGroup.Id == parentId).ToArray();
            foreach (var item in groups)
            {
                var cl = new Group();
                ConvertionsTypes.ConvertDALGroupToIGroup(item, cl);
                gr.Add(cl);
            }
            return gr;
            
            /*
            return context.Groups.Where(c => c.ParentGroup.Id ==parentId).ToArray().Select(c =>
            {
                var cl = new Group();
                ConvertionsTypes.ConvertDALGroupToIGroup(c, cl);
                return cl;
            });
            */
        }

        public IEnumerable<Group> GetAllByDate(DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
