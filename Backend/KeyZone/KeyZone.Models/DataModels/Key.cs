using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Models.DataModels
{
    public class KeyGame
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid KeyCode { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool Sold { get; set; }

        [Required]
        public int PlatformId { get; set; }
        [ForeignKey("PlatformId")]
        public Platform Platform { get; set; }

        [Required]
        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }

    }
}
