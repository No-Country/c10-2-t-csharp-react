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

        public int Description { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

        public List<Platform> Platform { get; set; }

        public string Developer { get; set; }

        [Required]
        public int RequiremensPCId { get; set; }
        [ForeignKey("RequiremensPCId")]
        public RequirementsPC RequirementsPC { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public List<Category> Category { get; set; }


    }
}
