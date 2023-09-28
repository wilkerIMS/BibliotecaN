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
            this.tableAdapterManager.UpdateAll(this.bilbliotecaDataSet);

        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bilbliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bilbliotecaDataSet.Autores);
            // TODO: This line of code loads data into the 'bilbliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bilbliotecaDataSet.Livros);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Guid livroId = new Guid();
            //txtLivroID.Text = livroId.ToString();
        }

        private void txtLivroID_TextChanged(object sender, EventArgs e)
        {
            txtLivroID.Text = new Guid().ToString();
        }
    }
}
