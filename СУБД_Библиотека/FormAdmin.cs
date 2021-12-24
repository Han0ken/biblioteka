using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Библиотека
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void user_StudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsStud.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegBiblio frm = new FormRegBiblio();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {            
            EditAdmin frm = new EditAdmin();
            frm.user_StudBindingSource.Filter = bsStud.Filter;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
        }
    }
}
