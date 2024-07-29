using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Precio
    {
        public int PrecioId {get; set;}
        public decimal PrecioActual{get;set;}
        public decimal Promocion {get; set;}
        public int LibroId {get; set;}
        public Libro? libro {get; set;} //FK
    }
}