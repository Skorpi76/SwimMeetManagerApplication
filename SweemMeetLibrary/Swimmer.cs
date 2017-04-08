using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public class Swimmer : Registrant
    {
        private Coach itsCoach;
        public List<TimeSpan> BestTimeTimeSpan { set; get; }
        public List<Event> BestTimeEvent { set; get; }

        public Swimmer(string registrantName, DateTime registrantDateOFBirth, Adress PhysicalLocation, long registrantPhoneNo) : base(registrantName, registrantDateOFBirth, PhysicalLocation, registrantPhoneNo)
        {
            BestTimeTimeSpan = new List<TimeSpan>();
            BestTimeEvent = new List<Event>();
        }
        public Swimmer()
        {
            BestTimeTimeSpan = new List<TimeSpan>();
            BestTimeEvent = new List<Event>();
        }

        public Coach ItsCoach
        {
            get
            {
                return itsCoach;
            }
            set
            {

                if (value.ItsClub == null)
                {
                    throw new Exception(string.Format("Coach is not assigned to the club"));

                }
                if (value.ItsClub != ItsClub && value.ItsClub != null)
                {
                    throw new Exception("Coach and swimmer are not in the same club");

                }
                if (ItsClub == value.ItsClub && !value.Swimmers.Contains(this))
                {

                    itsCoach = value;
                    value.AddSwimmer(this);
                }


            }
        }

        public TimeSpan GetBestTime(SwimMeet.PoolCourse course, Event.Stroke stroke, Event.Distance distance)
        {
            TimeSpan time = TimeSpan.Zero;
            for (int i = 0; i < BestTimeEvent.Count; i++)
            {
                if (BestTimeEvent[i].StrokeValue == stroke && BestTimeEvent[i].DistanceValue == distance && BestTimeEvent[i].SweeMeets.Course == course)
                {
                    time = BestTimeTimeSpan[i];
                }
            }
            return time;
        }

        public void AddAsBestTime(SwimMeet.PoolCourse course, Event.Stroke stroke, Event.Distance distance, TimeSpan time)
        {
            for (int i = 0; i < BestTimeEvent.Count; i++)
            {
                if (BestTimeEvent[i].StrokeValue == stroke && BestTimeEvent[i].DistanceValue == distance && BestTimeEvent[i].SweeMeets.Course == course)
                {
                    if (TimeSpan.Compare(BestTimeTimeSpan[i], time) == 1)
                    {
                        BestTimeTimeSpan[i] = time;
                    }
                }
            }
        }

        public override string ToString()
        {
            string info;
            info = base.ToString() + string.Format("\nCoache: {0} ", ItsCoach != null ? ItsCoach.Name : "not assigned");
            return info;
        }

    }
}
