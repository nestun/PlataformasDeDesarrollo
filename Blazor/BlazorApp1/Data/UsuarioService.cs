using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        public Usuario[] GetUsuarios()
        {
            var bd = new TareasDbContext();

            var list = bd.Usuarios.ToArray();

            return list;

        }



        /*
        public Usuario[] GetUsuarios()
        {
            Usuario[] res = new Usuario[5];
            res[0] = new Usuario { Id = 1, User = "U1", Clave = "C1" };
            res[1] = new Usuario { Id = 2, User = "U2", Clave = "C2" };
            res[2] = new Usuario { Id = 3, User = "U3", Clave = "C3" };
            res[3] = new Usuario { Id = 4, User = "U4", Clave = "C4" };
            res[4] = new Usuario { Id = 5, User = "U5", Clave = "C5" };
            return res;
        }
        */
    }
}