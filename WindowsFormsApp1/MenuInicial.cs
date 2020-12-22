using CourseEF.TPC.DataContext;
using CourseEF.TPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
    public partial class MenuInicial : System.Windows.Forms.Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AreaFuncionario novo = new AreaFuncionario();
            novo.Show();
        }

        private void btnSairFuncionario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSairInicial_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AreaCliente novo = new AreaCliente();
            novo.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ListarLivros novoForm = new ListarLivros();
            novoForm.Show();
        }
    }
}

