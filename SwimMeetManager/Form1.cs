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
    public partial class formMainMenu : Form
    {
        public List<Club> Clubs { set; get; }
        public formMainMenu()
        {
            InitializeComponent();
        }

        private void btnGoToSwimmers_Click(object sender, EventArgs e)
        {
            FormSwimmers formSwimmers = new FormSwimmers();
            formSwimmers.ShowDialog(this);
        }

        private void btnGoToClubs_Click(object sender, EventArgs e)
        {
            FormClubs formClubs = new FormClubs();
            formClubs.Clubs = Clubs;
            formClubs.ShowDialog(this);
        }

        private void btnGoToCoaches_Click(object sender, EventArgs e)
        {
            FormCoaches formCoaches = new FormCoaches();
            formCoaches.ShowDialog(this);
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            Clubs = new List<Club>();
            Club aClub = new Club("Canada Fitness", new Adress("21 Younge St","Toronto","ON","M6J 9O6"),1234567890);
            Club bClub = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            Clubs.Add(aClub);
            Clubs.Add(bClub);
        }
    }
}
