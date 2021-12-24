namespace СУБД_Библиотека
{
    partial class Stud
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
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idstudLabel;
            this.libraryDataSet = new СУБД_Библиотека.libraryDataSet();
            this.bsStud = new System.Windows.Forms.BindingSource(this.components);
            this.user_StudTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_StudTableAdapter();
            this.tableAdapterManager = new СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager();
            this.otchLabel1 = new System.Windows.Forms.Label();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vidachaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidachaTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.VidachaTableAdapter();
            this.idstudLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            otchLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idstudLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(14, 145);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(33, 13);
            otchLabel.TabIndex = 1;
            otchLabel.Text = "Otch:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(17, 122);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(30, 13);
            famLabel.TabIndex = 3;
            famLabel.Text = "Fam:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 99);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // idstudLabel
            // 
            idstudLabel.AutoSize = true;
            idstudLabel.Location = new System.Drawing.Point(695, 119);
            idstudLabel.Name = "idstudLabel";
            idstudLabel.Size = new System.Drawing.Size(38, 13);
            idstudLabel.TabIndex = 8;
            idstudLabel.Text = "idstud:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsStud
            // 
            this.bsStud.DataMember = "User_Stud";
            this.bsStud.DataSource = this.libraryDataSet;
            // 
            // user_StudTableAdapter
            // 
            this.user_StudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.izdatelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_LibrarianTableAdapter = null;
            this.tableAdapterManager.User_StudTableAdapter = this.user_StudTableAdapter;
            this.tableAdapterManager.VidachaTableAdapter = null;
            // 
            // otchLabel1
            // 
            this.otchLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStud, "Otch", true));
            this.otchLabel1.Location = new System.Drawing.Point(53, 145);
            this.otchLabel1.Name = "otchLabel1";
            this.otchLabel1.Size = new System.Drawing.Size(100, 23);
            this.otchLabel1.TabIndex = 2;
            this.otchLabel1.Text = "label1";
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStud, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(53, 122);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 4;
            this.famLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStud, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(53, 99);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 6;
            this.nameLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 96);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочие место студента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::СУБД_Библиотека.Properties.Resources.png_clipart_computer_icons_book_discussion_club_author_binocular_angle_rectangle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vidachaBindingSource
            // 
            this.vidachaBindingSource.DataMember = "Vidacha";
            this.vidachaBindingSource.DataSource = this.libraryDataSet;
            this.vidachaBindingSource.Filter = "";
            // 
            // vidachaTableAdapter
            // 
            this.vidachaTableAdapter.ClearBeforeFill = true;
            // 
            // idstudLabel1
            // 
            this.idstudLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStud, "idstud", true));
            this.idstudLabel1.Location = new System.Drawing.Point(739, 119);
            this.idstudLabel1.Name = "idstudLabel1";
            this.idstudLabel1.Size = new System.Drawing.Size(100, 23);
            this.idstudLabel1.TabIndex = 9;
            this.idstudLabel1.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(453, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 220);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "idVidachi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stud";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Библиотекарь";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата Выдачи";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата сдачи";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Вовзрат";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idstudLabel);
            this.Controls.Add(this.idstudLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famLabel1);
            this.Controls.Add(otchLabel);
            this.Controls.Add(this.otchLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Библиотека";
            this.Load += new System.EventHandler(this.Stud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDataSet libraryDataSet;
        private libraryDataSetTableAdapters.User_StudTableAdapter user_StudTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label otchLabel1;
        private System.Windows.Forms.Label famLabel1;
        private System.Windows.Forms.Label nameLabel1;
        public System.Windows.Forms.BindingSource bsStud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private libraryDataSetTableAdapters.VidachaTableAdapter vidachaTableAdapter;
        public System.Windows.Forms.BindingSource vidachaBindingSource;
        private System.Windows.Forms.Label idstudLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}