using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class LibroAutor
    {
        public int AutorId{get;set;}
        public int LibroId{get; set;}
        public Libro? Libro{get; set;} //ancla
        public Autor? Autor {get; set;}//ancla
    }
}