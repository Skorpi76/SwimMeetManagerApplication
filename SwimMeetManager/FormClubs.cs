using SwimMeetLibrary;
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
        formMainMenu formMain = new formMainMenu();
        public List<Club> Clubs { set; get; }


        public FormClubs()
        {
            InitializeComponent();
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            long phone=0;

            if (Int64.TryParse(txtClubPhone.Text, out phone))
            {
                Club aClub = new Club(txtClubName.Text, new Adress(txtClubAddress.Text, txtClubCity.Text, txtClubProvince.Text, txtClubZip.Text), phone);
                lblAddClubError.Text = "Club "+ txtClubName.Text + " was successfully added";
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

        }

        public void ClubsName(ListBox lsb)
        {
            
        }
    }
}
