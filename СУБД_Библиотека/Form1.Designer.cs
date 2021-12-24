namespace СУБД_Библиотека
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.cbxShowPass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.libraryDataSet = new СУБД_Библиотека.libraryDataSet();
            this.bsStud = new System.Windows.Forms.BindingSource(this.components);
            this.user_StudTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_StudTableAdapter();
            this.tableAdapterManager = new СУБД_Библиотека.libraryDataSetTableAdapters.TableAdapterManager();
            this.user_LibrarianTableAdapter = new СУБД_Библиотека.libraryDataSetTableAdapters.User_LibrarianTableAdapter();
            this.bsBiblio = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBiblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 96);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLog.Location = new System.Drawing.Point(90, 232);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(136, 23);
            this.btnLog.TabIndex = 13;
            this.btnLog.Text = "Войти";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // cbxShowPass
            // 
            this.cbxShowPass.AutoSize = true;
            this.cbxShowPass.Location = new System.Drawing.Point(95, 209);
            this.cbxShowPass.Name = "cbxShowPass";
            this.cbxShowPass.Size = new System.Drawing.Size(114, 17);
            this.cbxShowPass.TabIndex = 12;
            this.cbxShowPass.Text = "Показать пароль";
            this.cbxShowPass.UseVisualStyleBackColor = true;
            this.cbxShowPass.CheckedChanged += new System.EventHandler(this.cbxShowPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Логин";
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(90, 183);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(136, 20);
            this.tbxPass.TabIndex = 9;
            this.tbxPass.UseSystemPasswordChar = true;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(90, 157);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(136, 20);
            this.tbLog.TabIndex = 8;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReg.ForeColor = System.Drawing.Color.Blue;
            this.lblReg.Location = new System.Drawing.Point(130, 324);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(168, 15);
            this.lblReg.TabIndex = 14;
            this.lblReg.Text = "Регистрация пользователя";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Библиотекарь",
            "Студент",
            "Администратор"});
            this.comboBox1.Location = new System.Drawing.Point(90, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 15;
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
            this.tableAdapterManager.User_LibrarianTableAdapter = this.user_LibrarianTableAdapter;
            this.tableAdapterManager.User_StudTableAdapter = this.user_StudTableAdapter;
            this.tableAdapterManager.VidachaTableAdapter = null;
            // 
            // user_LibrarianTableAdapter
            // 
            this.user_LibrarianTableAdapter.ClearBeforeFill = true;
            // 
            // bsBiblio
            // 
            this.bsBiblio.DataMember = "User_Librarian";
            this.bsBiblio.DataSource = this.libraryDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Документация";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::СУБД_Библиотека.Properties.Resources.artage_io_thumb_5cf64ac82c0c13fe958399b126fba9261;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxShowPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД_Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBiblio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckBox cbxShowPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label lblReg;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bsStud;
        private libraryDataSetTableAdapters.User_StudTableAdapter user_StudTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private libraryDataSetTableAdapters.User_LibrarianTableAdapter user_LibrarianTableAdapter;
        private System.Windows.Forms.BindingSource bsBiblio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

