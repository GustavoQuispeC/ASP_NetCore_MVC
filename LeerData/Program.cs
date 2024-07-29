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
                //! consulta de one to one
                // var libros = db.Libro?.AsNoTracking(); //Arreglo de objetos IQueryable
                // if (libros != null)
                // {
                //     foreach(var libro in libros)
                //     {
                //         Console.WriteLine(libro.Titulo + "--" + libro.Descripcion);
                //     }
                // }
                //! consulta de one to many

                //     var libros = db.Libro?.Include(x=>x.PrecioPromocion).AsNoTracking(); //AsNoTracking no guarda data en cache
                //    if(libros != null){
                //     foreach(var libro in libros)
                //     {
                //         Console.WriteLine(libro.Titulo + "--" + libro.PrecioPromocion?.PrecioActual);
                //     }
                //    }
                //! consulta de many to many
                // var libros = db.Libro?.Include(x=>x.ComentarioLista).AsNoTracking();
                // if(libros != null){
                //     foreach(var libro in libros){
                //         Console.WriteLine(libro.Titulo);
                        
                //         foreach(var comentario in libro.ComentarioLista )
                //         {
                //             Console.WriteLine("  * "+ comentario.ComentarioTexto);
                //         }
                //     }
                // }
                //! consulta de many to many

                // var libros = db.Libro.Include(x=>x.AutorLink).ThenInclude(xi=>xi.Autor);
                // foreach(var libro in libros){
                //     Console.WriteLine(libro.Titulo);
                //     foreach(var autLink in libro.AutorLink)
                //     {
                //         Console.WriteLine("--" + autLink.Autor.Nombre);
                //     }
                // }
               
               //! insertando data
            //    var nuevoAutor1 = new Autor{
            //     Nombre = "Pedro",
            //     Apellidos = "Ruiz",
            //     Grado = "Master"
            //    };
            //    db.Add(nuevoAutor1);

            //    var nuevoAutor2 = new Autor{
            //     Nombre = "Jose",
            //     Apellidos = "Manrique",
            //     Grado = "Master"
            //    };
            //    db.Add(nuevoAutor2);
               
            //    var estadoTransaccion = db.SaveChanges();
            //    Console.WriteLine("Estado de transaccion ==> " + estadoTransaccion);

            //! actualizar data
            // var autor = db.Autor?.Single(x=>x.Nombre =="Jose");
            // if(autor != null){
            //     autor.Apellidos="Mendez";
            //     autor.Grado = "Practicante";
            //     var estadoTransaccion = db.SaveChanges();
            //     Console.WriteLine("Estado transanccion ==> " + estadoTransaccion);
            // }

            //! eliminar
            var autor = db.Autor?.Single(x=>x.AutorId == 9);
            if(autor != null){
                db.Remove(autor);
                var estadoTransaccion = db.SaveChanges();
                Console.WriteLine("estado de transaccion ==> " + estadoTransaccion);
            }





            }
        }
    }
}
