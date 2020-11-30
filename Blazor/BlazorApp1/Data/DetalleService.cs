using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {
        public Detalle[] GetDatalles()
        {
            var bd = new TareasDbContext();

            var list = bd.Detalle.ToArray();

            return list;

        }

        /*
        public Detalle [] GetDatallesAsync()
        {
            Detalle[] res = new Detalleo[1];
            res[0] = new Usuario { int Id = 1, User = "U1", Clave = "C1" };
            
            return res;
        }
        */
    }
}
