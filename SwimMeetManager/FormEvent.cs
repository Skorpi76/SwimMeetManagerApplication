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
            foreach (var itemS in Swimmers)
            {
                if (lsbSwimmers.SelectedItem.ToString() == itemS.Name)
                {
                    foreach (var itemE in Events)
                    {
                        if ((itemE.StrokeValue.ToString() + " " + itemE.StrokeValue.ToString()) == lsbEvents.SelectedItem.ToString())
                        {
                            itemE.AddSwimmer(itemS);
                            break;
                        }
                    }
                }
            }
        }
    }
}
