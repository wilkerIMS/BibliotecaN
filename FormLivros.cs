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
    public partial class FormLivros : Form
    {
        public FormLivros()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'bilbliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
            // TODO: This line of code loads data into the 'bilbliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bibliotecaDataSet.Livros);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Guid livroId = Guid.NewGuid();
            txtLivroID.Text = livroId.ToString();
        }

        private void txtLivroID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void livrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            txtLivroID.Text = id.ToString();
        }
    }
}
