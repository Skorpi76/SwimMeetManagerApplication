namespace SwimMeetManager
{
    partial class FormSwimMeet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwimMeet));
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datepickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datepickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lsbCourse = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberOfLanes = new System.Windows.Forms.TextBox();
            this.btnAddSwimMeet = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lsbSwimMeets = new System.Windows.Forms.ListBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstbEvents = new System.Windows.Forms.ListBox();
            this.btnAssignEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(61, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 23);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start date:";
            // 
            // datepickerStart
            // 
            this.datepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerStart.Location = new System.Drawing.Point(14, 74);
            this.datepickerStart.Name = "datepickerStart";
            this.datepickerStart.Size = new System.Drawing.Size(173, 23);
            this.datepickerStart.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "End date:";
            // 
            // datepickerEnd
            // 
            this.datepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerEnd.Location = new System.Drawing.Point(14, 123);
            this.datepickerEnd.Name = "datepickerEnd";
            this.datepickerEnd.Size = new System.Drawing.Size(173, 23);
            this.datepickerEnd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course:";
            // 
            // lsbCourse
            // 
            this.lsbCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbCourse.FormattingEnabled = true;
            this.lsbCourse.ItemHeight = 15;
            this.lsbCourse.Items.AddRange(new object[] {
            "SCM",
            "SCY",
            "LCM"});
            this.lsbCourse.Location = new System.Drawing.Point(14, 179);
            this.lsbCourse.Name = "lsbCourse";
            this.lsbCourse.Size = new System.Drawing.Size(173, 47);
            this.lsbCourse.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Lanes:";
            // 
            // txtNumberOfLanes
            // 
            this.txtNumberOfLanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtNumberOfLanes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfLanes.Location = new System.Drawing.Point(129, 240);
            this.txtNumberOfLanes.Name = "txtNumberOfLanes";
            this.txtNumberOfLanes.Size = new System.Drawing.Size(56, 23);
            this.txtNumberOfLanes.TabIndex = 10;
            // 
            // btnAddSwimMeet
            // 
            this.btnAddSwimMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAddSwimMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSwimMeet.Location = new System.Drawing.Point(19, 316);
            this.btnAddSwimMeet.Name = "btnAddSwimMeet";
            this.btnAddSwimMeet.Size = new System.Drawing.Size(173, 27);
            this.btnAddSwimMeet.TabIndex = 11;
            this.btnAddSwimMeet.Text = "Add Swim Meet";
            this.btnAddSwimMeet.UseVisualStyleBackColor = false;
            this.btnAddSwimMeet.Click += new System.EventHandler(this.btnAddSwimMeet_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(19, 263);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 12;
            // 
            // lsbSwimMeets
            // 
            this.lsbSwimMeets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbSwimMeets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbSwimMeets.FormattingEnabled = true;
            this.lsbSwimMeets.ItemHeight = 15;
            this.lsbSwimMeets.Location = new System.Drawing.Point(13, 23);
            this.lsbSwimMeets.Name = "lsbSwimMeets";
            this.lsbSwimMeets.Size = new System.Drawing.Size(166, 242);
            this.lsbSwimMeets.TabIndex = 14;
            this.lsbSwimMeets.SelectedIndexChanged += new System.EventHandler(this.lsbSwimMeets_SelectedIndexChanged);
            // 
            // btnSeed
            // 
            this.btnSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeed.Location = new System.Drawing.Point(231, 315);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(148, 27);
            this.btnSeed.TabIndex = 15;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = false;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Swim Meet info:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(5, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 17;
            // 
            // lstbEvents
            // 
            this.lstbEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lstbEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbEvents.FormattingEnabled = true;
            this.lstbEvents.ItemHeight = 15;
            this.lstbEvents.Location = new System.Drawing.Point(6, 22);
            this.lstbEvents.Name = "lstbEvents";
            this.lstbEvents.Size = new System.Drawing.Size(139, 242);
            this.lstbEvents.TabIndex = 19;
            // 
            // btnAssignEvent
            // 
            this.btnAssignEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAssignEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignEvent.Location = new System.Drawing.Point(422, 315);
            this.btnAssignEvent.Name = "btnAssignEvent";
            this.btnAssignEvent.Size = new System.Drawing.Size(140, 27);
            this.btnAssignEvent.TabIndex = 20;
            this.btnAssignEvent.Text = "Assign Event";
            this.btnAssignEvent.UseVisualStyleBackColor = false;
            this.btnAssignEvent.Click += new System.EventHandler(this.btnAssignEvent_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(598, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 304);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "By Eskender Memetov 300805013 and Vadym Harkusha 300909484";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(778, 347);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 26);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datepickerEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datepickerStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lsbCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumberOfLanes);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 280);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Swim Meet: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbSwimMeets);
            this.groupBox2.Location = new System.Drawing.Point(218, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 280);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Swim Meets:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstbEvents);
            this.groupBox3.Location = new System.Drawing.Point(422, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 280);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Events: ";
            // 
            // FormSwimMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(872, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssignEvent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.btnAddSwimMeet);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSwimMeet";
            this.Text = "FormSwimMeet";
            this.Load += new System.EventHandler(this.FormSwimMeet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datepickerEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfLanes;
        private System.Windows.Forms.Button btnAddSwimMeet;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox lsbSwimMeets;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstbEvents;
        private System.Windows.Forms.Button btnAssignEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}