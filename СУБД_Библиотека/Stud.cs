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

namespace СУБД_Библиотека
{
    public partial class Stud : Form
    {
        public Stud()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.libraryConnectionString);
        private void user_StudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsStud.EndEdit();
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
join User_Stud on User_Stud.idstud = Vidacha.idstud
Where User_Stud.idstud='{0}'",idstudLabel1.Text), con);
            SqlDataReader dr = qury.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["idvidachi"], dr["Name"], dr["studfam"],
                    dr["Fam"], dr["datevidachi"], dr["datavozvrata"], dr["vozvrat"]);
            }
            con.Close();
        }

        private void Stud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Vidacha' table. You can move, or remove it, as needed.
            this.vidachaTableAdapter.Fill(libraryDataSet.Vidacha);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            string txtFilterUser = string.Format("idstud='{0}'", idstudLabel1.Text);
            vidachaBindingSource.Filter = txtFilterUser;
            FillVidanyhBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditStud frm = new EditStud();
            frm.bsStud.Filter = bsStud.Filter;
            frm.ShowDialog();
        }
    }
}
