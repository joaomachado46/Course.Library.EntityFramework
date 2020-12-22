using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public string Lingua { get; set; }

        public ICollection<LivroAutor> LivrosAutores { get; set; }

        public Autor()
        {
        }

        public override string ToString()
        {
            return  Nome;
        }
    }
}

