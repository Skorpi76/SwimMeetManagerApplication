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
    public partial class FormSwimmers : Form
    {
        private FormMainMenu formMain = new FormMainMenu();
        public List<Swimmer> Swimmers { set; get; }
        public FormSwimmers()
        {
            InitializeComponent();
        }

        private void btnSubmitAddSwimmer_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            long phoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
            Swimmer aSwimmer = new Swimmer(txtName.Text, new DateTime(year, month, day), new Adress(txtStreet.Text, txtCity.Text,  txtProvince.Text, txtPostalCode.Text), phoneNumber);
            formMain.Swimmers = Swimmers;
            lsbAllSwimmers.Items.Add(aSwimmer);
            //  label1.Text = aSwimmer.ToString();
            //label1.Text = MainForm.Swimmers[0].ToString();
        }

        private void FormSwimmers_Load(object sender, EventArgs e)
        {
           // MainForm = new formMainMenu();
        }
    }
}
