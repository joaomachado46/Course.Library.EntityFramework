using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AreaFuncionario : Form
    {
        public AreaFuncionario()
        {
            InitializeComponent();
        }

        private void btnSairFuncionario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AreaFuncionario_Load(object sender, EventArgs e)
        {
            using (var obj = new LibraryContext())
            {
                comboBoxEditoras.DataSource = obj.Editoras.ToList();

                comboBoxAutor.DataSource = obj.Autores.ToList();
            }

            pnlFuncionario.Show();
            pnlFinalFunc.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new LibraryContext())
                {

                    Editora editoraAtri = null;

                    foreach (Editora editora in ctx.Editoras)
                    {
                        if (editora.Nome == comboBoxEditoras.Text)
                        {

                            editoraAtri = editora;
                        }
                        else
                        {
                            editoraAtri = new Editora { Nome = comboBoxEditoras.Text };
                        }
                    }
                    var dadoLivro = new Livro()
                    {
                        Titulo = textBoxTitulo.Text,
                        AnoLançamento = int.Parse(textBoxLancamento.Text),
                        Estado = textBoxEstado.Text,
                        Género = textBoxGenero.Text,
                        Preco = decimal.Parse(textBoxPreco.Text),
                        Quantidade = int.Parse(textBoxQuantidade.Text),
                        Editora = editoraAtri,
                    };


                    Autor autorExistente;
                    Autor autorNovo;
                    foreach (Autor item in ctx.Autores)
                    {
                        if (item.Nome == comboBoxAutor.Text)
                        {

                            autorExistente = item;
                            ctx.AddRange(new LivroAutor { Livro = dadoLivro, Autor = autorExistente });
                        }
                        else
                        {
                            autorNovo = new Autor()
                            {
                                Nome = comboBoxAutor.Text,

                            };
                            ctx.AddRange(new LivroAutor { Livro = dadoLivro, Autor = autorNovo });
                        }
                    }
                    ctx.SaveChanges();
                }


                pnlFinalFunc.Show();
            }
            catch (Exception msg)
            {
                MessageBox.Show("Erro!! " + msg.Message);
            }
        }

        private void btnNovaEditora_Click(object sender, EventArgs e)
        {
            NovaEditora nova = new NovaEditora();
            nova.Show();
            Close();
        }

        private void btnNovoAutor_Click_1(object sender, EventArgs e)
        {
            NovoAutor novo = new NovoAutor();
            novo.Show();
            Close();
        }

        private void btnNovoLivro_Click_1(object sender, EventArgs e)
        {
            textBoxLancamento.ResetText();
            textBoxEstado.ResetText();
            textBoxGenero.ResetText();
            textBoxPreco.ResetText();
            textBoxQuantidade.ResetText();
            comboBoxAutor.Refresh();
            comboBoxEditoras.Refresh();
            textBoxTitulo.ResetText();
            pnlFinalFunc.Hide();
        }
    }
}
