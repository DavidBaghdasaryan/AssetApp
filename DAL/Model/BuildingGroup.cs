using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BuildingGroup 
    {

        [Key]
        public int BuildingGroupId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime ConstructionDate { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public string Description { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public BDProject Project { get; set; }

        public ICollection<Building> Buildings { get; set; }
    }
}
