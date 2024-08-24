using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Abstraction
{
    public interface IBuildingFiealds
    {
        public DateTime ConstructionDate { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
