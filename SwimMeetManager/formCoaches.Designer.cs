namespace SwimMeetManager
{
    partial class FormCoaches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoaches));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAboutCoach = new System.Windows.Forms.Label();
            this.lsbAllCoaches = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCredentials = new System.Windows.Forms.TextBox();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnSubmitAddCoach = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssignRegistrant = new System.Windows.Forms.Button();
            this.lsbRegistrantsAssign = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lsbRegistrantsShow = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.datepickerDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.lblAboutCoach);
            this.groupBox2.Location = new System.Drawing.Point(450, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(205, 383);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About Coach: ";
            // 
            // lblAboutCoach
            // 
            this.lblAboutCoach.AutoSize = true;
            this.lblAboutCoach.Location = new System.Drawing.Point(5, 27);
            this.lblAboutCoach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAboutCoach.Name = "lblAboutCoach";
            this.lblAboutCoach.Size = new System.Drawing.Size(0, 15);
            this.lblAboutCoach.TabIndex = 18;
            // 
            // lsbAllCoaches
            // 
            this.lsbAllCoaches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbAllCoaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbAllCoaches.FormattingEnabled = true;
            this.lsbAllCoaches.ItemHeight = 15;
            this.lsbAllCoaches.Location = new System.Drawing.Point(16, 21);
            this.lsbAllCoaches.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAllCoaches.Name = "lsbAllCoaches";
            this.lsbAllCoaches.Size = new System.Drawing.Size(159, 332);
            this.lsbAllCoaches.TabIndex = 21;
            this.lsbAllCoaches.SelectedIndexChanged += new System.EventHandler(this.lsbAllCoaches_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datepickerDOB);
            this.groupBox1.Controls.Add(this.txtCredentials);
            this.groupBox1.Controls.Add(this.lblDay);
            this.groupBox1.Controls.Add(this.lblCredentials);
            this.groupBox1.Controls.Add(this.btnSubmitAddCoach);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(240, 383);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Coach";
            // 
            // txtCredentials
            // 
            this.txtCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtCredentials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredentials.Location = new System.Drawing.Point(110, 216);
            this.txtCredentials.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredentials.Name = "txtCredentials";
            this.txtCredentials.Size = new System.Drawing.Size(88, 23);
            this.txtCredentials.TabIndex = 20;
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Location = new System.Drawing.Point(8, 218);
            this.lblCredentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(69, 15);
            this.lblCredentials.TabIndex = 19;
            this.lblCredentials.Text = "Credentials";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(5, 60);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(31, 15);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "DOB";
            // 
            // btnSubmitAddCoach
            // 
            this.btnSubmitAddCoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnSubmitAddCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAddCoach.Location = new System.Drawing.Point(22, 303);
            this.btnSubmitAddCoach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitAddCoach.Name = "btnSubmitAddCoach";
            this.btnSubmitAddCoach.Size = new System.Drawing.Size(187, 22);
            this.btnSubmitAddCoach.TabIndex = 15;
            this.btnSubmitAddCoach.Text = "Submit";
            this.btnSubmitAddCoach.UseVisualStyleBackColor = false;
            this.btnSubmitAddCoach.Click += new System.EventHandler(this.btnSubmitAddCoach_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(110, 189);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(88, 23);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Location = new System.Drawing.Point(110, 163);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(88, 23);
            this.txtPostalCode.TabIndex = 13;
            // 
            // txtProvince
            // 
            this.txtProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvince.Location = new System.Drawing.Point(110, 134);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(88, 23);
            this.txtProvince.TabIndex = 12;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 88);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 15);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(110, 107);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(88, 23);
            this.txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(8, 112);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Location = new System.Drawing.Point(110, 80);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(88, 23);
            this.txtStreet.TabIndex = 10;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(8, 138);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(58, 15);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(8, 165);
            this.lblPostalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(78, 15);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal Code: ";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(110, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 23);
            this.txtName.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(8, 189);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 15);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number: ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(17, 397);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "By Eskender Memetov 300805013 and Vadym Harkusha 300909484";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAssignRegistrant);
            this.groupBox3.Controls.Add(this.lsbRegistrantsAssign);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(659, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(205, 383);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assign Swimmers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 18;
            // 
            // btnAssignRegistrant
            // 
            this.btnAssignRegistrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAssignRegistrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignRegistrant.Location = new System.Drawing.Point(10, 329);
            this.btnAssignRegistrant.Name = "btnAssignRegistrant";
            this.btnAssignRegistrant.Size = new System.Drawing.Size(170, 27);
            this.btnAssignRegistrant.TabIndex = 26;
            this.btnAssignRegistrant.Text = "Assign Swimmer";
            this.btnAssignRegistrant.UseVisualStyleBackColor = false;
            this.btnAssignRegistrant.Click += new System.EventHandler(this.btnAssignRegistrant_Click);
            // 
            // lsbRegistrantsAssign
            // 
            this.lsbRegistrantsAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbRegistrantsAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbRegistrantsAssign.FormattingEnabled = true;
            this.lsbRegistrantsAssign.ItemHeight = 15;
            this.lsbRegistrantsAssign.Location = new System.Drawing.Point(10, 27);
            this.lsbRegistrantsAssign.Name = "lsbRegistrantsAssign";
            this.lsbRegistrantsAssign.Size = new System.Drawing.Size(170, 287);
            this.lsbRegistrantsAssign.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbAllCoaches);
            this.groupBox4.Location = new System.Drawing.Point(255, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 383);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All coaches";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lsbRegistrantsShow);
            this.groupBox5.Location = new System.Drawing.Point(5, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 156);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Swimmers:";
            // 
            // lsbRegistrantsShow
            // 
            this.lsbRegistrantsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbRegistrantsShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbRegistrantsShow.FormattingEnabled = true;
            this.lsbRegistrantsShow.ItemHeight = 15;
            this.lsbRegistrantsShow.Location = new System.Drawing.Point(6, 22);
            this.lsbRegistrantsShow.Name = "lsbRegistrantsShow";
            this.lsbRegistrantsShow.Size = new System.Drawing.Size(176, 122);
            this.lsbRegistrantsShow.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(763, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // datepickerDOB
            // 
            this.datepickerDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.datepickerDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.datepickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerDOB.Location = new System.Drawing.Point(110, 52);
            this.datepickerDOB.Name = "datepickerDOB";
            this.datepickerDOB.Size = new System.Drawing.Size(89, 23);
            this.datepickerDOB.TabIndex = 51;
            // 
            // FormCoaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(882, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCoaches";
            this.Text = "formCoaches";
            this.Load += new System.EventHandler(this.FormCoaches_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAboutCoach;
        private System.Windows.Forms.ListBox lsbAllCoaches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnSubmitAddCoach;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtCredentials;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssignRegistrant;
        private System.Windows.Forms.ListBox lsbRegistrantsAssign;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lsbRegistrantsShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker datepickerDOB;
    }
}