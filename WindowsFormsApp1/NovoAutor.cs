using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NovoAutor : Form
    {
        public NovoAutor()
        {
            InitializeComponent();
        }

        private void btnSalvarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNomeAutor.Text == "" || textBoxLingua.Text == "" || textBoxPaisOrigem.Text == "")
                {
                    MessageBox.Show("Erro! ");
                }
                else
                {
                    using (var contexto = new LibraryContext())
                    {
                        var autor = new Autor()
                        {
                            Nome = textBoxNomeAutor.Text,
                            PaisOrigem = textBoxPaisOrigem.Text,
                            Lingua = textBoxLingua.Text,
                        };

                        contexto.Add(autor);
                        contexto.SaveChanges();
                    }
                    panelNovoAutorFinal.Show();
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Erro! " + msg.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AreaFuncionario areaFuncionario = new AreaFuncionario();
            areaFuncionario.Show();
            this.Close();
        }

        private void NovoAutor_Load(object sender, EventArgs e)
        {
            panelNovoAutorFinal.Hide();
        }
    }
}
