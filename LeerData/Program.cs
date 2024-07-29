using System;
using Microsoft.EntityFrameworkCore;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {   //Instancia a la clase 
            using(var db = new AppVentaLibrosContext())
            {
                // var libros = db.Libro?.AsNoTracking(); //Arreglo de objetos IQueryable
                // if (libros != null)
                // {
                //     foreach(var libro in libros)
                //     {
                //         Console.WriteLine(libro.Titulo + "--" + libro.Descripcion);
                //     }
                // }

                var libros = db.Libro?.Include(x=>x.PrecioPromocion).AsNoTracking(); //AsNoTracking no guarda data en cache
               if(libros != null){
                foreach(var libro in libros)
                {
                    Console.WriteLine(libro.Titulo + "--" + libro.PrecioPromocion?.PrecioActual);
                }
               }
               
            }
        }
    }
}

