using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        public Recurso[] GetRecursos()
        {
            var bd = new TareasDbContext();

            var list = bd.Recurso.ToArray();

            return list;

        }

        /*
        public Recurso[] GetRecursosAsync()
        {
            Recurso[] res = new Recurso[1];
            res[0] = new Recurso { Id = 1, Nombre = "T1", Usuario = new Usuario ()};
            return res;
        }
        */

    }
}