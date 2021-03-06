﻿using SwimMeetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimMeetManager
{
    public partial class FormClubs : Form
    {
        FormMainMenu formMain = new FormMainMenu();
        public List<Club> Clubs { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public List<Coach> Coaches { set; get; }
        ClubsManager clbMngr = new ClubsManager();


        public FormClubs()
        {
            InitializeComponent();
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            long phone = 0;

            if (Int64.TryParse(txtClubPhone.Text, out phone))
            {
                Club aClub = new Club(txtClubName.Text, new Adress(txtClubAddress.Text, txtClubCity.Text, txtClubProvince.Text, txtClubZip.Text), phone);
                lblAddClubError.Text = "Club " + txtClubName.Text + " was successfully added";
                txtClubName.Text = "";
                txtClubAddress.Text = "";
                txtClubCity.Text = "";
                txtClubProvince.Text = "";
                txtClubZip.Text = "";
                txtClubPhone.Text = "";
                Clubs.Add(aClub);
                formMain.Clubs = Clubs;
                lsbClubs.Items.Add(aClub.Name);
            }
            else
                lblAddClubError.Text = "Only number allowded for Phone field";
        }

        private void FormClubs_Load(object sender, EventArgs e)
        {
            foreach (var item in Clubs)
            {
                lsbClubs.Items.Add(item.Name);
            }

            foreach (var item in Swimmers)
            {
                lsbRegistrantsAssign.Items.Add(item.Name);
            }
        }

        public void ClubsName(ListBox lsb)
        {

        }

        private void lsbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lblClubInfo.Text = ReturnObjectClubFrom(lsbClubs, Clubs).ToString();
                lblClubInfo.Text = GetClubInfo(ReturnObjectClubFrom(lsbClubs, Clubs));
            }
            catch
            { }
            DisplayRegistrants();
        }


        private string GetClubInfo(Club aClub)
        {
            return string.Format("\nName: {1} \nAdress: {2} \nPhone number: {3} \nReg number: {0}", aClub.ID, aClub.Name, aClub.Address.ToString(),
                                                                                                        Club.ConvertPhoneNumber(aClub.PhoneNumber));
        }

        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            try
            {
                clbMngr.Load(txtLoadClubs.Text, ",");
                Clubs.AddRange(clbMngr.Clubs);

                foreach (var item in clbMngr.Clubs)
                {
                    lsbClubs.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            try
            {
                clbMngr.Clubs = Clubs;
                clbMngr.Save(txtSaveClubs.Text, "|");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void rbtnSwimmersAssign_CheckedChanged(object sender, EventArgs e)
        {
            lsbRegistrantsAssign.Items.Clear();
            if (rbtnSwimmersAssign.Checked)
            {
                foreach (var item in Swimmers)
                {
                    lsbRegistrantsAssign.Items.Add(item.Name);
                }
            }
            else
            {
                foreach (var item in Coaches)
                {
                    lsbRegistrantsAssign.Items.Add(item.Name);
                }
            }
        }

        private void DisplayRegistrants()
        {
            try
            {
                lsbRegistrantsShow.Items.Clear();
                if (rbtnSwimmersShow.Checked)
                {
                    foreach (var item in ReturnObjectClubFrom(lsbClubs, Clubs).Swimmers)
                    {
                        lsbRegistrantsShow.Items.Add(item.Name);
                    }
                }
                else
                {
                    foreach (var item in ReturnObjectClubFrom(lsbClubs, Clubs).Coaches)
                    {
                        lsbRegistrantsShow.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }

        private void btnAssignRegistrant_Click(object sender, EventArgs e)
        {
            if (rbtnSwimmersAssign.Checked)
            {
                foreach (var item in Swimmers)
                {
                    if (item.Name == lsbRegistrantsAssign.SelectedItem.ToString())
                    {
                        ReturnObjectClubFrom(lsbClubs, Clubs).AddSwimmer(item);
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in Coaches)
                {
                    if (item.Name == lsbRegistrantsAssign.SelectedItem.ToString())
                    {
                        ReturnObjectClubFrom(lsbClubs, Clubs).AddCoach(item);
                        break;
                    }
                }
            }
            lblClubInfo.Text = GetClubInfo(ReturnObjectClubFrom(lsbClubs, Clubs));
            DisplayRegistrants();
        }

        private Club ReturnObjectClubFrom(ListBox lsb, List<Club> clubs)
        {
            Club aClub = null;
            try
            {
                foreach (var item in clubs)
                {
                    if (item.Name == lsb.SelectedItem.ToString())
                        return item;
                }

            }
            catch { }
            return aClub;
        }

        private void rbtnSwimmersShow_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                lsbRegistrantsShow.Items.Clear();
                if (rbtnSwimmersShow.Checked)
                {
                    foreach (var item in ReturnObjectClubFrom(lsbClubs, Clubs).Swimmers)
                    {
                        lsbRegistrantsShow.Items.Add(item.Name);
                    }
                }
                else
                {
                    foreach (var item in ReturnObjectClubFrom(lsbClubs, Clubs).Coaches)
                    {
                        lsbRegistrantsShow.Items.Add(item.Name);
                    }
                }
            }
            catch { }
        }

        private void lsbRegistrantsShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnSwimmersShow.Checked)
                {
                    foreach (var item in Swimmers)
                    {
                        if (item.Name == lsbRegistrantsShow.SelectedItem.ToString())
                        {
                            lblRegistrantInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in Coaches)
                    {
                        if (item.Name == lsbRegistrantsShow.SelectedItem.ToString())
                        {
                            lblRegistrantInfo.Text = item.ToString();
                            break;
                        }
                    }
                }
            }
            catch { }

        }


        private void txtLoadClubs_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtLoadClubs.Text = openFileDialog1.FileName;
        }

        private void txtSaveClubs_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtSaveClubs.Text = saveFileDialog1.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
