using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimMeetLibrary;
/* Name: Eskender Memetov 
 * Student Number: 300805013 */
namespace Assignment2
{
    class Program
    {
        //-----------

        #region Main Method
        static void Main(string[] args)
        {


           
            IClubsRepository clbMngr = new ClubsManager();
            ISwimmersRepository swmMngr = new SwimmersManager((ClubsManager)clbMngr);

            try
            {
                clbMngr.Load(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            for (int i = 0; i < clbMngr.Number; i++)
            {
                DisplayInfo(i.ToString(), ((ClubsManager)clbMngr).Clubs[i].ToString());
            }


            swmMngr.Load(@"C:\A2\Swimmers.txt", ",");

            for (int i = 0; i < swmMngr.Number; i++)
            {
                DisplayInfo(i.ToString(), ((SwimmersManager)swmMngr).Swimmers[i].ToString());
            }

            // Create 3 swimmers
            Swimmer swimmer1;
            Swimmer swimmer2;
            Swimmer swimmer3;
            CreateSwimmers(out swimmer1, out swimmer2, out swimmer3);

            //Create two clubs
            Club club1;
            Club club2;
            CreateClubs(out club1, out club2);

            //Assigne swimmers to club

            AssigneSwimmersToClubs(swimmer1, swimmer2, swimmer3, club1, club2);



            //New code
            Coach coach1;
            Coach coach2;
            CreateCoaches(out coach1, out coach2);

            AssignCoachesAndSwimmers(coach1, coach2, swimmer1, swimmer2, swimmer3);

            //Create swim meets

            SwimMeet meet1;
            SwimMeet meet2;
            CreateSwimMeets(out meet1, out meet2);

            Event _50free1;
            Event _100fly;
            Event _200breast;
            Event _400free;
            Event _1500free;
            Event _1500free2;
            CreateEvents(out _50free1, out _100fly, out _200breast, out _400free, out _1500free, out _1500free2);

            AddEventsToSwimMeets(meet1, meet2, _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);

            AddSwimmersToEvents(swimmer1, swimmer2, swimmer3, meet1, meet2,
                                _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);

            SeedMeets(meet1, meet2);

            EnterTimesForSwims(swimmer1, swimmer2, swimmer3, meet1, meet2,
                               _50free1, _100fly, _200breast, _400free, _1500free, _1500free2);

            // Console.WriteLine("Best time for SCM 1500  free for swimmer 1 is: {0}", swimmer1.GetBestTime(PoolType.SCM, Stroke.Freestyle, EventDistance._1500).ToString(@"mm\:ss\.ff"));
            // Console.WriteLine("Best time for SCM 1500  free for swimmer 1 is: {0}", swimmer3.GetBestTime(PoolType.SCM, Stroke.Freestyle, EventDistance._1500).ToString(@"mm\:ss\.ff"));

            clbMngr.Add(club1);



            swmMngr.Add(swimmer1);
            swmMngr.Add(swimmer2);
            swmMngr.Add(swimmer3);

            clbMngr.Save("ClubsOut.txt", "|");

            swmMngr.Save("SwimmersOut.txt", "|");



        }
        #endregion



        //------------

        private static void AssignCoachesAndSwimmers(Coach coach1, Coach coach2, Swimmer swimmer1, Swimmer swimmer2, Swimmer swimmer3)
        {

            //coach not registered with the club
            try
            {
                swimmer1.NCoach = coach1;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Coach is not assigned to a club
            try
            {
                coach2.AddSwimmer(swimmer2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            swimmer1.NClub.AddCoach(coach1);

            swimmer2.NClub.AddCoach(coach2);

            //swimmer and the coach not in the same club
            try
            {
                coach2.AddSwimmer(swimmer3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            coach1.AddSwimmer(swimmer1);
            coach1.AddSwimmer(swimmer3);

            swimmer2.NCoach = coach2;

            DisplayInfo("coach 1", coach1.ToString());
            DisplayInfo("coach 2", coach2.ToString());
            DisplayInfo("club1", swimmer1.NClub.ToString());
            DisplayInfo("club2", swimmer2.NClub.ToString());


        }

        private static void CreateCoaches(out Coach coach1, out Coach coach2)
        {
            coach1 = new Coach("John Wisemiler", new DateTime(1950, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            DisplayInfo("coach1", coach1.ToString());



            coach2 = new Coach("Micael Phelps", new DateTime(1975, 6, 30),
                                                    new Adress("5 Queen St", "Boston", "ON", "234567"), 3123123333);
            coach2.Credentials = "NNCA Level 1";
            DisplayInfo("coach2", coach2.ToString());
        }
        #region  CreateClubs Method
        private static void CreateClubs(out Club club1, out Club club2)
        {
            club1 = new Club();
            club1.ClubPhoneNumber = 4164444444;
            club1.ClubName = "NYAC";
            DisplayInfo("club1", club1.ToString());

            club2 = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            DisplayInfo("club2", club2.ToString());
        }
        #endregion

        #region CreateSwimmers Method
        private static void CreateSwimmers(out Swimmer swimmer1, out Swimmer swimmer2, out Swimmer swimmer3)
        {
            swimmer1 = new Swimmer("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            DisplayInfo("swimmer1", swimmer1.ToString());

            swimmer2 = new Swimmer();
            DisplayInfo("swimmer2", swimmer2.ToString());
            swimmer2.RegistrantAdress = new Adress("1 King St", "Toronto", "ON", "M2M 3M3");
            swimmer2.RegistrantName = "John Lee";
            swimmer2.RegistrantPhoneNo = 4162222222;
            swimmer2.RegistrantDateOFBirth = new DateTime(1950, 12, 1);
            DisplayInfo("swimmer2", swimmer2.ToString());

            swimmer3 = new Swimmer("Ann Smith", new DateTime(1975, 1, 1),
                                                    new Adress("5 Queen St", "Toronto", "ON", "M2M 4M4"), 4163333333);
            DisplayInfo("swimmer3", swimmer3.ToString());
        }
        #endregion

        #region AssigneSwimmersToClubs Method
        private static void AssigneSwimmersToClubs(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, Club club1, Club club2)
        {
            Console.WriteLine("*******Adding swimmers to clubs ******\n***********************************");

            club1.AddSwimmer(swimmer1);
            DisplayInfo("club1", club1.ToString());
            DisplayInfo("swimmer1", swimmer1.ToString());

            club2.AddSwimmer(swimmer2);
            DisplayInfo("club2", club2.ToString());
            DisplayInfo("swimmer2", swimmer2.ToString());

            try
            {
                swimmer2.NClub = club1;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                swimmer3.NClub = club1;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            DisplayInfo("swimmer3", swimmer3.ToString());
            DisplayInfo("club1", club1.ToString());
        }
        #endregion

        #region CreateSwimMeets Method
        private static void CreateSwimMeets(out SwimMeet meet1, out SwimMeet meet2)
        {
            Console.WriteLine("*******meets and events ******\n***********************************");
            meet1 = new SwimMeet();
            meet1.NameOfMeet = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;
            DisplayInfo("meet1", meet1.ToString());


            meet2 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.LCM, 2);
            DisplayInfo("meet2", meet2.ToString());
        }
        #endregion

        #region CreateEvents Method
        private static void CreateEvents(out Event _50free1, out Event _100fly, out Event _200breast, out Event _400free, out Event _1500free, out Event _1500free2)
        {
            _50free1 = new Event();
            _50free1.Distance1 = Event.Distance._50;
            _50free1.Value = Event.Stroke.Freestyle;

            _100fly = new Event(Event.Distance._100, Event.Stroke.Butterfly);
            _200breast = new Event(Event.Distance._200, Event.Stroke.Breaststroke);
            _400free = new Event(Event.Distance._400, Event.Stroke.Freestyle);
            _1500free = new Event(Event.Distance._1500, Event.Stroke.Freestyle);
            _1500free2 = new Event(Event.Distance._1500, Event.Stroke.Freestyle);
        }
        #endregion

        #region AddEventsToSwimMeets Method
        private static void AddEventsToSwimMeets(SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            meet1.AddEvent(_50free1);
            meet1.AddEvent(_100fly);
            meet1.AddEvent(_200breast);
            meet1.AddEvent(_1500free2);

            meet2.AddEvent(_400free);
            meet2.AddEvent(_1500free);

            DisplayInfo("meet1", meet1.ToString());
            DisplayInfo("meet2", meet2.ToString());
        }
        #endregion

        #region AddSwimmersToEvents Method
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

            DisplayInfo("meet1", meet1.ToString());
            DisplayInfo("meet2", meet2.ToString());
        }
        #endregion

        #region SeedMeets Method
        private static void SeedMeets(SwimMeet meet1, SwimMeet meet2)
        {
            meet1.Seed();
            meet2.Seed();

            DisplayInfo("meet1", meet1.ToString());
            DisplayInfo("meet2", meet2.ToString());
        }
        #endregion

        #region DisplayInfo Method
        public static void DisplayInfo(string firstLineMessage, string info)
        {
            Console.WriteLine("--{0}---------------------", firstLineMessage);
            Console.WriteLine(info);
            Console.WriteLine("--------------------------\n");
        }
        #endregion

        #region EnterTimesForSwims Method
        private static void EnterTimesForSwims(Registrant swimmer1, Registrant swimmer2, Registrant swimmer3, SwimMeet meet1, SwimMeet meet2, Event _50free1, Event _100fly, Event _200breast, Event _400free, Event _1500free, Event _1500free2)
        {
            Console.WriteLine("********** Adding swim times for swimmers *********");

            _50free1.EnterSwimmersTime(swimmer1, "00:30.13");


            _50free1.EnterSwimmersTime(swimmer1, "00:30.13");
            _50free1.EnterSwimmersTime(swimmer2, "00:28.87");
            _50free1.EnterSwimmersTime(swimmer3, "00:29.54");
     
            _100fly.EnterSwimmersTime(swimmer1, "01:17.23");      
            _100fly.EnterSwimmersTime(swimmer2, "01:05.16");

            _200breast.EnterSwimmersTime(swimmer1, "02:25.23");
            _200breast.EnterSwimmersTime(swimmer3, "02:17.03");

            _400free.EnterSwimmersTime(swimmer2, "04:55.23");

            _1500free.EnterSwimmersTime(swimmer1, "15:17.23");
            _1500free.EnterSwimmersTime(swimmer2, "16:17.23");
            _1500free.EnterSwimmersTime(swimmer3, "17:17.23");

            _1500free2.EnterSwimmersTime(swimmer1, "15:16.23");
            _1500free2.EnterSwimmersTime(swimmer3, "17:18.23");

            try
            {
                _400free.EnterSwimmersTime(swimmer1, "04:55.23");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            DisplayInfo("meet1", meet1.ToString());
            DisplayInfo("meet2", meet2.ToString());
        }
        #endregion
    }
}
