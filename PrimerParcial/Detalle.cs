using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    public class Detalle
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}
