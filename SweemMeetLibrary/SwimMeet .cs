using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
   public class SwimMeet
    {
        public enum PoolCourse { SCM, SCY, LCM };
        private DateTime startDate;
        private DateTime endDate;
        private string nameOfMeet;
        private int noOfLanes;
        private int noOfEvents;
        public readonly PoolCourse course;
        private Event[] events;

        #region Constructor | Setting Default values
        public SwimMeet(string nameOfMeet, DateTime startDate, DateTime endDate, PoolCourse course, int noOfLanes)
        {
            StartDate = startDate;
            EndDate = endDate;
            NameOfMeet = nameOfMeet;
            NoOfLanes = noOfLanes;
            this.course = course;
            Events = new Event[50];

        }
        public SwimMeet()
        {
            Events = new Event[50];
        }
        #endregion

        #region SwimMeet Properties
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public string NameOfMeet
        {
            get
            {
                return nameOfMeet;
            }
            set
            {

                nameOfMeet = value;
            }
        }

        public int NoOfLanes
        {
            get
            {
                return noOfLanes;
            }

            set
            {
                noOfLanes = value;
            }
        }

        public Event[] Events
        {
            get
            {
                return events;
            }

            set
            {
                events = value;
            }
        }

        public int NoOfEvents
        {
            get
            {
                return noOfEvents;
            }

            set
            {
                noOfEvents = value;
            }
        }
        #endregion

        #region GetInfo Method
        public string GetInfo()
        {
            string info;
            info = string.Format("Sweem meet name: {2} \nFrom-to:{0} to {1} \nPool type: {3} \nNo lanes: {4}",
                StartDate, EndDate, NameOfMeet, course, NoOfLanes);
            int i = 0;
            info += "\t\nEvents: ";
            while (Events[i] != null)
            {
                info += string.Format(Events[i].GetInfo());
                i++;
            }
            return info;
        }
        #endregion

        #region AddEvent Method
        public void AddEvent(Event eventN)
        {
            Events[NoOfEvents++] = eventN;
            eventN.SweeMeets = this;
        }
        #endregion

        #region Seed Method
        public void Seed()
        {
            for (int i = 0; i < noOfEvents; i++)
            {
                int j = 0;
                int heat = 1;
                int lane = 1;
                while (Events[i].Swimmers[j] != null)
                {
                    Events[i].AddSwim();

                    if (lane <= NoOfLanes)
                    {
                        Events[i].Swims[j].Lane = lane;
                        Events[i].Swims[j].Heat = heat;
                        lane++;
                    }
                    else
                    {
                        lane = 1;
                        heat++;
                        Events[i].Swims[j].Lane = lane;
                        Events[i].Swims[j].Heat = heat;
                    }
                    j++;
                }


            }
        }
        #endregion
    }
}
