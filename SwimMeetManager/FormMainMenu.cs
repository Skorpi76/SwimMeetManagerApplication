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
        public List<SwimMeet> SwimMeets { set; get; }
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
            formClubs.Swimmers = Swimmers;
            formClubs.Clubs = Clubs;
            formClubs.Coaches = Coaches;
            formClubs.ShowDialog(this);
        }

        private void btnGoToCoaches_Click(object sender, EventArgs e)
        {
            FormCoaches formCoaches = new FormCoaches();
            formCoaches.Coaches = this.Coaches;
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
            Clubs.AddRange(new[] { aClub, bClub, cClub });
            //SwimMeet
            SwimMeets = new List<SwimMeet>();
            SwimMeet meet1;
            SwimMeet meet2;
            CreateSwimMeets(out meet1, out meet2);
            SwimMeets.AddRange(new[] { meet1, meet2 });
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
            AddEventsToSwimMeets(meet1, meet2, _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);

            //AddSwimmersToEvents(swimmer1, swimmer2, swimmer3, meet1, meet2,
            //                    _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);
        }
        private void gtnGoToSwimMeets_Click(object sender, EventArgs e)
        {
            FormSwimMeet formSwimMeet = new FormSwimMeet();
            formSwimMeet.SwimMeets = SwimMeets;
            formSwimMeet.ShowDialog(this);
        }

        private void btnGoToEvents_Click(object sender, EventArgs e)
        {
            FormEvent formEvents = new FormEvent();
            formEvents.Events = Events;
            formEvents.ShowDialog(this);
        }

        private static void CreateSwimMeets(out SwimMeet meet1, out SwimMeet meet2)
        {
            meet1 = new SwimMeet();
            meet1.Name = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet2 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.SCM, 2);
        }

        private static void AddEventsToSwimMeets(SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            meet1.AddEvent(_50free1);
            meet1.AddEvent(_100fly);
            meet1.AddEvent(_200breast);
            meet1.AddEvent(_1500free2);

            meet2.AddEvent(_400free);
            meet2.AddEvent(_1500free);
        }


        private static void AddSwimmersToEvents(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            //Add swimmers to event
            _50free1.AddSwimmer(swimmer1);
            _50free1.AddSwimmer(swimmer2);
            _50free1.AddSwimmer(swimmer3);
            try
            {
                _50free1.AddSwimmer(swimmer3);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            _100fly.AddSwimmer(swimmer1);
            _100fly.AddSwimmer(swimmer2);

            _200breast.AddSwimmer(swimmer1);
            _200breast.AddSwimmer(swimmer2);
            _200breast.AddSwimmer(swimmer3);

            _400free.AddSwimmer(swimmer2);

            _1500free.AddSwimmer(swimmer1);
            _1500free.AddSwimmer(swimmer2);
            _1500free.AddSwimmer(swimmer3);

            _1500free2.AddSwimmer(swimmer1);
            _1500free2.AddSwimmer(swimmer3);
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
