using Microsoft.EntityFrameworkCore;
using System;
using Model.Entidades;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {

        private TareasDbContext context;

        public DetalleService(TareasDbContext _context)
        {
            context = _context;
        }


        public async Task<List<Detalle>> GetAll(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.GetAllDetalles(Id);
        }

        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");
            return await remoteService.GetDetalle(id);
        }


        public async Task<Detalle> Save(Detalle value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            if (value.Id == 0)
            {
                await remoteService.CreateDetalle(value);
            }
            else
            {
                await remoteService.EditDetalle(value);
            }
            return value;
        }

        public async Task<Detalle> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44323/api");

            return await remoteService.DeleteDetalle(id);
        }
        
    }
}
