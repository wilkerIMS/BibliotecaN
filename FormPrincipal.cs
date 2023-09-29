using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutores form = new FormAutores();
            form.ShowDialog();
        }

        private void cadastrarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLivros form = new FormLivros();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprestimos form = new FormEmprestimos();
            form.ShowDialog();
        }
    }
}
