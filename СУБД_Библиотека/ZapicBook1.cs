using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace СУБД_Библиотека
{
    public partial class ZapicBook1 : Form
    {
        public ZapicBook1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.libraryConnectionString);

        private void ZapicBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            // TODO: This line of code loads data into the 'libraryDataSet.Vidacha' table. You can move, or remove it, as needed.
            this.vidachaTableAdapter.Fill(this.libraryDataSet.Vidacha);
            FillVidanyhBook();
        }

        private void vidachaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vidachaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void vidachaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vidachaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }     
        void FillVidanyhBook()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            SqlCommand qury = new SqlCommand(String.Format(@"Select Vidacha.idvidachi, 
Book.Name,User_Librarian.Fam, User_Stud.Fam as 'studfam',datevidachi, datavozvrata,Vidacha.vozvrat
From Book join Vidacha on Book.idbook = Vidacha.idbook
join User_Librarian on Vidacha.idbiblio = User_Librarian.idbiblio
join User_Stud on User_Stud.idstud = Vidacha.idstud"), con);
            SqlDataReader dr = qury.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["idvidachi"],dr["Name"], dr["studfam"], 
                    dr["Fam"], dr["datevidachi"], dr["datavozvrata"],dr["vozvrat"]);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Удалить документ?",
               "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drv in dataGridView1.SelectedRows)
                {
                        int idvidch = int.Parse(drv.Cells[0].Value.ToString());
                        dataGridView1.Rows.Remove(drv);
                        con.Open();
                        SqlCommand qurem = new SqlCommand(String.Format(@"Delete from Vidacha 
Where idvidachi='{0}'", idvidch), con);
                        SqlDataReader res = qurem.ExecuteReader();
                        res.Read();
                        con.Close();
                    }
                    this.vidachaTableAdapter.Update(this.libraryDataSet.Vidacha);
                }
            
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            tbxfind.Visible = false;
            btnFind.Visible = false;
            tbxName.Visible = true;
            tbxStud.Visible = true;
            tbxBiblio.Visible = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSaveEdit.Visible = true;
            dataGridView1.Enabled = false;
            dtVidacha.Visible = true;
            dtVozvrat.Visible = true;
            checkBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnAddDate.Enabled = true;
            btnAddDate.Visible = true;
            btnAdd.Enabled = false;
            foreach (DataGridViewRow drv in dataGridView1.SelectedRows)
            {
                tbxName.Text = drv.Cells[1].Value.ToString();
                tbxStud.Text= drv.Cells[2].Value.ToString();
                tbxBiblio.Text= drv.Cells[3].Value.ToString();
                dtVidacha.Value = DateTime.Parse(drv.Cells[4].Value.ToString());
                dtVozvrat.Value= DateTime.Parse(drv.Cells[5].Value.ToString());
                checkBox1.Checked = bool.Parse(drv.Cells[6].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы хотетите добавить эту запись?", "Внимание!",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int famlib = user_LibrarianBindingSource.Find("fam", tbxBiblio.Text);
                int famstud = user_StudBindingSource.Find("Fam", tbxStud.Text);
                int nameBook = bookBindingSource.Find("Name", tbxName.Text);
                if (nameBook == -1)
                {
                    MessageBox.Show("Такой книги нету.");
                    return;
                }
                if (famlib == -1)
                {
                    MessageBox.Show("Такова библиотекаря нету.");
                    return;
                }
                if (famstud == -1)
                {
                    MessageBox.Show("Такова студента нету.");
                    return;
                }                
                else
                {
                    user_LibrarianBindingSource.Position = famlib;
                    user_StudBindingSource.Position = famstud;
                    bookBindingSource.Position = nameBook;
                    con.Open();
                    SqlCommand query1 = new SqlCommand(String.Format(@"Insert into Vidacha(idbook,idbiblio,idstud,datevidachi,datavozvrata,vozvrat)
values ('{0}','{1}','{2}','{3}','{4}','{5}')", idbookLabel1.Text, idbiblioLabel1.Text, idstudLabel1.Text,
dtVidacha.Value.ToString("yyyy/MM/dd"), dtVozvrat.Value.ToString("yyyy/MM/dd"), checkBox1.Checked), con);
                    query1.ExecuteNonQuery();
                    con.Close();
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    dtVidacha.Visible = false;
                    dtVozvrat.Visible = false;
                    checkBox1.Visible = false;
                    tbxfind.Visible = true;
                    btnFind.Visible = true;
                    tbxName.Visible = false;
                    tbxStud.Visible = false;
                    tbxBiblio.Visible = false;
                    btnEdit.Enabled = true;
                    btnAddNew.Visible = false;
                    btnDel.Enabled = true;
                    btnAdd.Enabled = true;
                    dataGridView1.Enabled = true;
                    btnAddDate.Visible = false;
                    dataGridView1.Focus();
                    this.vidachaTableAdapter.Fill(this.libraryDataSet.Vidacha);
                    FillVidanyhBook();
                }
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                dtVidacha.Visible = false;
                tbxfind.Visible = true;
                btnFind.Visible = true;
                dtVozvrat.Visible = false;
                checkBox1.Visible = false;
                tbxName.Visible = false;
                tbxStud.Visible = false;
                tbxBiblio.Visible = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnAddNew.Visible = false;
                btnAddDate.Visible = false;
                btnAdd.Enabled = true;
                dataGridView1.Enabled = true;
                dataGridView1.Focus();
            }  
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime olddate = dtVozvrat.Value;
            DateTime newdate=olddate.AddDays(12);
            dtVozvrat.Value = newdate;
            btnAddDate.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbxName.Clear();
            tbxBiblio.Clear();
            tbxStud.Clear();
            tbxfind.Visible = false;
            btnFind.Visible = false;
            tbxName.Visible = true;
            tbxStud.Visible = true;
            tbxBiblio.Visible = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnAddNew.Visible = true;
            dataGridView1.Enabled = false;
            dtVidacha.Visible = true;
            dtVozvrat.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnAdd.Enabled = false;
            DateTime nowdate = DateTime.Now;
            dtVidacha.Value = nowdate;
            dtVozvrat.Value = nowdate.AddDays(12);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы хотетите изменить запись?", "Внимание!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int famlib = user_LibrarianBindingSource.Find("fam", tbxBiblio.Text);
                int famstud = user_StudBindingSource.Find("Fam", tbxStud.Text);
                int nameBook = bookBindingSource.Find("Name", tbxName.Text);
                foreach (DataGridViewRow drv in dataGridView1.SelectedRows)
                {
                    int selectdrv = int.Parse(drv.Cells[0].Value.ToString());
                    if (famlib == -1)
                    {
                        MessageBox.Show("Такова библиотекаря нету.");
                        return;
                    }
                    if (famstud == -1)
                    {
                        MessageBox.Show("Такова студента нету.");
                        return;
                    }
                    if (nameBook == -1)
                    {
                        MessageBox.Show("Такой книги нету.");
                        return;
                    }
                    else
                    {
                        user_LibrarianBindingSource.Position = famlib;
                        user_StudBindingSource.Position = famstud;
                        bookBindingSource.Position = nameBook;
                        con.Open();
                        SqlCommand query1 = new SqlCommand(String.Format(@"Update Vidacha Set 
idbook='{0}',idbiblio='{1}',idstud='{2}',datevidachi='{3}',datavozvrata='{4}',vozvrat='{5}'
Where idvidachi='{6}'", idbookLabel1.Text, idbiblioLabel1.Text, idstudLabel1.Text,
dtVidacha.Value.ToString("yyyy/MM/dd"), dtVozvrat.Value.ToString("yyyy/MM/dd"), checkBox1.Checked, selectdrv), con);
                        query1.ExecuteNonQuery();
                        con.Close();
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        dtVidacha.Visible = false;
                        dtVozvrat.Visible = false;
                        checkBox1.Visible = false;
                        tbxName.Visible = false;
                        tbxStud.Visible = false;
                        tbxBiblio.Visible = false;
                        tbxfind.Visible = true;
                        btnFind.Visible = true;
                        btnEdit.Enabled = true;
                        btnSaveEdit.Visible = false;
                        btnDel.Enabled = true;                        
                        btnAdd.Enabled = true;
                        dataGridView1.Enabled = true;
                        btnAddDate.Visible = false;
                        dataGridView1.Focus();
                        this.vidachaTableAdapter.Fill(this.libraryDataSet.Vidacha);
                        FillVidanyhBook();
                    }
                }
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                tbxfind.Visible = true;
                btnFind.Visible = true;
                dtVidacha.Visible = false;
                dtVozvrat.Visible = false;
                checkBox1.Visible = false;
                tbxName.Visible = false;
                tbxStud.Visible = false;
                tbxBiblio.Visible = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                btnSaveEdit.Visible = false;
                dataGridView1.Enabled = true;
                btnAddDate.Visible = false;
                dataGridView1.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mecyas = "";
            int month = DateTime.Now.Month;
            if (month == 1)
            {
                mecyas = "января";
            }
            else if (month == 2)
            {
                mecyas = "февраля";
            }
            else if (month == 3)
            {
                mecyas = "марта";
            }
            else if (month == 4)
            {
                mecyas = "апреля";
            }
            else if (month == 5)
            {
                mecyas = "мая";
            }
            else if (month == 6)
            {
                mecyas = "июня";
            }
            else if (month == 7)
            {
                mecyas = "июля";
            }
            else if (month == 8)
            {
                mecyas = "августа";
            }
            else if (month == 9)
            {
                mecyas = "сентября";
            }
            else if (month == 10)
            {
                mecyas = "октября";
            }
            else if (month == 11)
            {
                mecyas = "ноября";
            }
            else if (month == 12)
            {
                mecyas = "декабря";
            }
            Excel.Application exapp = new Excel.Application();
            exapp.Visible = true;
            exapp.Workbooks.Open(Application.StartupPath + "\\Записи.xlsx", null, true);
            string fiostud = "";
            int famstud = 0;
            Excel.Worksheet list1 = exapp.Worksheets.get_Item(1);
            int RowExcel = 8;            
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                fiostud = dataGridView1.Rows[i].Cells[2].Value.ToString();
                famstud= user_StudBindingSource.Find("Fam",fiostud);
                user_StudBindingSource.Position = famstud;
                list1.get_Range("A" + RowExcel).Value =
                    dataGridView1.Rows[i].Cells[1].Value;

                string s =  "Не сдано";
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                    if(dataGridView1.Rows[i].Cells[6].Value.ToString() == "True")
                         s = "Сдано";

                list1.get_Range("D" + RowExcel).Value =famLabel3.Text+" "+nameLabel3.Text+" "+otchLabel3.Text;

                list1.get_Range("G" + RowExcel).Value = dataGridView1.Rows[i].Cells[4].Value;
                list1.get_Range("J" + RowExcel).Value = dataGridView1.Rows[i].Cells[5].Value;
                list1.get_Range("M" + RowExcel).Value = s;
                list1.get_Range("D" + 4).Value = DateTime.Now.Day + " " + mecyas + " " + DateTime.Now.Year + "г.";               
                list1.get_Range("D" + 2).Value = famLabel1.Text + " " + nameLabel1.Text + " " + otchLabel1.Text;
                RowExcel++;
                
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tbxfind.Text == "")
                return;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbxfind.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
