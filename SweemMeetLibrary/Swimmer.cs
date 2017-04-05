using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public class Swimmer : Registrant
    {

        public List<String> BestTimes { get; set;}
        private Coach coach;


        public Coach NCoach
        {
            get
            {
                return coach;
            }
            set
            {

                if (value.NClub == null)
                {
                    throw new Exception(string.Format("Coach is not assigned to the club"));

                }
                if (value.NClub != NClub && value.NClub != null)
                {
                    throw new Exception("Coach and swimmer are not in the same club");

                }
                if (NClub == value.NClub && !value.Swimmers.Contains(this))
                {

                    coach = value;
                    value.AddSwimmer(this);
                }


            }
        }

        public Swimmer(string registrantName, DateTime registrantDateOFBirth, Adress PhysicalLocation, long registrantPhoneNo) : base(registrantName, registrantDateOFBirth, PhysicalLocation, registrantPhoneNo)
        {
            BestTimes = new List<String>();
        }
        public Swimmer()
        {
            BestTimes = new List<String>();
        }

        public TimeSpan GetBestTime(SwimMeet.PoolCourse course, Event.Stroke stroke, Event.Distance distance)
        {
            TimeSpan time = TimeSpan.Zero;
            foreach (string item in BestTimes)
            {
                
                if (item.Contains(course.ToString()) && item.Contains(stroke.ToString()) && item.Contains(distance.ToString()))
                {
                    string stringTime = item.Substring(item.LastIndexOf('|') + 1, 8);
                    time = Event.StringToTimeSpan(stringTime);
                }
            }
            return time;       
        }

        //public void AddAsBestTime(SwimMeet.PoolCourse course, Event.Stroke stroke, Event.Distance distance, TimeSpan givenTime)
        //{
        //    foreach (string item in BestTimes)
        //    {
        //        if (item.Contains(course.ToString()) && item.Contains(stroke.ToString()) && item.Contains(distance.ToString()))
        //        {
        //            string stringTime = item.Substring(item.LastIndexOf('|') + 1, 8);
        //            TimeSpan thisTime = Event.StringToTimeSpan(stringTime);

        //            if (TimeSpan.Compare(thisTime, givenTime) == 1)
        //            {

        //                item.Replace(thisTime.ToString(), givenTime.ToString());
        //                Console.WriteLine(thisTime);
        //                Console.WriteLine(givenTime);
        //                Console.WriteLine(item);
        //            }
        //        }
        //    }
        //}

        public void AddAsBestTime(SwimMeet.PoolCourse course, Event.Stroke stroke, Event.Distance distance, TimeSpan givenTime)
        {
            string newItem = "";
            string thisItem = "";
            foreach (string item in BestTimes)
            {
                if (item.Contains(course.ToString()) && item.Contains(stroke.ToString()) && item.Contains(distance.ToString()))
                {

                    string stringTime = item.Substring(item.LastIndexOf('|') + 1, 8);
                    TimeSpan thisTime = Event.StringToTimeSpan(stringTime);
                    if (TimeSpan.Compare(thisTime, givenTime) == 1)
                    {
                        newItem = item.Replace(thisTime.ToString().Substring(3, 8), givenTime.ToString().Substring(3, 8));                    
                        thisItem = item;
                        break;
                    }
                }
            }
            if (newItem != "")
                BestTimes[BestTimes.IndexOf(thisItem)] = newItem;


        }

        public override string ToString()
        {
            string info;
            info = base.ToString() + string.Format("\n Coached By {0} ", NCoach != null ? NCoach.RegistrantName : "not assigned");
            return info;
        }

    }
}
