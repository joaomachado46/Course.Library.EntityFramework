using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListarLivros : Form
    {
        public ListarLivros()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            textBoxRequisicao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            using (var obj = new LibraryContext())
            {
                comboBox1.DataSource = obj.Livros.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dados = new LibraryContext())
            {
                try
                {
                    Livro livroAtribuido = null;
                    foreach (var livro in dados.Livros)
                    {
                        if (livro.Titulo == comboBox1.Text)
                        {
                            livroAtribuido = livro;
                        }
                        else
                        {
                            livroAtribuido = new Livro
                            {
                                Titulo = comboBox1.Text
                            };
                        }
                    }
                    var requisicao = new Requisicao
                    {
                        DataRequisicao = DateTime.Parse(textBoxRequisicao.Text),
                        DataDevoluçao = DateTime.Parse(textBoxDevoluçao.Text),
                        Livro = livroAtribuido
                    };

                    dados.Add(requisicao);
                    dados.SaveChanges();

                    panel1.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro! Preencha todos os dados.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dados = new LibraryContext())
            {
                try
                {
                    foreach (var item in dados.Utentes)
                    {
                        if (textBoxNomeRequisição.Text == item.Nome)
                        {
                            txtImpriDadosCliente.Text = item.Id + "- " + item.Nome + ", " + item.MoradaRua + ", " + item.Telefone;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro! Preencha todos os dados.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
