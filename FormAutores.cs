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
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
        }

        private void autoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bilbliotecaDataSet);

        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bilbliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bilbliotecaDataSet.Autores);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
           /* Guid id =  new Guid();
            txtId.Text = id.ToString();*/
            txtId.Text = new Guid().ToString();
        }
    }
}
