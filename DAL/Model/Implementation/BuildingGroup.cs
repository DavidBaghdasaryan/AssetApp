using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model.Abstraction;

namespace DAL.Model.Implementation
{
    public class BuildingGroup: IBaseFiealds, IBuildingFiealds
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
        public bool IsUpdated { get; set; }
    }
}
