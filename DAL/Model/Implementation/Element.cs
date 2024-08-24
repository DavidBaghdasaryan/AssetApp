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
    public class Element: IBaseFiealds
    {

        [Key]
        public int ElementId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime IntroductionDate { get; set; }

        public int Count { get; set; }

        [Required]
        [MaxLength(50)]
        public string Unit { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }
        public bool IsUpdated { get; set; }
    }
}
