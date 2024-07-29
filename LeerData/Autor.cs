using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Autor
    {
        public int AutorId {get; set;}
        public string? Nombre {get; set;}
        public string? Apellidos{get; set;}
        public string? Grado {get; set;}
        public byte[]? FotoPerfil{get; set;}
        public ICollection<LibroAutor>? LibroLink{get; set;}
    }
}