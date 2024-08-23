using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Abstraction
{
    public interface IBaseRepo<T>
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        void RemoveRange(IEnumerable<T> items);
        void Save();
    }
}
