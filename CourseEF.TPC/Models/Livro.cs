using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLançamento { get; set; }
        public string Estado { get; set; }
        public string Género { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
        public List<Requisicao> Requisicoes { get; set; }
        public ICollection<LivroAutor> LivrosAutores { get; set; }

        public Livro()
        {
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
