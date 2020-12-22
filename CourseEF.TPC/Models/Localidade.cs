using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEF.TPC.Models
{
    public class Localidade
    {
        public int Id { get; set; }
        public int CodigoPostal { get; set; }
        public string Distrito { get; set; }

        public List<Utente> Utentes { get; set; }
        public List<Editora> Editoras { get; set; }

        public Localidade()
        {
        }

        public Localidade(int idCodigoPostal, string distrito)
        {
            Id = idCodigoPostal;
            Distrito = distrito;
        }
        public override string ToString()
        {
            return Distrito;
        }
    }
}
