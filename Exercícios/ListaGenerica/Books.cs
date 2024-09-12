using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaGenerica
{
    public enum GenderEnum {
        Terror, Ação, Aventura, Estudo
    }
    public class Books
    {
        public string? Title { get; set; }
        public string? Author { get; set;}
        public string? Publisher { get; set;}
        public int? PageNumber { get; set; }
        public GenderEnum Gender { get; set; }
    }
}