using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public interface IModifyer<T>
    {
        public void Create(T item);
        public void Update(T item);
        public void Delete(T item);
    }
}
