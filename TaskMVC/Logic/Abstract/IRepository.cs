using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
        T Get(int id);
        void Add(T obj);
        void Edit(T obj);
    }
}
