using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class RequisitosRec:BaseEntity
    {
        public string SO { get; set; }
        public string Procesador { get; set; }
        public string Memoria { get; set; }
        public string Graficos { get; set; }
        public string Almacenamiento { get; set; }
        public string Directx { get; set; }
        public string Red { get; set; }
        public string Notas { get; set; }
    }
}
