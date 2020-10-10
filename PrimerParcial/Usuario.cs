using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
    }
}
