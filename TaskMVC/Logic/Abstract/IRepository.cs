using System.Collections.Generic;

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
