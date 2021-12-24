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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            string role = comboBox1.SelectedItem.ToString();
            string txtFilter = string.Format("login='{0}' and pass='{1}'", tbLog.Text, tbxPass.Text);
            string txtstud = string.Format("login='{0}' and pass='{1}'and admin='0'", tbLog.Text, tbxPass.Text);
            string txtadmin = string.Format("login='{0}' and pass='{1}' and admin='1'", tbLog.Text, tbxPass.Text);
            string txtFilterUser = string.Format("login='{0}'", tbLog.Text);            
            if (role=="Библиотекарь")
            {
                bsBiblio.Filter = txtFilter;
                if (bsBiblio.Count != 0)
                {
                    Biblio frm = new Biblio();
                    frm.bsBiblio.Filter = txtFilterUser;
                    frm.ShowDialog();
                    this.Visible = true;
                    tbLog.Clear();
                    tbxPass.Clear();
                    tbLog.Focus();
                }
                else
                {
                    MessageBox.Show("Нет пользователя с указанным логином и паролем.", "Внимание!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (role == "Студент")
            {
                bsStud.Filter = txtstud;               
                if (bsStud.Count != 0)
                {
                    Stud frm = new Stud();
                    frm.bsStud.Filter = txtFilterUser;
                    frm.ShowDialog();
                    this.Visible = true;
                    tbLog.Clear();
                    tbxPass.Clear();
                    tbLog.Focus();
                }
                else
                {
                    MessageBox.Show("Нет пользователя с указанным логином и паролем.", "Внимание!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (role == "Администратор")
            {
                bsStud.Filter = txtadmin;
                if (bsStud.Count != 0)
                {
                    FormAdmin frm = new FormAdmin();
                    frm.bsStud.Filter = txtFilterUser;
                    frm.ShowDialog();
                    this.Visible = true;
                    tbLog.Clear();
                    tbxPass.Clear();
                    tbLog.Focus();
                }
                else
                {
                    MessageBox.Show("Нет пользователя с указанным логином и паролем.", "Внимание!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void user_StudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsStud.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            comboBox1.SelectedIndex = 0;
        }
        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            RegNewUser frm = new RegNewUser();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string s = Application.StartupPath;
            System.Diagnostics.Process.Start(s + "\\help.chm");
        }
    }
}
