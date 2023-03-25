using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Models.DataModels
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public int PlatformId { get; set; }
        [ForeignKey("PlatformId")]
        public Platform Platform { get; set; }

        public int GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }

        public int Stock { get; set; }
    }
}
