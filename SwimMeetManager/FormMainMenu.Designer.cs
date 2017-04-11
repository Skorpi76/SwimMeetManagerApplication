namespace SwimMeetManager
{
    partial class FormMainMenu
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
            this.btnGoToSwimmers = new System.Windows.Forms.Button();
            this.btnGoToCoaches = new System.Windows.Forms.Button();
            this.btnGoToClubs = new System.Windows.Forms.Button();
            this.btnGoToEvents = new System.Windows.Forms.Button();
            this.gtnGoToSwimMeets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToSwimmers
            // 
            this.btnGoToSwimmers.Location = new System.Drawing.Point(134, 52);
            this.btnGoToSwimmers.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToSwimmers.Name = "btnGoToSwimmers";
            this.btnGoToSwimmers.Size = new System.Drawing.Size(56, 19);
            this.btnGoToSwimmers.TabIndex = 0;
            this.btnGoToSwimmers.Text = "Swimmers";
            this.btnGoToSwimmers.UseVisualStyleBackColor = true;
            this.btnGoToSwimmers.Click += new System.EventHandler(this.btnGoToSwimmers_Click);
            // 
            // btnGoToCoaches
            // 
            this.btnGoToCoaches.Location = new System.Drawing.Point(134, 87);
            this.btnGoToCoaches.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToCoaches.Name = "btnGoToCoaches";
            this.btnGoToCoaches.Size = new System.Drawing.Size(56, 19);
            this.btnGoToCoaches.TabIndex = 1;
            this.btnGoToCoaches.Text = "Coaches";
            this.btnGoToCoaches.UseVisualStyleBackColor = true;
            this.btnGoToCoaches.Click += new System.EventHandler(this.btnGoToCoaches_Click);
            // 
            // btnGoToClubs
            // 
            this.btnGoToClubs.Location = new System.Drawing.Point(134, 128);
            this.btnGoToClubs.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToClubs.Name = "btnGoToClubs";
            this.btnGoToClubs.Size = new System.Drawing.Size(56, 19);
            this.btnGoToClubs.TabIndex = 2;
            this.btnGoToClubs.Text = "Clubs";
            this.btnGoToClubs.UseVisualStyleBackColor = true;
            this.btnGoToClubs.Click += new System.EventHandler(this.btnGoToClubs_Click);
            // 
            // btnGoToEvents
            // 
            this.btnGoToEvents.Location = new System.Drawing.Point(134, 165);
            this.btnGoToEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToEvents.Name = "btnGoToEvents";
            this.btnGoToEvents.Size = new System.Drawing.Size(56, 19);
            this.btnGoToEvents.TabIndex = 3;
            this.btnGoToEvents.Text = "Events";
            this.btnGoToEvents.UseVisualStyleBackColor = true;
            this.btnGoToEvents.Click += new System.EventHandler(this.btnGoToEvents_Click);
            // 
            // gtnGoToSwimMeets
            // 
            this.gtnGoToSwimMeets.Location = new System.Drawing.Point(134, 197);
            this.gtnGoToSwimMeets.Margin = new System.Windows.Forms.Padding(2);
            this.gtnGoToSwimMeets.Name = "gtnGoToSwimMeets";
            this.gtnGoToSwimMeets.Size = new System.Drawing.Size(56, 19);
            this.gtnGoToSwimMeets.TabIndex = 4;
            this.gtnGoToSwimMeets.Text = "Swim Meets";
            this.gtnGoToSwimMeets.UseVisualStyleBackColor = true;
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 353);
            this.Controls.Add(this.gtnGoToSwimMeets);
            this.Controls.Add(this.btnGoToEvents);
            this.Controls.Add(this.btnGoToClubs);
            this.Controls.Add(this.btnGoToCoaches);
            this.Controls.Add(this.btnGoToSwimmers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMainMenu";
            this.Text = "Swim Meet Manager";
            this.Load += new System.EventHandler(this.formMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToSwimmers;
        private System.Windows.Forms.Button btnGoToCoaches;
        private System.Windows.Forms.Button btnGoToClubs;
        private System.Windows.Forms.Button btnGoToEvents;
        private System.Windows.Forms.Button gtnGoToSwimMeets;
    }
}

