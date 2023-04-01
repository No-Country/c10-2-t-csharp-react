using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Juego: BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Desarrollador { get; set; }
        public ICollection<JuegoPlataforma> JuegosPlataforma { get; set; }
        public RequisitosMin RequisitosMin { get;  set; }
        public int RequisitosMinId { get; set; }
        public RequisitosRec RequisitosRec { get; set; }
        public int RequisitosRecId { get; set; }

    }
}
