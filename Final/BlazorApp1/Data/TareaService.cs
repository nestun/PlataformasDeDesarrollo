using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {


        private TareasDbContext context;

        public TareaService(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.GetAllTareas();
        }

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");
            return await remoteService.GetTarea(id);
        }


        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            if (value.Id == 0)
            {
                await remoteService.CreateTarea(value);
            }
            else
            {
                await remoteService.EditTarea(value);
            }
            return value;
        }


        public async Task<Tarea> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.DeleteTarea(id);
        }

    }
}
