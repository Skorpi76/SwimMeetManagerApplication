namespace SwimMeetManager
{
    partial class FormEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbDistance = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbStroke = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.btnAssignSwimmer = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.llbEventInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMiliSeconds = new System.Windows.Forms.TextBox();
            this.btnnAddTime = new System.Windows.Forms.Button();
            this.lblErrorAddTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance:";
            // 
            // lsbDistance
            // 
            this.lsbDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.lsbDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbDistance.FormattingEnabled = true;
            this.lsbDistance.ItemHeight = 15;
            this.lsbDistance.Items.AddRange(new object[] {
            "50 m",
            "100 m",
            "200 m",
            "400 m",
            "800 m",
            "1500 m"});
            this.lsbDistance.Location = new System.Drawing.Point(14, 68);
            this.lsbDistance.Name = "lsbDistance";
            this.lsbDistance.Size = new System.Drawing.Size(160, 92);
            this.lsbDistance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stroke:";
            // 
            // lsbStroke
            // 
            this.lsbStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.lsbStroke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbStroke.FormattingEnabled = true;
            this.lsbStroke.ItemHeight = 15;
            this.lsbStroke.Items.AddRange(new object[] {
            "Butterfly",
            "Backstroke",
            "Breaststroke",
            "Freestyle",
            "Individual medley"});
            this.lsbStroke.Location = new System.Drawing.Point(14, 190);
            this.lsbStroke.Name = "lsbStroke";
            this.lsbStroke.Size = new System.Drawing.Size(160, 77);
            this.lsbStroke.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Location = new System.Drawing.Point(14, 283);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(161, 27);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lsbEvents
            // 
            this.lsbEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.ItemHeight = 15;
            this.lsbEvents.Location = new System.Drawing.Point(17, 19);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(124, 227);
            this.lsbEvents.TabIndex = 7;
            this.lsbEvents.SelectedIndexChanged += new System.EventHandler(this.lsbEvents_SelectedIndexChanged);
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbSwimmers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.ItemHeight = 15;
            this.lsbSwimmers.Location = new System.Drawing.Point(6, 19);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.Size = new System.Drawing.Size(139, 227);
            this.lsbSwimmers.TabIndex = 9;
            // 
            // btnAssignSwimmer
            // 
            this.btnAssignSwimmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAssignSwimmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignSwimmer.Location = new System.Drawing.Point(369, 282);
            this.btnAssignSwimmer.Name = "btnAssignSwimmer";
            this.btnAssignSwimmer.Size = new System.Drawing.Size(140, 27);
            this.btnAssignSwimmer.TabIndex = 10;
            this.btnAssignSwimmer.Text = "Assign Swimmer";
            this.btnAssignSwimmer.UseVisualStyleBackColor = false;
            this.btnAssignSwimmer.Click += new System.EventHandler(this.btnAssignSwimmer_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(537, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 11;
            // 
            // llbEventInfo
            // 
            this.llbEventInfo.AutoSize = true;
            this.llbEventInfo.Location = new System.Drawing.Point(540, 15);
            this.llbEventInfo.Name = "llbEventInfo";
            this.llbEventInfo.Size = new System.Drawing.Size(66, 15);
            this.llbEventInfo.TabIndex = 12;
            this.llbEventInfo.Text = "Event info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Swimmer\'s time:";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(544, 212);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(32, 23);
            this.txtMinutes.TabIndex = 14;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(583, 212);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(32, 23);
            this.txtSeconds.TabIndex = 15;
            // 
            // txtMiliSeconds
            // 
            this.txtMiliSeconds.Location = new System.Drawing.Point(623, 212);
            this.txtMiliSeconds.Name = "txtMiliSeconds";
            this.txtMiliSeconds.Size = new System.Drawing.Size(32, 23);
            this.txtMiliSeconds.TabIndex = 16;
            // 
            // btnnAddTime
            // 
            this.btnnAddTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnAddTime.Location = new System.Drawing.Point(544, 283);
            this.btnnAddTime.Name = "btnnAddTime";
            this.btnnAddTime.Size = new System.Drawing.Size(112, 27);
            this.btnnAddTime.TabIndex = 17;
            this.btnnAddTime.Text = "Add Time";
            this.btnnAddTime.UseVisualStyleBackColor = false;
            this.btnnAddTime.Click += new System.EventHandler(this.btnnAddTime_Click);
            // 
            // lblErrorAddTime
            // 
            this.lblErrorAddTime.AutoSize = true;
            this.lblErrorAddTime.Location = new System.Drawing.Point(4, 5);
            this.lblErrorAddTime.Name = "lblErrorAddTime";
            this.lblErrorAddTime.Size = new System.Drawing.Size(0, 15);
            this.lblErrorAddTime.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "By Eskender Memetov 300805013 and Vadym Harkusha 300909484";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(631, 323);
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
            this.groupBox1.Controls.Add(this.lsbEvents);
            this.groupBox1.Location = new System.Drawing.Point(192, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 252);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbSwimmers);
            this.groupBox2.Location = new System.Drawing.Point(357, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 252);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Swimmer : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorAddTime);
            this.panel1.Location = new System.Drawing.Point(515, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 35);
            this.panel1.TabIndex = 51;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(726, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnnAddTime);
            this.Controls.Add(this.txtMiliSeconds);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llbEventInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAssignSwimmer);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lsbStroke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvent";
            this.Text = "FormEvent";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbStroke;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.Button btnAssignSwimmer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label llbEventInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMiliSeconds;
        private System.Windows.Forms.Button btnnAddTime;
        private System.Windows.Forms.Label lblErrorAddTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}