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
        public readonly PoolCourse course;    
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Event[] Events { get; set; }
        public string NameOfMeet { get; set; }
        public int NoOfLanes { get; set; }
        public int NoOfEvents { get; set; }

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

      

        #region GetInfo Method
        public override string ToString()
        {
            string info;
            info = string.Format("Sweem meet name: {2} \nFrom-to:{0} to {1} \nPool type: {3} \nNo lanes: {4}",
                StartDate, EndDate, NameOfMeet, course, NoOfLanes);
            int i = 0;
            info += "\t\nEvents: ";
            while (Events[i] != null)
            {
                info += string.Format(Events[i].ToString());
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
            for (int i = 0; i < NoOfEvents; i++)
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
