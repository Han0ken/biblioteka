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
    public partial class RegNewUser : Form
    {
        public RegNewUser()
        {
            InitializeComponent();
        }

        private void RegNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            user_StudBindingSource.AddNew();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text==""||famTextBox.Text==""||kursTextBox.Text==""||loginTextBox.Text==""||passTextBox.Text=="")
            {
                MessageBox.Show("Заполните все строки!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                specTextBox.Text = "Физическая культура";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                specTextBox.Text = "Преподавание в начальных классах";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                specTextBox.Text = "Программирование в компьютерных системах";
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
        }
    }
}
