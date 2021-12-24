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
    public partial class EditStud : Form
    {
        public EditStud()
        {
            InitializeComponent();
        }

        private void user_StudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsStud.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void EditStud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            passTextBox.Text = "";
            if(specTextBox.Text== "Физическая культура")
            {
                comboBox1.SelectedIndex = 0;
            }
            if(specTextBox.Text== "Преподавание в начальных классах")
            {
                comboBox1.SelectedIndex = 1;
            }
            if (specTextBox.Text == "Программирование в компьютерных системах")
            {
                comboBox1.SelectedIndex = 2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                specTextBox.Text = "Физическая культура";
            }
            if(comboBox1.SelectedIndex == 1)
            {
                specTextBox.Text = "Преподавание в начальных классах";
            }
            if(comboBox1.SelectedIndex == 2)
            {
                specTextBox.Text = "Программирование в компьютерных системах";
            }      
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
            bsStud.EndEdit();
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
