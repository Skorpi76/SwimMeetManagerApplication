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
    public partial class FormCoaches : Form
    {
        private FormMainMenu formMain = new FormMainMenu();
        public List<Coach> Coaches { set; get; }
        public FormCoaches()
        {
            InitializeComponent();

        }

        private void lsbAllCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var coach in Coaches)
            {
                if (coach.Name == lsbAllCoaches.SelectedItem.ToString())
                {
                    lblAboutCoach.Text = CoachGetInfo(coach);
                    break;
                }
            }
        }

        private void btnSubmitAddCoach_Click(object sender, EventArgs e)
        {
            int year;
            int day;
            int month;
            long phoneNumber;
            ValidateNumericalFields(out year, out month, out day, out phoneNumber);
            if (!ValidateNumericalFields(out year, out month, out day, out phoneNumber))
            {
                return;
            }          
             Coach aCoach = new Coach(txtName.Text, new DateTime(year, month, day), new Adress(txtStreet.Text, 
                                                       txtCity.Text, txtProvince.Text, txtPostalCode.Text), phoneNumber);
            aCoach.Credentials = txtCredentials.Text;
            ResetTxtValues();
            Coaches.Add(aCoach);
            formMain.Coaches = this.Coaches;
            lsbAllCoaches.Items.Add(aCoach.Name);
        }

        private void FormCoaches_Load(object sender, EventArgs e)
        {
            foreach (var coach in this.Coaches)
            {
                lsbAllCoaches.Items.Add(coach.Name);
            }
        }


        /// <summary>
        /// Resets all field back to empty values for Add Coach 
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
            txtCredentials.Text = "";
            lblError.Text = "";
        }

        private string CoachGetInfo(Coach aCoach)
        {
            string info = "";
            info += string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
                aCoach.ID, aCoach.Name, aCoach.DOB, aCoach.Address.ToString(), Club.ConvertPhoneNumber(aCoach.PhoneNumber), aCoach.ItsClub != null ? aCoach.ItsClub.Name : "not assigned");
            info += string.Format("\nCredentials: {0}", aCoach.Credentials);
            return info; 
        }
        private bool ValidateNumericalFields(out int year, out int month, out int day, out long phoneNumber)
        {
            year = 0;
            month = 0;
            day = 0;
            phoneNumber = 0;
            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch
            {
                lblError.Text = "Error: Year must be an integer";               
                return false;
            }
            try
            {
                day = Convert.ToInt32(txtDay.Text);
            }
            catch
            {
                lblError.Text = "Error: Day must be an integer";
                return false;
            }
            try
            {
                month = Convert.ToInt32(txtMonth.Text);
            }
            catch
            {
                lblError.Text = "Error: Month must be an integer";
                return false;
            }
            try
            {
                phoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
            }
            catch
            {
                lblError.Text = "Error: PhoneNumber must contain integer numbers only";
                return false;
            }
            return true;
        }
    }
}
