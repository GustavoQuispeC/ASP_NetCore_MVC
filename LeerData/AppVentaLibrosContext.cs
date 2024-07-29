using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaLibrosContext :DbContext
    {
        //Conexion a BD
        private const string connectionString =@"Data Source=GustavoPC\SQLEXPRESS; Initial Catalog=LibrosWeb; Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        //Indica que tiene dos PK
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibroAutor>().HasKey(xi=> new {
                xi.AutorId, xi.LibroId
            });
        }
        //Representacion de la tabla
        public DbSet<Libro>? Libro {get; set;}
        public DbSet<Precio>?Precio{get;set;}
        public DbSet<Comentario>?Comentario{get;set;}
        public DbSet<Autor>?Autor{get; set;}
        public DbSet<LibroAutor>? LibroAutor{get; set;}

    }


}