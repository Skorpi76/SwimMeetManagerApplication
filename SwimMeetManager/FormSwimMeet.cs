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
        public List<Event> Events { set; get; }
        public FormSwimMeet()
        {
            InitializeComponent();
        }

        private void FormSwimMeet_Load(object sender, EventArgs e)
        {
            datepickerStart.MinDate=DateTime.Today;
            datepickerEnd.MinDate = DateTime.Today;
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
                SwimMeet aSwimMeet = new SwimMeet(txtName.Text, datepickerStart.Value, datepickerEnd.Value, courseValue, noOfLanes);
                txtName.Clear();
                txtNumberOfLanes.Clear();
            }
            else if(datepickerStart.Value > datepickerEnd.Value)
                lblError.Text = "End date should be later than start date";
            else
                lblError.Text = "Number of lanes should be integer";

        }
    }
}
