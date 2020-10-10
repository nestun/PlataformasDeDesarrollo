using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
