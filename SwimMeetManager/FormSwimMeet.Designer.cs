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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.lsbSwimMeets = new System.Windows.Forms.ListBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lstbEvents = new System.Windows.Forms.ListBox();
            this.btnAssignEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Swim Meet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start date:";
            // 
            // datepickerStart
            // 
            this.datepickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerStart.Location = new System.Drawing.Point(16, 90);
            this.datepickerStart.Name = "datepickerStart";
            this.datepickerStart.Size = new System.Drawing.Size(149, 20);
            this.datepickerStart.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "End date:";
            // 
            // datepickerEnd
            // 
            this.datepickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerEnd.Location = new System.Drawing.Point(16, 133);
            this.datepickerEnd.Name = "datepickerEnd";
            this.datepickerEnd.Size = new System.Drawing.Size(149, 20);
            this.datepickerEnd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course:";
            // 
            // lsbCourse
            // 
            this.lsbCourse.FormattingEnabled = true;
            this.lsbCourse.Items.AddRange(new object[] {
            "SCM",
            "SCY",
            "LCM"});
            this.lsbCourse.Location = new System.Drawing.Point(16, 181);
            this.lsbCourse.Name = "lsbCourse";
            this.lsbCourse.Size = new System.Drawing.Size(149, 43);
            this.lsbCourse.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of Lanes:";
            // 
            // txtNumberOfLanes
            // 
            this.txtNumberOfLanes.Location = new System.Drawing.Point(115, 234);
            this.txtNumberOfLanes.Name = "txtNumberOfLanes";
            this.txtNumberOfLanes.Size = new System.Drawing.Size(49, 20);
            this.txtNumberOfLanes.TabIndex = 10;
            // 
            // btnAddSwimMeet
            // 
            this.btnAddSwimMeet.Location = new System.Drawing.Point(16, 274);
            this.btnAddSwimMeet.Name = "btnAddSwimMeet";
            this.btnAddSwimMeet.Size = new System.Drawing.Size(148, 23);
            this.btnAddSwimMeet.TabIndex = 11;
            this.btnAddSwimMeet.Text = "Add Swim Meet";
            this.btnAddSwimMeet.UseVisualStyleBackColor = true;
            this.btnAddSwimMeet.Click += new System.EventHandler(this.btnAddSwimMeet_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(21, 254);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Swim Meets:";
            // 
            // lsbSwimMeets
            // 
            this.lsbSwimMeets.FormattingEnabled = true;
            this.lsbSwimMeets.Location = new System.Drawing.Point(198, 46);
            this.lsbSwimMeets.Name = "lsbSwimMeets";
            this.lsbSwimMeets.Size = new System.Drawing.Size(127, 212);
            this.lsbSwimMeets.TabIndex = 14;
            this.lsbSwimMeets.SelectedIndexChanged += new System.EventHandler(this.lsbSwimMeets_SelectedIndexChanged);
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(198, 273);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(127, 23);
            this.btnSeed.TabIndex = 15;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Swim Meet info:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(4, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 17;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(359, 13);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 18;
            this.lblEvents.Text = "Events";
            // 
            // lstbEvents
            // 
            this.lstbEvents.FormattingEnabled = true;
            this.lstbEvents.Location = new System.Drawing.Point(362, 46);
            this.lstbEvents.Name = "lstbEvents";
            this.lstbEvents.Size = new System.Drawing.Size(120, 212);
            this.lstbEvents.TabIndex = 19;
            // 
            // btnAssignEvent
            // 
            this.btnAssignEvent.Location = new System.Drawing.Point(362, 273);
            this.btnAssignEvent.Name = "btnAssignEvent";
            this.btnAssignEvent.Size = new System.Drawing.Size(120, 23);
            this.btnAssignEvent.TabIndex = 20;
            this.btnAssignEvent.Text = "Assign Event";
            this.btnAssignEvent.UseVisualStyleBackColor = true;
            this.btnAssignEvent.Click += new System.EventHandler(this.btnAssignEvent_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(506, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 263);
            this.panel1.TabIndex = 21;
            // 
            // FormSwimMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAssignEvent);
            this.Controls.Add(this.lstbEvents);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.lsbSwimMeets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddSwimMeet);
            this.Controls.Add(this.txtNumberOfLanes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsbCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datepickerEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepickerStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSwimMeet";
            this.Text = "FormSwimMeet";
            this.Load += new System.EventHandler(this.FormSwimMeet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbSwimMeets;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ListBox lstbEvents;
        private System.Windows.Forms.Button btnAssignEvent;
        private System.Windows.Forms.Panel panel1;
    }
}