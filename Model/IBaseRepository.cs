using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByDate(DateTime begin, DateTime end);
        void AddItem(T item);
        void ChangeItem(T item);
        void DeleteItem(T item);
    }
}
