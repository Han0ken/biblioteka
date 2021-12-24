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
    public partial class Biblio : Form
    {
        public Biblio()
        {
            InitializeComponent();
        }

        private void user_LibrarianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsBiblio.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Biblio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Vidacha' table. You can move, or remove it, as needed.
            this.vidachaTableAdapter.Fill(this.libraryDataSet.Vidacha);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Stud' table. You can move, or remove it, as needed.
            this.user_StudTableAdapter.Fill(this.libraryDataSet.User_Stud);
            // TODO: This line of code loads data into the 'libraryDataSet.User_Librarian' table. You can move, or remove it, as needed.
            this.user_LibrarianTableAdapter.Fill(this.libraryDataSet.User_Librarian);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditBiblio edt = new EditBiblio();
            edt.BsLib.Filter = bsBiblio.Filter;
            edt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewBook frm = new AddNewBook();
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
                this.bookTableAdapter.Fill(this.libraryDataSet.Book);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZapicBook1 frm = new ZapicBook1();
            this.vidachaTableAdapter.Fill(this.libraryDataSet.Vidacha);
            frm.ShowDialog();
        }
    }
}
