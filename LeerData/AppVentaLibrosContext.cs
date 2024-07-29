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
        //Representacion de la tabla
        public DbSet<Libro>? Libro {get; set;}
        public DbSet<Precio>?Precio{get;set;}

    }


}