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
        public string NameOfMeet { get; set; }
        public int NoOfLanes { get; set; }
        public int NoOfEvents { get; set; }
        public List<Event> Events { get; set; }

        public SwimMeet(string nameOfMeet, DateTime startDate, DateTime endDate, PoolCourse course, int noOfLanes)
        {
            StartDate = startDate;
            EndDate = endDate;
            NameOfMeet = nameOfMeet;
            NoOfLanes = noOfLanes;
            this.course = course;

            Events = new List<Event>(50);

        }
        public SwimMeet()
        {

            Events = new List<Event>(50);
        }

        public override string ToString()
        {
            string info;
            info = string.Format("Sweem meet name: {2} \nFrom-to:{0} to {1} \nPool type: {3} \nNo lanes: {4}",
                StartDate, EndDate, NameOfMeet, course, NoOfLanes);

            info += "\t\nEvents: ";

            foreach (var item in Events)
            {
                info += string.Format(item.ToString());
            }
            return info;
        }

        public void AddEvent(Event eventN)
        {
            Events.Add(eventN);
            NoOfEvents++;
            eventN.SweeMeets = this;
        }
 
        public void Seed()
        {
            for (int i = 0; i < NoOfEvents; i++)
            {
                int j = 0;
                int heat = 1;
                int lane = 1;         
                foreach (var item in Events[i].Swimmers)
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
    }
}
