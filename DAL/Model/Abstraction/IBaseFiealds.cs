using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Abstraction
{
    public interface IBaseFiealds
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsUpdated { get; set; }
    }
}
