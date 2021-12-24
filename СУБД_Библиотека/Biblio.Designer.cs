namespace СУБД_Библиотека
{
    partial class Biblio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblio));
            this.libraryDataSet = new СУБД_Библиотека.libraryDataSet();
            this.bsBiblio = new System.Windows.Forms.BindingSource(this.components);
            this.user_LibrarianTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_LibrarianTableAdapter();
            this.tableAdapterManager = new СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager();
            this.user_StudTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_StudTableAdapter();
            this.bsStud = new System.Windows.Forms.BindingSource(this.components);
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.BookTableAdapter();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.vidachaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidachaTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.VidachaTableAdapter();
            this.fotoBookPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            famLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBiblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(12, 99);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(30, 13);
            famLabel.TabIndex = 4;
            famLabel.Text = "Fam:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(9, 145);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(33, 13);
            otchLabel.TabIndex = 0;
            otchLabel.Text = "Otch:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(4, 122);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsBiblio
            // 
            this.bsBiblio.DataMember = "User_Librarian";
            this.bsBiblio.DataSource = this.libraryDataSet;
            // 
            // user_LibrarianTableAdapter
            // 
            this.user_LibrarianTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.izdatelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_LibrarianTableAdapter = this.user_LibrarianTableAdapter;
            this.tableAdapterManager.User_StudTableAdapter = this.user_StudTableAdapter;
            this.tableAdapterManager.VidachaTableAdapter = null;
            // 
            // user_StudTableAdapter
            // 
            this.user_StudTableAdapter.ClearBeforeFill = true;
            // 
            // bsStud
            // 
            this.bsStud.DataMember = "User_Stud";
            this.bsStud.DataSource = this.libraryDataSet;
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBiblio, "Otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(48, 145);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 1;
            this.otchLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBiblio, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(48, 122);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "label1";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBiblio, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(48, 99);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 5;
            this.famLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 96);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочие место библиотекаря";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(310, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Location = new System.Drawing.Point(310, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Внести книгу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 189);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDataGridView.Size = new System.Drawing.Size(549, 192);
            this.bookDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Izdatel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Издатель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn4.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Год";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "List";
            this.dataGridViewTextBoxColumn6.HeaderText = "Кол-во листов";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aquamarine;
            this.button3.Location = new System.Drawing.Point(310, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Просмотр записей";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vidachaBindingSource
            // 
            this.vidachaBindingSource.DataMember = "Vidacha";
            this.vidachaBindingSource.DataSource = this.libraryDataSet;
            // 
            // vidachaTableAdapter
            // 
            this.vidachaTableAdapter.ClearBeforeFill = true;
            // 
            // fotoBookPictureBox
            // 
            this.fotoBookPictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fotoBookPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bookBindingSource, "FotoBook", true));
            this.fotoBookPictureBox.Location = new System.Drawing.Point(440, 99);
            this.fotoBookPictureBox.Name = "fotoBookPictureBox";
            this.fotoBookPictureBox.Size = new System.Drawing.Size(109, 84);
            this.fotoBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoBookPictureBox.TabIndex = 11;
            this.fotoBookPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Biblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 401);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fotoBookPictureBox);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.otchLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biblio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД_Библиотека";
            this.Load += new System.EventHandler(this.Biblio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBiblio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDataSet libraryDataSet;
        private libraryDataSetTableAdapters.User_LibrarianTableAdapter user_LibrarianTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private libraryDataSetTableAdapters.User_StudTableAdapter user_StudTableAdapter;
        public System.Windows.Forms.BindingSource bsBiblio;
        public System.Windows.Forms.BindingSource bsStud;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private libraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox fotoBookPictureBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource vidachaBindingSource;
        private libraryDataSetTableAdapters.VidachaTableAdapter vidachaTableAdapter;
    }
}