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
        public List<Swimmer> Swimmers { set; get; }

        // ============================

        public FormCoaches()
        {
            InitializeComponent();

        }

        // ============================

        private void lsbAllCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var coach in Coaches)
            {
                try
                {
                    if (coach.Name == lsbAllCoaches.SelectedItem.ToString())
                    {
                        lblAboutCoach.Text = CoachGetInfo(coach);
                        break;
                    }
                }
                catch
                {

                }
            }

            DisplayRegistrants();
        }

        // ============================

        private void DisplayRegistrants()
        {
            try
            {
                lsbRegistrantsShow.Items.Clear();
                foreach (var item in ReturnObjectCoachForm(lsbAllCoaches, Coaches).Swimmers)
                {
                    lsbRegistrantsShow.Items.Add(item.Name);
                }
            }
            catch { }
        }

        // ============================

        private Coach ReturnObjectCoachForm(ListBox lsb, List<Coach> coaches)
        {
            Coach aCoach = null;
            try
            {
                foreach (var item in coaches)
                {
                    if (item.Name == lsb.SelectedItem.ToString())
                        return item;
                }

            }
            catch { }
            return aCoach;
        }

        // ============================

        private void btnSubmitAddCoach_Click(object sender, EventArgs e)
        {
             
            long phoneNumber;
            try
            {
                phoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
            }
            catch
            {
                MessageBox.Show("Error: PhoneNumber must contain integer numbers only");
                return;
            }
            Coach aCoach = new Coach(txtName.Text, new DateTime(datepickerDOB.Value.Year, datepickerDOB.Value.Month, datepickerDOB.Value.Day), new Adress(txtStreet.Text, 
                                                       txtCity.Text, txtProvince.Text, txtPostalCode.Text), phoneNumber);
            aCoach.Credentials = txtCredentials.Text;
            ResetTxtValues();
            Coaches.Add(aCoach);
            formMain.Coaches = this.Coaches;
            lsbAllCoaches.Items.Add(aCoach.Name);
            MessageBox.Show("A coach was created successfully");
        }

        // ============================

        private void FormCoaches_Load(object sender, EventArgs e)
        {
            foreach (var coach in this.Coaches)
            {
                lsbAllCoaches.Items.Add(coach.Name);
            }
            foreach (var item in Swimmers)
            {
                lsbRegistrantsAssign.Items.Add(item.Name);
            }
        }

        // ============================
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
            txtPhoneNumber.Text = "";
            txtCredentials.Text = "";
            lblError.Text = "";
        }

        // ============================

        private string CoachGetInfo(Coach aCoach)
        {
            string info = "";
            info += string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
                aCoach.ID, aCoach.Name, aCoach.DOB, aCoach.Address.ToString(), Club.ConvertPhoneNumber(aCoach.PhoneNumber), aCoach.ItsClub != null ? aCoach.ItsClub.Name : "not assigned");
            info += string.Format("\nCredentials: {0}", aCoach.Credentials);
            return info; 
        }

        // ============================

        private void btnAssignRegistrant_Click(object sender, EventArgs e)
        {
            try
            {
                Coaches[lsbAllCoaches.SelectedIndex].AddSwimmer(Swimmers[lsbRegistrantsAssign.SelectedIndex]);
                //Swimmers[lsbRegistrantsAssign.SelectedIndex].ItsCoach = Coaches[lsbAllCoaches.SelectedIndex];
                DisplayRegistrants();
                MessageBox.Show("A swimmer has been assigned successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        // ============================

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
