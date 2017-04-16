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
        ClubsManager clbMngr;
        SwimmersManager swmMngr;

        public FormSwimmers()
        {
            InitializeComponent();
        }

        private void btnSubmitAddSwimmer_Click(object sender, EventArgs e)
        {
            int year = 0;
            int day = 0;
            int month = 0;
            long phoneNumber;
            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch
            {
                lblError.Text = "Error: Year must be an integer";
                return;
            }
            try
            {
                day = Convert.ToInt32(txtDay.Text);
            }
            catch
            {
                lblError.Text = "Error: Day must be an integer";
                return;
            }
            try
            {
                month = Convert.ToInt32(txtMonth.Text);
            }
            catch
            {
                lblError.Text = "Error: Month must be an integer";
                return;
            }
            try
            {
                phoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
            }
            catch
            {
                lblError.Text = "Error: PhoneNumber must contain integer numbers only";
                return;
            }
            Swimmer aSwimmer = new Swimmer(txtName.Text, new DateTime(year, month, day), new Adress(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text), phoneNumber);
            ResetTxtValues();
            Swimmers.Add(aSwimmer);
            formMain.Swimmers = Swimmers;
            lsbAllSwimmers.Items.Add(aSwimmer.Name);

        }

        private void FormSwimmers_Load(object sender, EventArgs e)
        {
            foreach (var swimmer in this.Swimmers)
            {
                lsbAllSwimmers.Items.Add(swimmer.Name);
            }
        }



        /// <summary>
        /// Resets all field back to empty values for Add Swimmer 
        /// </summary>
        private void ResetTxtValues()
        {
            txtName.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPostalCode.Text = "";
            txtYear.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void lsbAllSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var swimer in Swimmers)
            {
                if (swimer.Name == lsbAllSwimmers.SelectedItem.ToString())
                {
                    lblAboutStudent.Text = swimer.ToString();
                    break;
                }
            }
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            clbMngr = new ClubsManager();
            swmMngr = new SwimmersManager(clbMngr);
            try
            {
                swmMngr.Load(txtLoadSwimmers.Text, ",");                         
            }
            catch (Exception ex)
            {              
               lblError.Text = ex.ToString();
            }        
            foreach (var item in swmMngr.Swimmers)
            {
                Swimmer aswimmer = new Swimmer(item.Name, item.DOB, item.Address, item.PhoneNumber);
                Swimmers.Add(aswimmer);
                lsbAllSwimmers.Items.Add(aswimmer.Name);
            }
         
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            clbMngr = new ClubsManager();
            swmMngr = new SwimmersManager(clbMngr);
            swmMngr.Swimmers.Clear();
           List<Registrant> registrants = new List<Registrant>();
            foreach (var item in Swimmers)
            {
                Registrant aswimmer = new Registrant(item.Name, item.DOB, item.Address, item.PhoneNumber);
                swmMngr.Swimmers.Add(aswimmer);
                lblError.Text += aswimmer.Name;
            }
            //lblError.Text = swmMngr.Swimmers.Count.ToString();
            swmMngr.Save(txtSaveSwimmers.Text, "|");
         
        }

        private void txtLoadSwimmers_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtLoadSwimmers.Text = openFileDialog1.FileName;
        }

        private void txtSaveSwimmers_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtSaveSwimmers.Text = saveFileDialog1.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
