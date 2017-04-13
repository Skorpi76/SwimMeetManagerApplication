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
    public partial class FormMainMenu : Form
    {
        public List<Club> Clubs { set; get; }
        public List<Event> Events { set; get; }
        public List<Swimmer> Swimmers { set; get; }
        public List<Coach> Coaches { set; get; }
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnGoToSwimmers_Click(object sender, EventArgs e)
        {
            FormSwimmers formSwimmers = new FormSwimmers();
            formSwimmers.Swimmers = this.Swimmers;
            formSwimmers.ShowDialog(this);
        }

        private void btnGoToClubs_Click(object sender, EventArgs e)
        {
            FormClubs formClubs = new FormClubs();
            formClubs.Clubs = Clubs;
            formClubs.ShowDialog(this);
        }

        private void btnGoToCoaches_Click(object sender, EventArgs e)
        {
            FormCoaches formCoaches = new FormCoaches();
   
            formCoaches.ShowDialog(this);
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            //Swimmers 
            Swimmers = new List<Swimmer>();
            Swimmers.Add(new Swimmer("Bob Smith", new DateTime(1970, 1, 1),
                                                   new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567));
            Swimmers.Add(new Swimmer("Ann Smith", new DateTime(1980, 2, 5),
                                              new Adress("40 bloor St", "Toronto", "ON", "M2M 2B2"), 4164166415));

            // Coaches 
            Coaches = new List<Coach>();
            Coaches.Add(new Coach("John Wisemiler", new DateTime(1950, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567));
            Coaches.Add(new Coach("Micael Phelps", new DateTime(1975, 6, 30),
                                                    new Adress("5 Queen St", "Boston", "ON", "234567"), 3123123333));
            //Clubs
            Clubs = new List<Club>();
            Club aClub = new Club("Canada Fitness", new Adress("21 Younge St","Toronto","ON","M6J 9O6"),6478304065);
            Club bClub = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            Club cClub = new Club();
            cClub.PhoneNumber = 4164444444;
            cClub.Name = "NYAC";
            Clubs.Add(aClub);
            Clubs.Add(bClub);
            Clubs.Add(cClub);
            //Events
            Events = new List<Event>();
            Event _50free1;
            Event _100fly;
            Event _200breast;
            Event _400free;
            Event _1500free;
            Event _1500free2;
            CreateEvents(out _50free1, out _100fly, out _200breast, out _400free, out _1500free, out _1500free2);
            Events.AddRange(new[] { _50free1, _100fly, _200breast, _400free, _1500free, _1500free2 });
        }

        private void btnGoToEvents_Click(object sender, EventArgs e)
        {
            FormEvent formEvents = new FormEvent();
            formEvents.Events = Events;
            formEvents.ShowDialog(this);
        }












        private static void CreateEvents(out Event _50free1, out Event _100fly, out Event _200breast, out Event _400free, out Event _1500free, out Event _1500free2)
        {
            _50free1 = new Event();
            _50free1.DistanceValue = Event.Distance._50;
            _50free1.StrokeValue = Event.Stroke.Freestyle;

            _100fly = new Event(Event.Distance._100, Event.Stroke.Butterfly);
            _200breast = new Event(Event.Distance._200, Event.Stroke.Breaststroke);
            _400free = new Event(Event.Distance._400, Event.Stroke.Freestyle);
            _1500free = new Event(Event.Distance._1500, Event.Stroke.Freestyle);
            _1500free2 = new Event(Event.Distance._1500, Event.Stroke.Freestyle);
        }
    }
}
