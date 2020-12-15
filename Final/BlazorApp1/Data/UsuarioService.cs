using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {

        private TareasDbContext context;

        public UsuarioService(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");
            return await remoteService.GetUsuario(id);
        }
                
        
        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.GetAllUsuarios();
        }
        
        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            if (value.Id == 0)
            {
                await remoteService.CreateUsuario(value);
            }
            else
            {
                await remoteService.EditUsuario(value);
            }
            return value;
        }


        public async Task<Usuario> Remove (int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.DeleteUsuario(id);
        }

    }
}
