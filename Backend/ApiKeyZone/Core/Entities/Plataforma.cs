using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Plataforma : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<JuegoPlataforma> JuegosPlataformas { get; set; }
    }
}
