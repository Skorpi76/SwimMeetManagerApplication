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
    public partial class FormSwimMeet : Form
    {
        public List<SwimMeet> SwimMeets { set; get; }
        public List<Event> SwimEvents { set; get; }
        FormMainMenu formMain = new FormMainMenu();
        public FormSwimMeet()
        {
            InitializeComponent();
        }

        private void FormSwimMeet_Load(object sender, EventArgs e)
        {
            datepickerStart.MinDate=DateTime.Today;
            datepickerEnd.MinDate = DateTime.Today;
            foreach (var item in SwimMeets)
            {
                lsbSwimMeets.Items.Add(item.Name);
            }
            foreach (var item in SwimEvents)
            {
                lstbEvents.Items.Add(item.DistanceValue.ToString()+item.StrokeValue.ToString());
            }
        }

        private void btnAddSwimMeet_Click(object sender, EventArgs e)
        {
            int noOfLanes = 0;
            if (Int32.TryParse(txtNumberOfLanes.Text, out noOfLanes))
            {
                SwimMeet.PoolCourse courseValue;
                switch (lsbCourse.SelectedIndex)
                {
                    case 0:
                        courseValue = SwimMeet.PoolCourse.SCM;
                        break;
                    case 1:
                        courseValue = SwimMeet.PoolCourse.SCY;
                        break;
                    case 2:
                        courseValue = SwimMeet.PoolCourse.LCM;
                        break;
                    default:
                        courseValue = SwimMeet.PoolCourse.SCM;
                        break;
                }
                SwimMeet aSwimMeet = new SwimMeet(txtName.Text, datepickerStart.Value.Date, datepickerEnd.Value.Date, courseValue, noOfLanes);
                SwimMeets.Add(aSwimMeet);
                formMain.SwimMeets = SwimMeets;
                lsbSwimMeets.Items.Add(aSwimMeet.Name);
                txtName.Clear();
                txtNumberOfLanes.Clear();
                lblError.Text = "";
            }
            else if(datepickerStart.Value > datepickerEnd.Value)
                lblError.Text = "End date should be later than start date";
            else
                lblError.Text = "Number of lanes should be integer";
        }

        private void lsbSwimMeets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            SwimMeets[lsbSwimMeets.SelectedIndex].Seed();
            ShowInfo();
        }

        private void btnAssignEvent_Click(object sender, EventArgs e)
        {
            SwimMeets[lsbSwimMeets.SelectedIndex].AddEvent(SwimEvents[lstbEvents.SelectedIndex]);
            ShowInfo();
        }

        private void ShowInfo()
        {
            try
            {
                lblInfo.Text = SwimMeets[lsbSwimMeets.SelectedIndex].ToString();
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
