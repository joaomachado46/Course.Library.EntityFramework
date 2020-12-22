using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AreaCliente : Form
    {
        public AreaCliente()
        {
            InitializeComponent();
        }

        private void btnGravarRegisto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var obj2 = new LibraryContext())
                {
                    var utente = new Utente()
                    {
                        Nome = textBoxNome.Text,
                        MoradaRua = textBoxMorada.Text,
                        NumeroPorta = int.Parse(textBoxNumPorta.Text),
                        AndarMoradia = textBoxAndar.Text,
                        
                       
                        Email = textBoxEmail.Text,
                        Telefone = int.Parse(textBoxTelefone.Text),
                        DataNascimento = textBoxDataNascimento.Text,
                        CC = int.Parse(textBoxCC.Text),
                    };

                    obj2.Utentes.Add(utente);
                    obj2.SaveChanges();
                }
                pnlFinalCliente.Show();
            }
            catch (Exception msg)
            {

                MessageBox.Show("Erro!! " + msg.Message);
            }
        }

        private void btnListarLivros_Click(object sender, EventArgs e)
        {
            ListarLivros novoForm = new ListarLivros();
            novoForm.Show();
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AreaCliente_Load(object sender, EventArgs e)
        {
            using (var item = new LibraryContext())
            {
                
                    comboBox1.DataSource = item.Localidades.ToList();
                
            }
            
            pnlCliente.Show();
            pnlFinalCliente.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovaLocalidade nova = new NovaLocalidade();
            nova.Show();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AreaCliente areaCliente = new AreaCliente();
            areaCliente.Show();
            Close();
        }
    }
}
