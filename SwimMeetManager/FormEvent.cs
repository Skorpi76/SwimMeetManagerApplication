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
    public partial class FormEvent : Form
    {
        FormMainMenu formMain = new FormMainMenu();
        public List<Event> Events { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public FormEvent()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Event.Distance distanceValue;
            switch (lsbDistance.SelectedIndex)
            {
                case 0:
                    distanceValue = Event.Distance._50;
                    break;
                case 1:
                    distanceValue = Event.Distance._100;
                    break;
                case 2:
                    distanceValue = Event.Distance._200;
                    break;
                case 3:
                    distanceValue = Event.Distance._400;
                    break;
                case 4:
                    distanceValue = Event.Distance._800;
                    break;
                case 5:
                    distanceValue = Event.Distance._1500;
                    break;
                default:
                    distanceValue = Event.Distance.None;
                    break;
            }

            Event.Stroke strokeValue;
            switch (lsbStroke.SelectedIndex)
            {
                case 0:
                    strokeValue = Event.Stroke.Butterfly;
                    break;
                case 1:
                    strokeValue = Event.Stroke.Backstroke;
                    break;
                case 2:
                    strokeValue = Event.Stroke.Breaststroke;
                    break;
                case 3:
                    strokeValue = Event.Stroke.Freestyle;
                    break;
                case 4:
                    strokeValue = Event.Stroke.Individualmedley;
                    break;
                default:
                    strokeValue = Event.Stroke.None;
                    break;
            }

            Event aEvent = new Event(distanceValue,strokeValue);
            Events.Add(aEvent);
            formMain.Events = Events;
            lsbEvents.Items.Add(aEvent.DistanceValue.ToString() + " " + aEvent.StrokeValue.ToString());
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            foreach (var item in Events)
            {
                lsbEvents.Items.Add(item.DistanceValue.ToString()+" "+item.StrokeValue.ToString());
            }
            foreach (var item in Swimmers)
            {
                lsbSwimmers.Items.Add(item.Name);
            }
        }

        private void btnAssignSwimmer_Click(object sender, EventArgs e)
        {
            Events[lsbEvents.SelectedIndex].AddSwimmer(Swimmers[lsbSwimmers.SelectedIndex]);
            lblInfo.Text = Events[lsbEvents.SelectedIndex].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text= Events[lsbEvents.SelectedIndex].ToString();
        }

        private void btnnAddTime_Click(object sender, EventArgs e)
        {
            try
            {
                Events[lsbEvents.SelectedIndex].EnterSwimmersTime(Swimmers[lsbSwimmers.SelectedIndex], txtMinutes.Text + ":" +
                    txtSeconds.Text + "." + txtMiliSeconds.Text);
                txtMiliSeconds.Clear();
                txtSeconds.Clear();
                txtMinutes.Clear();
                lblErrorAddTime.Text="";
            }
            catch (Exception ex)
            {
                lblErrorAddTime.Text = ex.Message;
            }
            lblInfo.Text = Events[lsbEvents.SelectedIndex].ToString();
        }
    }
}
