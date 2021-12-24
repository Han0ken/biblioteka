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
    public partial class FormRegBiblio : Form
    {
        public FormRegBiblio()
        {
            InitializeComponent();
        }

        private void FormRegBiblio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
            user_LibrarianBindingSource.AddNew();
            bdayDateTimePicker.Value = DateTime.Now;
        }

        private void user_LibrarianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_LibrarianBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || famTextBox.Text == "" || loginTextBox.Text == "" || passTextBox.Text == "")
            {
                MessageBox.Show("Заполните все строки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (!Passw.Password.Check(passTextBox.Text))
            {
                MessageBox.Show("Пароль не соответсвует требованиям безопастности.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            user_LibrarianBindingSource.EndEdit();
            this.user_LibrarianTableAdapter.Update(libraryDataSet.User_Librarian);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
