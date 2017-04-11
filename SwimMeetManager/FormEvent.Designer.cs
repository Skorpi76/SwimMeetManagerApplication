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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbDistance = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbStroke = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.btnAssignSwimmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance:";
            // 
            // lsbDistance
            // 
            this.lsbDistance.FormattingEnabled = true;
            this.lsbDistance.Items.AddRange(new object[] {
            "50 m",
            "100 m",
            "200 m",
            "400 m",
            "800 m",
            "1500 m"});
            this.lsbDistance.Location = new System.Drawing.Point(12, 59);
            this.lsbDistance.Name = "lsbDistance";
            this.lsbDistance.Size = new System.Drawing.Size(138, 82);
            this.lsbDistance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stroke:";
            // 
            // lsbStroke
            // 
            this.lsbStroke.FormattingEnabled = true;
            this.lsbStroke.Items.AddRange(new object[] {
            "Butterfly",
            "Backstroke",
            "Breaststroke",
            "Freestyle",
            "Individual medley"});
            this.lsbStroke.Location = new System.Drawing.Point(12, 165);
            this.lsbStroke.Name = "lsbStroke";
            this.lsbStroke.Size = new System.Drawing.Size(138, 69);
            this.lsbStroke.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(12, 245);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(138, 23);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Events:";
            // 
            // lsbEvents
            // 
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.Location = new System.Drawing.Point(171, 43);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(120, 225);
            this.lsbEvents.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Assign Swimmer:";
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.Location = new System.Drawing.Point(316, 43);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.Size = new System.Drawing.Size(120, 186);
            this.lsbSwimmers.TabIndex = 9;
            // 
            // btnAssignSwimmer
            // 
            this.btnAssignSwimmer.Location = new System.Drawing.Point(316, 244);
            this.btnAssignSwimmer.Name = "btnAssignSwimmer";
            this.btnAssignSwimmer.Size = new System.Drawing.Size(120, 23);
            this.btnAssignSwimmer.TabIndex = 10;
            this.btnAssignSwimmer.Text = "Assign Swimmer";
            this.btnAssignSwimmer.UseVisualStyleBackColor = true;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 286);
            this.Controls.Add(this.btnAssignSwimmer);
            this.Controls.Add(this.lsbSwimmers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbEvents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lsbStroke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEvent";
            this.Text = "FormEvent";
            this.Load += new System.EventHandler(this.FormEvent_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.Button btnAssignSwimmer;
    }
}