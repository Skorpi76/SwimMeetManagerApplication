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
            this.lblAllCoaches = new System.Windows.Forms.Label();
            this.lsbAllCoaches = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCredentials = new System.Windows.Forms.TextBox();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.gBoxDOB = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxDOB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAboutCoach);
            this.groupBox2.Location = new System.Drawing.Point(374, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(176, 219);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About Coach: ";
            // 
            // lblAboutCoach
            // 
            this.lblAboutCoach.AutoSize = true;
            this.lblAboutCoach.Location = new System.Drawing.Point(4, 23);
            this.lblAboutCoach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAboutCoach.Name = "lblAboutCoach";
            this.lblAboutCoach.Size = new System.Drawing.Size(0, 13);
            this.lblAboutCoach.TabIndex = 18;
            // 
            // lblAllCoaches
            // 
            this.lblAllCoaches.AutoSize = true;
            this.lblAllCoaches.Location = new System.Drawing.Point(243, 10);
            this.lblAllCoaches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllCoaches.Name = "lblAllCoaches";
            this.lblAllCoaches.Size = new System.Drawing.Size(66, 13);
            this.lblAllCoaches.TabIndex = 22;
            this.lblAllCoaches.Text = "All Coaches:";
            // 
            // lsbAllCoaches
            // 
            this.lsbAllCoaches.FormattingEnabled = true;
            this.lsbAllCoaches.Location = new System.Drawing.Point(243, 37);
            this.lsbAllCoaches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbAllCoaches.Name = "lsbAllCoaches";
            this.lsbAllCoaches.Size = new System.Drawing.Size(114, 212);
            this.lsbAllCoaches.TabIndex = 21;
            this.lsbAllCoaches.SelectedIndexChanged += new System.EventHandler(this.lsbAllCoaches_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCredentials);
            this.groupBox1.Controls.Add(this.lblCredentials);
            this.groupBox1.Controls.Add(this.gBoxDOB);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(206, 332);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Coach";
            // 
            // txtCredentials
            // 
            this.txtCredentials.Location = new System.Drawing.Point(92, 264);
            this.txtCredentials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCredentials.Name = "txtCredentials";
            this.txtCredentials.Size = new System.Drawing.Size(76, 20);
            this.txtCredentials.TabIndex = 20;
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Location = new System.Drawing.Point(4, 266);
            this.lblCredentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(59, 13);
            this.lblCredentials.TabIndex = 19;
            this.lblCredentials.Text = "Credentials";
            // 
            // gBoxDOB
            // 
            this.gBoxDOB.Controls.Add(this.lblYear);
            this.gBoxDOB.Controls.Add(this.lblMonth);
            this.gBoxDOB.Controls.Add(this.txtYear);
            this.gBoxDOB.Controls.Add(this.lblDay);
            this.gBoxDOB.Controls.Add(this.txtMonth);
            this.gBoxDOB.Controls.Add(this.txtDay);
            this.gBoxDOB.Location = new System.Drawing.Point(7, 48);
            this.gBoxDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxDOB.Name = "gBoxDOB";
            this.gBoxDOB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxDOB.Size = new System.Drawing.Size(166, 103);
            this.gBoxDOB.TabIndex = 18;
            this.gBoxDOB.TabStop = false;
            this.gBoxDOB.Text = "Date of birth";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(-1, 68);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(-1, 45);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 19;
            this.lblMonth.Text = "Month";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(87, 68);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(76, 20);
            this.txtYear.TabIndex = 20;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(-1, 22);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(87, 45);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(76, 20);
            this.txtMonth.TabIndex = 20;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(87, 22);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(76, 20);
            this.txtDay.TabIndex = 9;
            // 
            // btnSubmitAddCoach
            // 
            this.btnSubmitAddCoach.Location = new System.Drawing.Point(8, 299);
            this.btnSubmitAddCoach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitAddCoach.Name = "btnSubmitAddCoach";
            this.btnSubmitAddCoach.Size = new System.Drawing.Size(160, 19);
            this.btnSubmitAddCoach.TabIndex = 15;
            this.btnSubmitAddCoach.Text = "Submit";
            this.btnSubmitAddCoach.UseVisualStyleBackColor = true;
            this.btnSubmitAddCoach.Click += new System.EventHandler(this.btnSubmitAddCoach_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(92, 241);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(76, 20);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 19);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(92, 218);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(76, 20);
            this.txtPostalCode.TabIndex = 13;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(92, 193);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(76, 20);
            this.txtProvince.TabIndex = 12;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(4, 125);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 170);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(76, 20);
            this.txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(4, 174);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(93, 121);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(76, 20);
            this.txtStreet.TabIndex = 10;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(4, 197);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(4, 220);
            this.lblPostalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(70, 13);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postal Code: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(4, 241);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number: ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(245, 275);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 24;
            // 
            // FormCoaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 436);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAllCoaches);
            this.Controls.Add(this.lsbAllCoaches);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCoaches";
            this.Text = "formCoaches";
            this.Load += new System.EventHandler(this.FormCoaches_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxDOB.ResumeLayout(false);
            this.gBoxDOB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAboutCoach;
        private System.Windows.Forms.Label lblAllCoaches;
        private System.Windows.Forms.ListBox lsbAllCoaches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBoxDOB;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
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
    }
}