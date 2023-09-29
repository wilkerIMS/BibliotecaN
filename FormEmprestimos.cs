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
    public partial class FormEmprestimos : Form
    {
        public FormEmprestimos()
        {
            InitializeComponent();
        }

        private void emprestimosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emprestimosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FormEmprestimos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.bibliotecaDataSet.Clientes);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Emprestimos' table. You can move, or remove it, as needed.
            this.emprestimosTableAdapter.Fill(this.bibliotecaDataSet.Emprestimos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            txtEmprestimoId.Text = id.ToString();
        }
    }
}
