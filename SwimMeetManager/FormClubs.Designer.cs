namespace SwimMeetManager
{
    partial class FormClubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClubs));
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubAddress = new System.Windows.Forms.Label();
            this.lblClubCity = new System.Windows.Forms.Label();
            this.lblClubProvince = new System.Windows.Forms.Label();
            this.lblClubZip = new System.Windows.Forms.Label();
            this.lblClubPhone = new System.Windows.Forms.Label();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtClubAddress = new System.Windows.Forms.TextBox();
            this.txtClubCity = new System.Windows.Forms.TextBox();
            this.txtClubProvince = new System.Windows.Forms.TextBox();
            this.txtClubZip = new System.Windows.Forms.TextBox();
            this.txtClubPhone = new System.Windows.Forms.TextBox();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.lblAddClubError = new System.Windows.Forms.Label();
            this.lsbClubs = new System.Windows.Forms.ListBox();
            this.lblClubInfo = new System.Windows.Forms.Label();
            this.rbtnSwimmersAssign = new System.Windows.Forms.RadioButton();
            this.rbtnCoachesAssign = new System.Windows.Forms.RadioButton();
            this.lsbRegistrantsAssign = new System.Windows.Forms.ListBox();
            this.btnAssignRegistrant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCoachesShow = new System.Windows.Forms.RadioButton();
            this.rbtnSwimmersShow = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsbRegistrantsShow = new System.Windows.Forms.ListBox();
            this.lblRegistrantInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoadClubs = new System.Windows.Forms.TextBox();
            this.btnLoadClubs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveClubs = new System.Windows.Forms.Button();
            this.txtSaveClubs = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Location = new System.Drawing.Point(6, 37);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(44, 15);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Name:";
            // 
            // lblClubAddress
            // 
            this.lblClubAddress.AutoSize = true;
            this.lblClubAddress.Location = new System.Drawing.Point(6, 68);
            this.lblClubAddress.Name = "lblClubAddress";
            this.lblClubAddress.Size = new System.Drawing.Size(55, 15);
            this.lblClubAddress.TabIndex = 2;
            this.lblClubAddress.Text = "Address:";
            // 
            // lblClubCity
            // 
            this.lblClubCity.AutoSize = true;
            this.lblClubCity.Location = new System.Drawing.Point(6, 98);
            this.lblClubCity.Name = "lblClubCity";
            this.lblClubCity.Size = new System.Drawing.Size(32, 15);
            this.lblClubCity.TabIndex = 3;
            this.lblClubCity.Text = "City:";
            // 
            // lblClubProvince
            // 
            this.lblClubProvince.AutoSize = true;
            this.lblClubProvince.Location = new System.Drawing.Point(6, 129);
            this.lblClubProvince.Name = "lblClubProvince";
            this.lblClubProvince.Size = new System.Drawing.Size(58, 15);
            this.lblClubProvince.TabIndex = 4;
            this.lblClubProvince.Text = "Province:";
            // 
            // lblClubZip
            // 
            this.lblClubZip.AutoSize = true;
            this.lblClubZip.Location = new System.Drawing.Point(6, 160);
            this.lblClubZip.Name = "lblClubZip";
            this.lblClubZip.Size = new System.Drawing.Size(27, 15);
            this.lblClubZip.TabIndex = 5;
            this.lblClubZip.Text = "ZIP:";
            // 
            // lblClubPhone
            // 
            this.lblClubPhone.AutoSize = true;
            this.lblClubPhone.Location = new System.Drawing.Point(6, 192);
            this.lblClubPhone.Name = "lblClubPhone";
            this.lblClubPhone.Size = new System.Drawing.Size(46, 15);
            this.lblClubPhone.TabIndex = 6;
            this.lblClubPhone.Text = "Phone:";
            // 
            // txtClubName
            // 
            this.txtClubName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubName.Location = new System.Drawing.Point(73, 33);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(116, 23);
            this.txtClubName.TabIndex = 7;
            // 
            // txtClubAddress
            // 
            this.txtClubAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubAddress.Location = new System.Drawing.Point(73, 65);
            this.txtClubAddress.Name = "txtClubAddress";
            this.txtClubAddress.Size = new System.Drawing.Size(116, 23);
            this.txtClubAddress.TabIndex = 8;
            // 
            // txtClubCity
            // 
            this.txtClubCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubCity.Location = new System.Drawing.Point(73, 95);
            this.txtClubCity.Name = "txtClubCity";
            this.txtClubCity.Size = new System.Drawing.Size(116, 23);
            this.txtClubCity.TabIndex = 9;
            // 
            // txtClubProvince
            // 
            this.txtClubProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubProvince.Location = new System.Drawing.Point(73, 126);
            this.txtClubProvince.Name = "txtClubProvince";
            this.txtClubProvince.Size = new System.Drawing.Size(116, 23);
            this.txtClubProvince.TabIndex = 10;
            // 
            // txtClubZip
            // 
            this.txtClubZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubZip.Location = new System.Drawing.Point(73, 157);
            this.txtClubZip.Name = "txtClubZip";
            this.txtClubZip.Size = new System.Drawing.Size(116, 23);
            this.txtClubZip.TabIndex = 11;
            // 
            // txtClubPhone
            // 
            this.txtClubPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtClubPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClubPhone.Location = new System.Drawing.Point(73, 188);
            this.txtClubPhone.Name = "txtClubPhone";
            this.txtClubPhone.Size = new System.Drawing.Size(116, 23);
            this.txtClubPhone.TabIndex = 12;
            // 
            // btnAddClub
            // 
            this.btnAddClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAddClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClub.Location = new System.Drawing.Point(30, 266);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(181, 27);
            this.btnAddClub.TabIndex = 13;
            this.btnAddClub.Text = "Add Club";
            this.btnAddClub.UseVisualStyleBackColor = false;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // lblAddClubError
            // 
            this.lblAddClubError.AutoSize = true;
            this.lblAddClubError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddClubError.Location = new System.Drawing.Point(19, 238);
            this.lblAddClubError.Name = "lblAddClubError";
            this.lblAddClubError.Size = new System.Drawing.Size(0, 13);
            this.lblAddClubError.TabIndex = 14;
            // 
            // lsbClubs
            // 
            this.lsbClubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbClubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbClubs.FormattingEnabled = true;
            this.lsbClubs.ItemHeight = 15;
            this.lsbClubs.Location = new System.Drawing.Point(13, 22);
            this.lsbClubs.Name = "lsbClubs";
            this.lsbClubs.Size = new System.Drawing.Size(187, 242);
            this.lsbClubs.TabIndex = 16;
            this.lsbClubs.SelectedIndexChanged += new System.EventHandler(this.lsbClubs_SelectedIndexChanged);
            // 
            // lblClubInfo
            // 
            this.lblClubInfo.AutoSize = true;
            this.lblClubInfo.Location = new System.Drawing.Point(19, 30);
            this.lblClubInfo.Name = "lblClubInfo";
            this.lblClubInfo.Size = new System.Drawing.Size(0, 15);
            this.lblClubInfo.TabIndex = 18;
            // 
            // rbtnSwimmersAssign
            // 
            this.rbtnSwimmersAssign.AutoSize = true;
            this.rbtnSwimmersAssign.Checked = true;
            this.rbtnSwimmersAssign.Location = new System.Drawing.Point(4, 8);
            this.rbtnSwimmersAssign.Name = "rbtnSwimmersAssign";
            this.rbtnSwimmersAssign.Size = new System.Drawing.Size(83, 19);
            this.rbtnSwimmersAssign.TabIndex = 21;
            this.rbtnSwimmersAssign.TabStop = true;
            this.rbtnSwimmersAssign.Text = "Swimmers";
            this.rbtnSwimmersAssign.UseVisualStyleBackColor = true;
            this.rbtnSwimmersAssign.CheckedChanged += new System.EventHandler(this.rbtnSwimmersAssign_CheckedChanged);
            // 
            // rbtnCoachesAssign
            // 
            this.rbtnCoachesAssign.AutoSize = true;
            this.rbtnCoachesAssign.Location = new System.Drawing.Point(100, 8);
            this.rbtnCoachesAssign.Name = "rbtnCoachesAssign";
            this.rbtnCoachesAssign.Size = new System.Drawing.Size(69, 19);
            this.rbtnCoachesAssign.TabIndex = 22;
            this.rbtnCoachesAssign.Text = "Coaches";
            this.rbtnCoachesAssign.UseVisualStyleBackColor = true;
            this.rbtnCoachesAssign.CheckedChanged += new System.EventHandler(this.rbtnSwimmersAssign_CheckedChanged);
            // 
            // lsbRegistrantsAssign
            // 
            this.lsbRegistrantsAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbRegistrantsAssign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbRegistrantsAssign.FormattingEnabled = true;
            this.lsbRegistrantsAssign.ItemHeight = 15;
            this.lsbRegistrantsAssign.Location = new System.Drawing.Point(14, 65);
            this.lsbRegistrantsAssign.Name = "lsbRegistrantsAssign";
            this.lsbRegistrantsAssign.Size = new System.Drawing.Size(196, 152);
            this.lsbRegistrantsAssign.TabIndex = 23;
            // 
            // btnAssignRegistrant
            // 
            this.btnAssignRegistrant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnAssignRegistrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignRegistrant.Location = new System.Drawing.Point(496, 266);
            this.btnAssignRegistrant.Name = "btnAssignRegistrant";
            this.btnAssignRegistrant.Size = new System.Drawing.Size(170, 27);
            this.btnAssignRegistrant.TabIndex = 24;
            this.btnAssignRegistrant.Text = "Assign Registrant";
            this.btnAssignRegistrant.UseVisualStyleBackColor = false;
            this.btnAssignRegistrant.Click += new System.EventHandler(this.btnAssignRegistrant_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnSwimmersAssign);
            this.panel1.Controls.Add(this.rbtnCoachesAssign);
            this.panel1.Location = new System.Drawing.Point(14, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 33);
            this.panel1.TabIndex = 25;
            // 
            // rbtnCoachesShow
            // 
            this.rbtnCoachesShow.AutoSize = true;
            this.rbtnCoachesShow.Location = new System.Drawing.Point(94, 3);
            this.rbtnCoachesShow.Name = "rbtnCoachesShow";
            this.rbtnCoachesShow.Size = new System.Drawing.Size(69, 19);
            this.rbtnCoachesShow.TabIndex = 26;
            this.rbtnCoachesShow.TabStop = true;
            this.rbtnCoachesShow.Text = "Coaches";
            this.rbtnCoachesShow.UseVisualStyleBackColor = true;
            // 
            // rbtnSwimmersShow
            // 
            this.rbtnSwimmersShow.AutoSize = true;
            this.rbtnSwimmersShow.Checked = true;
            this.rbtnSwimmersShow.Location = new System.Drawing.Point(5, 3);
            this.rbtnSwimmersShow.Name = "rbtnSwimmersShow";
            this.rbtnSwimmersShow.Size = new System.Drawing.Size(83, 19);
            this.rbtnSwimmersShow.TabIndex = 27;
            this.rbtnSwimmersShow.TabStop = true;
            this.rbtnSwimmersShow.Text = "Swimmers";
            this.rbtnSwimmersShow.UseVisualStyleBackColor = true;
            this.rbtnSwimmersShow.CheckedChanged += new System.EventHandler(this.rbtnSwimmersShow_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnSwimmersShow);
            this.panel2.Controls.Add(this.rbtnCoachesShow);
            this.panel2.Location = new System.Drawing.Point(14, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 29);
            this.panel2.TabIndex = 28;
            // 
            // lsbRegistrantsShow
            // 
            this.lsbRegistrantsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.lsbRegistrantsShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbRegistrantsShow.FormattingEnabled = true;
            this.lsbRegistrantsShow.ItemHeight = 15;
            this.lsbRegistrantsShow.Location = new System.Drawing.Point(14, 67);
            this.lsbRegistrantsShow.Name = "lsbRegistrantsShow";
            this.lsbRegistrantsShow.Size = new System.Drawing.Size(186, 152);
            this.lsbRegistrantsShow.TabIndex = 29;
            this.lsbRegistrantsShow.SelectedIndexChanged += new System.EventHandler(this.lsbRegistrantsShow_SelectedIndexChanged);
            // 
            // lblRegistrantInfo
            // 
            this.lblRegistrantInfo.AutoSize = true;
            this.lblRegistrantInfo.Location = new System.Drawing.Point(5, 6);
            this.lblRegistrantInfo.Name = "lblRegistrantInfo";
            this.lblRegistrantInfo.Size = new System.Drawing.Size(0, 15);
            this.lblRegistrantInfo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Load Clubs:";
            // 
            // txtLoadClubs
            // 
            this.txtLoadClubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtLoadClubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoadClubs.Location = new System.Drawing.Point(12, 571);
            this.txtLoadClubs.Name = "txtLoadClubs";
            this.txtLoadClubs.Size = new System.Drawing.Size(215, 23);
            this.txtLoadClubs.TabIndex = 33;
            this.txtLoadClubs.Text = "LoadFiles/Clubs.txt";
            this.txtLoadClubs.DoubleClick += new System.EventHandler(this.txtLoadClubs_DoubleClick);
            // 
            // btnLoadClubs
            // 
            this.btnLoadClubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnLoadClubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadClubs.Location = new System.Drawing.Point(234, 543);
            this.btnLoadClubs.Name = "btnLoadClubs";
            this.btnLoadClubs.Size = new System.Drawing.Size(93, 52);
            this.btnLoadClubs.TabIndex = 34;
            this.btnLoadClubs.Text = "Load Clubs";
            this.btnLoadClubs.UseVisualStyleBackColor = false;
            this.btnLoadClubs.Click += new System.EventHandler(this.btnLoadClubs_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Save Clubs:";
            // 
            // btnSaveClubs
            // 
            this.btnSaveClubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            this.btnSaveClubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClubs.Location = new System.Drawing.Point(598, 543);
            this.btnSaveClubs.Name = "btnSaveClubs";
            this.btnSaveClubs.Size = new System.Drawing.Size(93, 52);
            this.btnSaveClubs.TabIndex = 37;
            this.btnSaveClubs.Text = "Save Clubs";
            this.btnSaveClubs.UseVisualStyleBackColor = false;
            this.btnSaveClubs.Click += new System.EventHandler(this.btnSaveClubs_Click);
            // 
            // txtSaveClubs
            // 
            this.txtSaveClubs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(181)))), ((int)(((byte)(177)))));
            this.txtSaveClubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveClubs.Location = new System.Drawing.Point(376, 571);
            this.txtSaveClubs.Name = "txtSaveClubs";
            this.txtSaveClubs.Size = new System.Drawing.Size(215, 23);
            this.txtSaveClubs.TabIndex = 38;
            this.txtSaveClubs.Text = "SaveFiles/ClubsOut.txt";
            this.txtSaveClubs.DoubleClick += new System.EventHandler(this.txtSaveClubs_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "By Eskender Memetov 300805013 and Vadym Harkusha 300909484";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(607, 607);
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
            this.groupBox1.Controls.Add(this.lblClubAddress);
            this.groupBox1.Controls.Add(this.lblClubName);
            this.groupBox1.Controls.Add(this.lblClubCity);
            this.groupBox1.Controls.Add(this.lblClubProvince);
            this.groupBox1.Controls.Add(this.lblClubZip);
            this.groupBox1.Controls.Add(this.lblClubPhone);
            this.groupBox1.Controls.Add(this.txtClubName);
            this.groupBox1.Controls.Add(this.txtClubAddress);
            this.groupBox1.Controls.Add(this.txtClubCity);
            this.groupBox1.Controls.Add(this.txtClubProvince);
            this.groupBox1.Controls.Add(this.txtClubZip);
            this.groupBox1.Controls.Add(this.txtClubPhone);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 236);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Club: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbClubs);
            this.groupBox2.Location = new System.Drawing.Point(240, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 278);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Clubs: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbRegistrantsAssign);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(478, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 236);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assign: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbRegistrantsShow);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Location = new System.Drawing.Point(240, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 238);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Show: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblClubInfo);
            this.groupBox5.Location = new System.Drawing.Point(12, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 213);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Club information: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel3);
            this.groupBox6.Location = new System.Drawing.Point(478, 324);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 213);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registrant information: ";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lblRegistrantInfo);
            this.panel3.Location = new System.Drawing.Point(6, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 185);
            this.panel3.TabIndex = 55;
            // 
            // FormClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(706, 637);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAssignRegistrant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSaveClubs);
            this.Controls.Add(this.btnSaveClubs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLoadClubs);
            this.Controls.Add(this.txtLoadClubs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddClub);
            this.Controls.Add(this.lblAddClubError);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClubs";
            this.Text = "Club Menu";
            this.Load += new System.EventHandler(this.FormClubs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubAddress;
        private System.Windows.Forms.Label lblClubCity;
        private System.Windows.Forms.Label lblClubProvince;
        private System.Windows.Forms.Label lblClubZip;
        private System.Windows.Forms.Label lblClubPhone;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtClubAddress;
        private System.Windows.Forms.TextBox txtClubCity;
        private System.Windows.Forms.TextBox txtClubProvince;
        private System.Windows.Forms.TextBox txtClubZip;
        private System.Windows.Forms.TextBox txtClubPhone;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Label lblAddClubError;
        private System.Windows.Forms.ListBox lsbClubs;
        private System.Windows.Forms.Label lblClubInfo;
        private System.Windows.Forms.RadioButton rbtnSwimmersAssign;
        private System.Windows.Forms.RadioButton rbtnCoachesAssign;
        private System.Windows.Forms.ListBox lsbRegistrantsAssign;
        private System.Windows.Forms.Button btnAssignRegistrant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCoachesShow;
        private System.Windows.Forms.RadioButton rbtnSwimmersShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lsbRegistrantsShow;
        private System.Windows.Forms.Label lblRegistrantInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoadClubs;
        private System.Windows.Forms.Button btnLoadClubs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveClubs;
        private System.Windows.Forms.TextBox txtSaveClubs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel3;
    }
}