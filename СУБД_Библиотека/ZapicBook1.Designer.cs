namespace СУБД_Библиотека
{
    partial class ZapicBook1
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
            System.Windows.Forms.Label idstudLabel;
            System.Windows.Forms.Label idbiblioLabel;
            System.Windows.Forms.Label idbookLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label famLabel2;
            System.Windows.Forms.Label otchLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapicBook1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.libraryDataSet = new СУБД_Библиотека.libraryDataSet();
            this.vidachaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidachaTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.VidachaTableAdapter();
            this.tableAdapterManager = new СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvnie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozvrat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStud = new System.Windows.Forms.TextBox();
            this.tbxBiblio = new System.Windows.Forms.TextBox();
            this.dtVidacha = new System.Windows.Forms.DateTimePicker();
            this.dtVozvrat = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.user_StudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_StudTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_StudTableAdapter();
            this.user_LibrarianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_LibrarianTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_LibrarianTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.BookTableAdapter();
            this.idstudLabel1 = new System.Windows.Forms.Label();
            this.idbiblioLabel1 = new System.Windows.Forms.Label();
            this.idbookLabel1 = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.famLabel3 = new System.Windows.Forms.Label();
            this.otchLabel3 = new System.Windows.Forms.Label();
            this.tbxfind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            idstudLabel = new System.Windows.Forms.Label();
            idbiblioLabel = new System.Windows.Forms.Label();
            idbookLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            famLabel2 = new System.Windows.Forms.Label();
            otchLabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_StudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_LibrarianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idstudLabel
            // 
            idstudLabel.AutoSize = true;
            idstudLabel.Location = new System.Drawing.Point(787, 100);
            idstudLabel.Name = "idstudLabel";
            idstudLabel.Size = new System.Drawing.Size(38, 13);
            idstudLabel.TabIndex = 22;
            idstudLabel.Text = "idstud:";
            // 
            // idbiblioLabel
            // 
            idbiblioLabel.AutoSize = true;
            idbiblioLabel.Location = new System.Drawing.Point(783, 123);
            idbiblioLabel.Name = "idbiblioLabel";
            idbiblioLabel.Size = new System.Drawing.Size(42, 13);
            idbiblioLabel.TabIndex = 23;
            idbiblioLabel.Text = "idbiblio:";
            // 
            // idbookLabel
            // 
            idbookLabel.AutoSize = true;
            idbookLabel.Location = new System.Drawing.Point(783, 146);
            idbookLabel.Name = "idbookLabel";
            idbookLabel.Size = new System.Drawing.Size(42, 13);
            idbookLabel.TabIndex = 24;
            idbookLabel.Text = "idbook:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(795, 190);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(30, 13);
            famLabel.TabIndex = 29;
            famLabel.Text = "Fam:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(795, 218);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 30;
            nameLabel.Text = "Name:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(792, 241);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(33, 13);
            otchLabel.TabIndex = 31;
            otchLabel.Text = "Otch:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(804, 293);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(38, 13);
            nameLabel2.TabIndex = 32;
            nameLabel2.Text = "Name:";
            // 
            // famLabel2
            // 
            famLabel2.AutoSize = true;
            famLabel2.Location = new System.Drawing.Point(812, 323);
            famLabel2.Name = "famLabel2";
            famLabel2.Size = new System.Drawing.Size(30, 13);
            famLabel2.TabIndex = 34;
            famLabel2.Text = "Fam:";
            // 
            // otchLabel2
            // 
            otchLabel2.AutoSize = true;
            otchLabel2.Location = new System.Drawing.Point(809, 346);
            otchLabel2.Name = "otchLabel2";
            otchLabel2.Size = new System.Drawing.Size(33, 13);
            otchLabel2.TabIndex = 36;
            otchLabel2.Text = "Otch:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 96);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выдача и возврат книг";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.izdatelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_LibrarianTableAdapter = null;
            this.tableAdapterManager.User_StudTableAdapter = null;
            this.tableAdapterManager.VidachaTableAdapter = this.vidachaTableAdapter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbook,
            this.nazvnie,
            this.Fam1,
            this.Fam,
            this.Data,
            this.Date1,
            this.vozvrat});
            this.dataGridView1.Location = new System.Drawing.Point(3, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // idbook
            // 
            this.idbook.HeaderText = "Column1";
            this.idbook.Name = "idbook";
            this.idbook.ReadOnly = true;
            this.idbook.Visible = false;
            // 
            // nazvnie
            // 
            this.nazvnie.HeaderText = "Название";
            this.nazvnie.Name = "nazvnie";
            this.nazvnie.ReadOnly = true;
            // 
            // Fam1
            // 
            this.Fam1.HeaderText = "Студент";
            this.Fam1.Name = "Fam1";
            this.Fam1.ReadOnly = true;
            // 
            // Fam
            // 
            this.Fam.HeaderText = "Библиотекарь";
            this.Fam.Name = "Fam";
            this.Fam.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дата выдачи";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Дата сдачи";
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            // 
            // vozvrat
            // 
            this.vozvrat.HeaderText = "Возврат";
            this.vozvrat.Name = "vozvrat";
            this.vozvrat.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEdit.Location = new System.Drawing.Point(365, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(175, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Отредактировать запись";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDel.Location = new System.Drawing.Point(546, 256);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Удалить выделенную запись";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(46, 330);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 11;
            this.tbxName.Visible = false;
            // 
            // tbxStud
            // 
            this.tbxStud.Location = new System.Drawing.Point(152, 330);
            this.tbxStud.Name = "tbxStud";
            this.tbxStud.Size = new System.Drawing.Size(100, 20);
            this.tbxStud.TabIndex = 12;
            this.tbxStud.Visible = false;
            // 
            // tbxBiblio
            // 
            this.tbxBiblio.Location = new System.Drawing.Point(258, 330);
            this.tbxBiblio.Name = "tbxBiblio";
            this.tbxBiblio.Size = new System.Drawing.Size(100, 20);
            this.tbxBiblio.TabIndex = 13;
            this.tbxBiblio.Visible = false;
            // 
            // dtVidacha
            // 
            this.dtVidacha.Enabled = false;
            this.dtVidacha.Location = new System.Drawing.Point(365, 329);
            this.dtVidacha.Name = "dtVidacha";
            this.dtVidacha.Size = new System.Drawing.Size(119, 20);
            this.dtVidacha.TabIndex = 14;
            this.dtVidacha.Visible = false;
            // 
            // dtVozvrat
            // 
            this.dtVozvrat.Enabled = false;
            this.dtVozvrat.Location = new System.Drawing.Point(488, 330);
            this.dtVozvrat.Name = "dtVozvrat";
            this.dtVozvrat.Size = new System.Drawing.Size(119, 20);
            this.dtVozvrat.TabIndex = 15;
            this.dtVozvrat.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(643, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Возврат";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(25)))));
            this.btnSaveEdit.Location = new System.Drawing.Point(488, 386);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(100, 23);
            this.btnSaveEdit.TabIndex = 17;
            this.btnSaveEdit.Text = "Сохранить";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Visible = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Студент";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Библиотекарь";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Выдана";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Сдача";
            this.label6.Visible = false;
            // 
            // user_StudBindingSource
            // 
            this.user_StudBindingSource.DataMember = "User_Stud";
            this.user_StudBindingSource.DataSource = this.libraryDataSet;
            // 
            // user_StudTableAdapter
            // 
            this.user_StudTableAdapter.ClearBeforeFill = true;
            // 
            // user_LibrarianBindingSource
            // 
            this.user_LibrarianBindingSource.DataMember = "User_Librarian";
            this.user_LibrarianBindingSource.DataSource = this.libraryDataSet;
            // 
            // user_LibrarianTableAdapter
            // 
            this.user_LibrarianTableAdapter.ClearBeforeFill = true;
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
            // idstudLabel1
            // 
            this.idstudLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_StudBindingSource, "idstud", true));
            this.idstudLabel1.Location = new System.Drawing.Point(831, 100);
            this.idstudLabel1.Name = "idstudLabel1";
            this.idstudLabel1.Size = new System.Drawing.Size(100, 23);
            this.idstudLabel1.TabIndex = 23;
            this.idstudLabel1.Text = "label7";
            // 
            // idbiblioLabel1
            // 
            this.idbiblioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "idbiblio", true));
            this.idbiblioLabel1.Location = new System.Drawing.Point(831, 123);
            this.idbiblioLabel1.Name = "idbiblioLabel1";
            this.idbiblioLabel1.Size = new System.Drawing.Size(100, 23);
            this.idbiblioLabel1.TabIndex = 24;
            this.idbiblioLabel1.Text = "label7";
            // 
            // idbookLabel1
            // 
            this.idbookLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "idbook", true));
            this.idbookLabel1.Location = new System.Drawing.Point(831, 146);
            this.idbookLabel1.Name = "idbookLabel1";
            this.idbookLabel1.Size = new System.Drawing.Size(100, 23);
            this.idbookLabel1.TabIndex = 25;
            this.idbookLabel1.Text = "label7";
            // 
            // btnAddDate
            // 
            this.btnAddDate.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddDate.Location = new System.Drawing.Point(591, 386);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(119, 23);
            this.btnAddDate.TabIndex = 26;
            this.btnAddDate.Text = "Продлить";
            this.btnAddDate.UseVisualStyleBackColor = false;
            this.btnAddDate.Visible = false;
            this.btnAddDate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAdd.Location = new System.Drawing.Point(184, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Добавить новую запись";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddNew.Location = new System.Drawing.Point(488, 386);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 23);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "Сохранить";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(3, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Экспорт в Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(831, 190);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 30;
            this.famLabel1.Text = "label7";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(839, 218);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 31;
            this.nameLabel1.Text = "label7";
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(831, 241);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 32;
            this.otchLabel1.Text = "label7";
            // 
            // nameLabel3
            // 
            this.nameLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_StudBindingSource, "Name", true));
            this.nameLabel3.Location = new System.Drawing.Point(848, 293);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(100, 23);
            this.nameLabel3.TabIndex = 33;
            this.nameLabel3.Text = "label7";
            // 
            // famLabel3
            // 
            this.famLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_StudBindingSource, "Fam", true));
            this.famLabel3.Location = new System.Drawing.Point(848, 323);
            this.famLabel3.Name = "famLabel3";
            this.famLabel3.Size = new System.Drawing.Size(100, 23);
            this.famLabel3.TabIndex = 35;
            this.famLabel3.Text = "label7";
            // 
            // otchLabel3
            // 
            this.otchLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_StudBindingSource, "Otch", true));
            this.otchLabel3.Location = new System.Drawing.Point(848, 346);
            this.otchLabel3.Name = "otchLabel3";
            this.otchLabel3.Size = new System.Drawing.Size(100, 23);
            this.otchLabel3.TabIndex = 37;
            this.otchLabel3.Text = "label7";
            // 
            // tbxfind
            // 
            this.tbxfind.Location = new System.Drawing.Point(46, 387);
            this.tbxfind.Name = "tbxfind";
            this.tbxfind.Size = new System.Drawing.Size(100, 20);
            this.tbxfind.TabIndex = 38;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFind.Location = new System.Drawing.Point(152, 386);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(78, 21);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ZapicBook1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 418);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxfind);
            this.Controls.Add(otchLabel2);
            this.Controls.Add(this.otchLabel3);
            this.Controls.Add(famLabel2);
            this.Controls.Add(this.famLabel3);
            this.Controls.Add(nameLabel2);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.otchLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(idbookLabel);
            this.Controls.Add(this.idbookLabel1);
            this.Controls.Add(idbiblioLabel);
            this.Controls.Add(this.idbiblioLabel1);
            this.Controls.Add(idstudLabel);
            this.Controls.Add(this.idstudLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dtVozvrat);
            this.Controls.Add(this.dtVidacha);
            this.Controls.Add(this.tbxBiblio);
            this.Controls.Add(this.tbxStud);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZapicBook1";
            this.Text = "СУБД_Библиотека";
            this.Load += new System.EventHandler(this.ZapicBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_StudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_LibrarianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource vidachaBindingSource;
        private libraryDataSetTableAdapters.VidachaTableAdapter vidachaTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStud;
        private System.Windows.Forms.TextBox tbxBiblio;
        private System.Windows.Forms.DateTimePicker dtVidacha;
        private System.Windows.Forms.DateTimePicker dtVozvrat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource user_StudBindingSource;
        private libraryDataSetTableAdapters.User_StudTableAdapter user_StudTableAdapter;
        private System.Windows.Forms.BindingSource user_LibrarianBindingSource;
        private libraryDataSetTableAdapters.User_LibrarianTableAdapter user_LibrarianTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private libraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvnie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vozvrat;
        private System.Windows.Forms.Label idstudLabel1;
        private System.Windows.Forms.Label idbiblioLabel1;
        private System.Windows.Forms.Label idbookLabel1;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label famLabel3;
        private System.Windows.Forms.Label otchLabel3;
        private System.Windows.Forms.TextBox tbxfind;
        private System.Windows.Forms.Button btnFind;
    }
}