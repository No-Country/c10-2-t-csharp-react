using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class JuegoPlataforma 
    {
        public int IdJuego { get; set; }
        public Juego juego { get; set; }
        public int IdPlataforma { get; set; }
        public Plataforma plataforma { get; set; }
        public string Stock { get; set; }
        public float Precio { get; set; }
    }
}
