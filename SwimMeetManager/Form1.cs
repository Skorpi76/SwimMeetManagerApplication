using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimMeetLibrary;
namespace SwimMeetManager
{
    public partial class formMainMenu : Form
    {
        public List<Swimmer> Swimmers { set; get; }
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
            formClubs.ShowDialog(this);
        }

        private void btnGoToCoaches_Click(object sender, EventArgs e)
        {
            FormCoaches formCoaches = new FormCoaches();
            formCoaches.ShowDialog(this);
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            Swimmers = new List<Swimmer>();
        }
    }
}
