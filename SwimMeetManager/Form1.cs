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
    }
}
