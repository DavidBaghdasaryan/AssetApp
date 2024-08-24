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
    public class Room: IBaseFiealds
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        public string Description { get; set; }

        [Required]
        [MaxLength(20)]
        public string RoomNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FloorArea { get; set; }

        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }

        public ICollection<Element> Elements { get; set; }
        public bool IsUpdated { get; set; }=false;
    }
}
