using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)

        {
            UsuarioPost("Bart", "1234");
            UsuarioPost("Lisa", "4321");
            UsuarioPost("Homero", "1222");

            GetUsers();

            IngresarUserID(1, "Tod Flanders");
            IngresarUserID(2, "Ned Flanders");

            GetUsers();

            EliminarUserID(2);
            ConsultarUsuarios();

        }
        static void UsuarioPost(string user, string clave)
        {
            var ctx = new TareaDbContext();

            ctx.Usuarios.Add(new Usuario
            {
                User = user,
                Clave = clave
            });

            ctx.SaveChanges();
        }

        static void GetUsers()
        {
            var ctx = new TareaDbContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.User} ({item.Id})");
            }
        }
        static void IngresarUserID(int id, string newUser)
        {
            var ctx = new TareaDbContext();

            var user = ctx.Usuarios.Where(i => i.Id == id).FirstOrDefault();
            if (user != null)
            {
                user.User = newUser;
            }
            ctx.SaveChanges();
        }

        static void ConsultarUsuarios()
        {
            var ctx = new TareaDbContext();

            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.User})");
            }
        }

        static void EliminarUserID(int id)
        {
            var ctx = new TareaDbContext();
            var user = ctx.Usuarios.Where(i => i.Id == id).Single();
            ctx.Usuarios.Remove(user);
            ctx.SaveChanges();
        }

    }
}