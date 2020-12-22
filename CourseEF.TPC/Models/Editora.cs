using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int NumeroPorta { get; set; }
        public int Andar { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }

        public int LocalidadeId { get; set; }
        public Localidade Localidade { get; set; }
        public ICollection<Livro> Livros { get; set; }

        public Editora()
        {
        }

        public Editora(int idEditora, string nome, string morada, int numeroPorta, int andar, int telefone, string email, string webSite)
        {
            Id = idEditora;
            Nome = nome;
            Morada = morada;
            NumeroPorta = numeroPorta;
            Andar = andar;
            Telefone = telefone;
            Email = email;
            WebSite = webSite;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
