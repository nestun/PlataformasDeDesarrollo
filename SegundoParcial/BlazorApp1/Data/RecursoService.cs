using Microsoft.EntityFrameworkCore;
using System;
using Model.Entidades;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        private TareasDbContext context;

        public RecursoService(TareasDbContext _context)
        {
            context = _context;
        }


        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");
            return await remoteService.GetRecurso(id);
        }


        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.GetAllRecursos();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            if (value.Id == 0)
            {
                await remoteService.CreateRecurso(value);
            }
            else
            {
                await remoteService.EditRecurso(value);
            }
            return value;
        }


        public async Task<Recurso> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.DeleteRecurso(id);
        }


        public async Task<List<Usuario>> GetUsuarios()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.GetAllUsuarios();
        }

    }
}
