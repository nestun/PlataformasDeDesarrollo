using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Tarea[] GetTareas()
        {
            var bd = new TareasDbContext();

            var list = bd.Tarea.ToArray();

            return list;
        }



        /*
        public Tarea [] GetTareasAsync()
        {
            Tarea[] res = new Tarea[1];
            res[0] = new Tarea { Id = 1, Titulo = "T1", Vencimiento = new DateTime (2008, 10, 1), Estimacion = new DateTime(2008, 10, 1), ResponsableId = 1, Estado = true };
            return res;
        }
        */
    }
}