using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }

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

        [Column(TypeName = "decimal(18,2)")]
        public decimal FloorArea { get; set; }

        public int BuildingGroupId { get; set; }
        [ForeignKey("BuildingGroupId")]
        public BuildingGroup BuildingGroup { get; set; }

        public ICollection<Room> Rooms { get; set; }

    }
}
