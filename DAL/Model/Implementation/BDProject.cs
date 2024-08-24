using DAL.Model.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Implementation
{
    public class BDProject: IBaseFiealds
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        public ICollection<BuildingGroup> BuildingGroups { get; set; }
        public bool IsUpdated { get; set; }
    }
}
