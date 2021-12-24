using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passw;

namespace СУБД_Библиотека
{
    public partial class EditBiblio : Form
    {
        public EditBiblio()
        {
            InitializeComponent();
        }

        private void user_LibrarianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BsLib.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void EditBiblio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
            passTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != passLabel2.Text)
            {
                MessageBox.Show("Вы ввели неверный текущий пароль!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (!Passw.Password.Check(passTextBox.Text))
            {
                MessageBox.Show("Пароль не соответсвует требованиям безопастности.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;

            }
            passLabel2.Text = passTextBox.Text;
            BsLib.EndEdit();
            this.user_LibrarianTableAdapter.Update(libraryDataSet.User_Librarian);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = !checkBox1.Checked;
            textBox1.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
