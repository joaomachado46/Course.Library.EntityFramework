using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NovaLocalidade : Form
    {
        public NovaLocalidade()
        {
            InitializeComponent();
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new LibraryContext())
                {
                    var localidade = new Localidade()
                    {
                        CodigoPostal = int.Parse(textBoxCodigoPostal.Text),
                        Distrito = textBoxDistrito.Text,
                    };

                    contexto.Add(localidade);
                    contexto.SaveChanges();
                }
                panelFinalLocalidade.Show();
            }
            catch (Exception msg)
            {
                MessageBox.Show("Erro! " + msg.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NovaLocalidade_Load(object sender, EventArgs e)
        {
            panelFinalLocalidade.Hide();
        }
    }
}
