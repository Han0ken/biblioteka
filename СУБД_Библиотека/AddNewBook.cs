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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.izdatel' table. You can move, or remove it, as needed.
            this.izdatelTableAdapter.Fill(this.libraryDataSet.izdatel);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            bookBindingSource.AddNew();
            comboBox1.Items.Clear();
            izdatelBindingSource.MoveFirst();
            for (int i = 0; i < izdatelBindingSource.Count; i++)
            {
                string s = ((DataRowView)izdatelBindingSource.Current)["Name"].ToString();
                comboBox1.Items.Add(s);
                izdatelBindingSource.MoveNext();
            }
            comboBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text==""||yearTextBox.Text==""||authorTextBox.Text==""||listTextBox.Text==""||comboBox1.Text=="")
            {
                MessageBox.Show("Вы незаполнили все поля!");
                return;
            }
            comboBox1.Text = comboBox1.Text.Trim();
            DataRowView dr = (DataRowView)bookBindingSource.Current;
            string sIzdatel = comboBox1.Text;
            if (izdatelBindingSource.Find("Name", sIzdatel) == -1)
            {
                if (fotoBookPictureBox.Image == null)
                {
                    fotoBookPictureBox.Image = Properties.Resources.tmp;
                }
                izdatelBindingSource.AddNew();
                DataRowView dgvIzd = (DataRowView)izdatelBindingSource.Current;
                dgvIzd["Name"] = sIzdatel;
                izdatelBindingSource.EndEdit();
                izdatelTableAdapter.Update(libraryDataSet.izdatel);
                izdatelTableAdapter.Fill(libraryDataSet.izdatel);
            }
            izdatelBindingSource.Position = izdatelBindingSource.Find("Name", sIzdatel);
            int ID = Convert.ToInt32(((DataRowView)izdatelBindingSource.Current)["idizdatel"]);
            dr["izdatel"] = ID;
            bookBindingSource.EndEdit();
            bookTableAdapter.Update(libraryDataSet.Book);
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoBookPictureBox.Load(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoBookPictureBox.Image= null;
        }
    }
}
