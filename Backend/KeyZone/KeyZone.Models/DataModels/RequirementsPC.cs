using KeyZone.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Models.DataModels
{
    public class RequirementsPC
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<SO> SO { get; set; }
        [Required]
        public string Processor { get; set; }

        [Required]
        public string Memory { get; set; }
        [Required]
        public string Graphics { get; set; }

        public string Storage { get; set; }

        public string DirectX { get; set; }

        public string Network { get; set; }


    }
}
