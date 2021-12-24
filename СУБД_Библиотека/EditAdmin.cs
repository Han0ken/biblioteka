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
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
        }

        private void user_StudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_StudBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            passTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != passLabel1.Text)
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
            user_StudBindingSource.EndEdit();
            this.user_StudTableAdapter.Update(libraryDataSet.User_Stud);
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
