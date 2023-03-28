using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Models.DataModels
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

        public List<Inventory> Inventory { get; set; }

        public string Developer { get; set; }

        [Required]
        public int RequiremensPCId { get; set; }
        [ForeignKey("RequiremensPCId")]
        public RequirementsPC RequirementsPC { get; set; }

        [Required]
        public List<GameCategory> GameCategory { get; set; }


    }
}
