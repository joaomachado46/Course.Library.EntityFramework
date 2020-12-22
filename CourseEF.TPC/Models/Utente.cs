using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Utente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MoradaRua { get; set; }
        public int NumeroPorta { get; set; }
        public string AndarMoradia { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string DataNascimento { get; set; }
        public int CC { get; set; }
        public int LocalidadeId { get; set; }

        public Localidade Localidade { get; set; }
        public List<Requisicao> Requisicoes { get; set; }
        
        

        public Utente()
        {
        }

        public Utente(int idUtente, string nome, string moradaRua, int numeroPorta, string andarMoradia, string email, int telefone, string dataNascimento, int cC)
        {
            Id = idUtente;
            Nome = nome;
            MoradaRua = moradaRua;
            NumeroPorta = numeroPorta;
            AndarMoradia = andarMoradia;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            CC = cC;
        }
    }
}
