using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Requisicao
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public DateTime DataRequisicao { get; set; }
        public DateTime DataDevoluçao { get; set; }
        //public int UtenteId { get; set; }
        public Utente Utente { get; set; }
        public Livro Livro { get; set; }

        public Requisicao()
        {
        }

        public Requisicao(int idRequisicao, int idLivro, DateTime dataRequisicao, DateTime dataDevoluçao)
        {
            Id = idRequisicao;
            LivroId = idLivro;
        
            DataRequisicao = dataRequisicao;
            DataDevoluçao = dataDevoluçao;
        }
    } 
}
