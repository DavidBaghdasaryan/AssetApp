using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public interface IModifyer
    {
        public void Create();
        public void Update();
        public void Delete();
    }
}
