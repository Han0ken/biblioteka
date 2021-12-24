namespace СУБД_Библиотека
{
    partial class FormRegBiblio
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
            System.Windows.Forms.Label bdayLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.libraryDataSet = new СУБД_Библиотека.libraryDataSet();
            this.user_LibrarianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_LibrarianTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_LibrarianTableAdapter();
            this.tableAdapterManager = new СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.otchTextBox = new System.Windows.Forms.TextBox();
            this.bdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLog = new System.Windows.Forms.Button();
            bdayLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_LibrarianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdayLabel
            // 
            bdayLabel.AutoSize = true;
            bdayLabel.Location = new System.Drawing.Point(25, 196);
            bdayLabel.Name = "bdayLabel";
            bdayLabel.Size = new System.Drawing.Size(89, 13);
            bdayLabel.TabIndex = 7;
            bdayLabel.Text = "Дата рождения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(66, 274);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 41;
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(73, 251);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 40;
            label4.Text = "Логин:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(59, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 13);
            label6.TabIndex = 38;
            label6.Text = "Телефон:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(57, 173);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(57, 13);
            label8.TabIndex = 36;
            label8.Text = "Отчество:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(55, 147);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 13);
            label9.TabIndex = 35;
            label9.Text = "Фамилия:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(82, 121);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(32, 13);
            label10.TabIndex = 34;
            label10.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 96);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администратор";
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
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.izdatelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_LibrarianTableAdapter = this.user_LibrarianTableAdapter;
            this.tableAdapterManager.User_StudTableAdapter = null;
            this.tableAdapterManager.VidachaTableAdapter = null;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Fam", true));
            this.famTextBox.Location = new System.Drawing.Point(120, 118);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(123, 20);
            this.famTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(120, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // otchTextBox
            // 
            this.otchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "Otch", true));
            this.otchTextBox.Location = new System.Drawing.Point(120, 170);
            this.otchTextBox.Name = "otchTextBox";
            this.otchTextBox.Size = new System.Drawing.Size(123, 20);
            this.otchTextBox.TabIndex = 7;
            // 
            // bdayDateTimePicker
            // 
            this.bdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.user_LibrarianBindingSource, "Bday", true));
            this.bdayDateTimePicker.Location = new System.Drawing.Point(120, 196);
            this.bdayDateTimePicker.Name = "bdayDateTimePicker";
            this.bdayDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.bdayDateTimePicker.TabIndex = 8;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(120, 248);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(123, 20);
            this.loginTextBox.TabIndex = 10;
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_LibrarianBindingSource, "pass", true));
            this.passTextBox.Location = new System.Drawing.Point(120, 274);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(123, 20);
            this.passTextBox.TabIndex = 12;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 222);
            this.maskedTextBox1.Mask = "+0(000)-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBox1.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(118, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLog.Location = new System.Drawing.Point(99, 324);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(144, 23);
            this.btnLog.TabIndex = 43;
            this.btnLog.Text = "Зарегистрироваться";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // FormRegBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label6);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(bdayLabel);
            this.Controls.Add(this.bdayDateTimePicker);
            this.Controls.Add(this.otchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegBiblio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД_Библиотека";
            this.Load += new System.EventHandler(this.FormRegBiblio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_LibrarianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource user_LibrarianBindingSource;
        private libraryDataSetTableAdapters.User_LibrarianTableAdapter user_LibrarianTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox otchTextBox;
        private System.Windows.Forms.DateTimePicker bdayDateTimePicker;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLog;
    }
}