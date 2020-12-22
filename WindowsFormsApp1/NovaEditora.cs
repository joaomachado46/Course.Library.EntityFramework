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
    public partial class NovaEditora : Form
    {
        public NovaEditora()
        {
            InitializeComponent();
        }

        private void NovaEditora_Load(object sender, EventArgs e)
        {
            using (var obj = new LibraryContext())
            {
                comboBoxLocalidade.DataSource = obj.Localidades.ToList();
            }
            panelFinalEditora.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovaLocalidade nova = new NovaLocalidade();
            nova.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    Localidade localidadeAtri = null;

                    foreach (var item in context.Localidades)
                    {
                        if (item.Distrito == comboBoxLocalidade.Text)
                        {
                            localidadeAtri = item;
                        }
                        else
                        {
                            localidadeAtri = new Localidade { Distrito = comboBoxLocalidade.Text };
                        }
                    }
                    var editora = new Editora()
                    {
                        Nome = textBoxNomeEditora.Text,
                        Morada = textBoxMoradaEdit.Text,
                        NumeroPorta = int.Parse(textBoxNPorta.Text),
                        Andar = int.Parse(textBoxAndarEdit.Text),
                        Telefone = int.Parse(textBoxTelefoneEdit.Text),
                        Email = textBoxEmailEdit.Text,
                        WebSite = textBoxWebSite.Text,
                        Localidade = localidadeAtri,
                    };

                    context.Add(editora);
                    context.SaveChanges();
                }
                panelFinalEditora.Show();
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
        }
    }
