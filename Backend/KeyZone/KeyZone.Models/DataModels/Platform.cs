using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Models.DataModels
{
    public class Platform
    {

        //nintendo , pc , xbox , playStation
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
