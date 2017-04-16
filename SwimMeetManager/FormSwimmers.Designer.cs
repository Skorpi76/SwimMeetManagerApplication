namespace SwimMeetManager
{
    partial class FormSwimmers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwimmers));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxDOB = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnSubmitAddSwimmer = new System.Windows.Forms.Button();
            this.lsbAllSwimmers = new System.Windows.Forms.ListBox();
            this.lblAboutStudent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaveSwimmers = new System.Windows.Forms.TextBox();
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.txtLoadSwimmers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gBoxDOB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 21);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(-1, 26);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 15);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(5, 145);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 15);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(5, 200);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(5, 227);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(58, 15);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(5, 254);
            this.lblPostalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(78, 15);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal Code: ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 279);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 15);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 23);
            this.txtName.TabIndex = 8;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(101, 26);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(88, 23);
            this.txtDay.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(108, 139);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(88, 23);
            this.txtStreet.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(107, 196);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(88, 23);
            this.txtCity.TabIndex = 11;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(107, 223);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(88, 23);
            this.txtProvince.TabIndex = 12;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(107, 251);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(88, 23);
            this.txtPostalCode.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(107, 279);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(88, 23);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gBoxDOB);
            this.groupBox1.Controls.Add(this.btnSubmitAddSwimmer);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.lblProvince);
            this.groupBox1.Controls.Add(this.lblPostalCode);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(240, 384);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add swimmer";
            // 
            // gBoxDOB
            // 
            this.gBoxDOB.Controls.Add(this.lblYear);
            this.gBoxDOB.Controls.Add(this.lblMonth);
            this.gBoxDOB.Controls.Add(this.txtYear);
            this.gBoxDOB.Controls.Add(this.lblDay);
            this.gBoxDOB.Controls.Add(this.txtMonth);
            this.gBoxDOB.Controls.Add(this.txtDay);
            this.gBoxDOB.Location = new System.Drawing.Point(8, 56);
            this.gBoxDOB.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxDOB.Name = "gBoxDOB";
            this.gBoxDOB.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxDOB.Size = new System.Drawing.Size(194, 119);
            this.gBoxDOB.TabIndex = 18;
            this.gBoxDOB.TabStop = false;
            this.gBoxDOB.Text = "Date of birth";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(-1, 79);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(31, 15);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(-1, 51);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(44, 15);
            this.lblMonth.TabIndex = 19;
            this.lblMonth.Text = "Month";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(101, 79);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(88, 23);
            this.txtYear.TabIndex = 20;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(101, 51);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(88, 23);
            this.txtMonth.TabIndex = 20;
            // 
            // btnSubmitAddSwimmer
            // 
            this.btnSubmitAddSwimmer.Location = new System.Drawing.Point(8, 324);
            this.btnSubmitAddSwimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitAddSwimmer.Name = "btnSubmitAddSwimmer";
            this.btnSubmitAddSwimmer.Size = new System.Drawing.Size(187, 21);
            this.btnSubmitAddSwimmer.TabIndex = 15;
            this.btnSubmitAddSwimmer.Text = "Submit";
            this.btnSubmitAddSwimmer.UseVisualStyleBackColor = true;
            this.btnSubmitAddSwimmer.Click += new System.EventHandler(this.btnSubmitAddSwimmer_Click);
            // 
            // lsbAllSwimmers
            // 
            this.lsbAllSwimmers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.lsbAllSwimmers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbAllSwimmers.FormattingEnabled = true;
            this.lsbAllSwimmers.ItemHeight = 15;
            this.lsbAllSwimmers.Location = new System.Drawing.Point(17, 15);
            this.lsbAllSwimmers.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAllSwimmers.Name = "lsbAllSwimmers";
            this.lsbAllSwimmers.Size = new System.Drawing.Size(133, 315);
            this.lsbAllSwimmers.TabIndex = 16;
            this.lsbAllSwimmers.SelectedIndexChanged += new System.EventHandler(this.lsbAllSwimmers_SelectedIndexChanged);
            // 
            // lblAboutStudent
            // 
            this.lblAboutStudent.AutoSize = true;
            this.lblAboutStudent.Location = new System.Drawing.Point(5, 26);
            this.lblAboutStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAboutStudent.Name = "lblAboutStudent";
            this.lblAboutStudent.Size = new System.Drawing.Size(0, 15);
            this.lblAboutStudent.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAboutStudent);
            this.groupBox2.Location = new System.Drawing.Point(447, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(205, 351);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About Swimmer: ";
            // 
            // txtSaveSwimmers
            // 
            this.txtSaveSwimmers.Location = new System.Drawing.Point(360, 452);
            this.txtSaveSwimmers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaveSwimmers.Name = "txtSaveSwimmers";
            this.txtSaveSwimmers.Size = new System.Drawing.Size(215, 23);
            this.txtSaveSwimmers.TabIndex = 44;
            this.txtSaveSwimmers.Text = "SaveFiles/Swimmers.txt";
            this.txtSaveSwimmers.DoubleClick += new System.EventHandler(this.txtSaveSwimmers_DoubleClick);
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Location = new System.Drawing.Point(584, 424);
            this.btnSaveSwimmers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(93, 51);
            this.btnSaveSwimmers.TabIndex = 43;
            this.btnSaveSwimmers.Text = "Save";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Save Swimmers:";
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Location = new System.Drawing.Point(234, 424);
            this.btnLoadSwimmers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(93, 51);
            this.btnLoadSwimmers.TabIndex = 41;
            this.btnLoadSwimmers.Text = "Load";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.btnLoadSwimmers_Click);
            // 
            // txtLoadSwimmers
            // 
            this.txtLoadSwimmers.Location = new System.Drawing.Point(10, 452);
            this.txtLoadSwimmers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoadSwimmers.Name = "txtLoadSwimmers";
            this.txtLoadSwimmers.Size = new System.Drawing.Size(215, 23);
            this.txtLoadSwimmers.TabIndex = 40;
            this.txtLoadSwimmers.Text = "LoadFiles/Swimmers.txt";
            this.txtLoadSwimmers.DoubleClick += new System.EventHandler(this.txtLoadSwimmers_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Load Swimmers:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(705, 43);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 45;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "By Eskender Memetov | Vadym Harkusha";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(796, 569);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 26);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbAllSwimmers);
            this.groupBox3.Location = new System.Drawing.Point(258, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(173, 351);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Swimmers";
            // 
            // FormSwimmers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(950, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSaveSwimmers);
            this.Controls.Add(this.btnSaveSwimmers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLoadSwimmers);
            this.Controls.Add(this.txtLoadSwimmers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSwimmers";
            this.Text = "Swimmers";
            this.Load += new System.EventHandler(this.FormSwimmers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxDOB.ResumeLayout(false);
            this.gBoxDOB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmitAddSwimmer;
        private System.Windows.Forms.ListBox lsbAllSwimmers;
        private System.Windows.Forms.GroupBox gBoxDOB;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblAboutStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaveSwimmers;
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.TextBox txtLoadSwimmers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}