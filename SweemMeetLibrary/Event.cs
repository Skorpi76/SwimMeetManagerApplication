using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public class Event
    {
        public enum Distance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500, None };
        public Distance DistanceValue { get; set; }
        public SwimMeet SweeMeets { get; set; }
        public List<Registrant> Swimmers { get; set; }
        public int NoOfSwimers { get; set; }
        public Stroke StrokeValue { get; set; }
        private int noOfSwims;
        public List<Swim> Swims { get; set; }
        public enum Stroke
        {
            Butterfly, Backstroke, Breaststroke, Freestyle,
            Individualmedley, None
        };



        public Event(Distance distance, Stroke value)
        {
            Swimmers = new List<Registrant>(100);
            Swims = new List<Swim>(20);
            DistanceValue = distance;
            StrokeValue = value;


        }

        public Event() : this(Distance.None, Stroke.None)
        {

            Swimmers = new List<Registrant>(100);

            Swims = new List<Swim>(20);
        }

        public override string ToString()
        {
            string info;
            info = string.Format("\n\t{0} {1}", DistanceValue, StrokeValue);
            info += string.Format("\n\tSwimmers: ");
            int i = 0;
            foreach (var swimmers in Swimmers)
            {

                info += string.Format("\n\t{0,-10}", swimmers.Name);

                if (noOfSwims > 0)
                {
                    info += string.Format("\t{0,5}{1}  time: {2}", "H" + Swims[i].Heat, "L" + Swims[i].Lane, Swims[i].TimeSwam != null ? Swims[i].TimeSwam : "no time");
                }
                else
                {
                    info += string.Format("\t\tNot seeded/no swim");
                }
                i++;
            }
            return info;
        }

        public void AddSwimmer(Registrant swimmer)
        {
            int trigger = 1;
            foreach (Registrant aSwimmer in Swimmers)
            {
                if (aSwimmer == swimmer)
                    trigger = 0; ;
            }
            if (trigger == 1)
            {

                Swimmers.Add(swimmer);
                swimmer.ItsEvent = this;

            }
            else
            {
                throw new Exception("Swimmer " + swimmer.Name + ", " + swimmer.ID +" is already entered");
            }
        }

        public void AddSwim()
        {
            Swim swim = new Swim();
            Swims.Add(swim);
            noOfSwims++;
            swim.ItsEvent = this;
        }

        public void EnterSwimmersTime(Registrant registrant, string timeSwam)
        {
            try
            {
                int index = Swimmers.IndexOf(registrant);
                Swims[index].TimeSwam = timeSwam;
            }
            catch
            {
                throw new Exception(string.Format("Seed meets before entering time"));
            }

            Swimmer aswimmer = registrant as Swimmer;
            if (aswimmer != null)
            {
                int min = Int32.Parse(timeSwam.Substring(0, 2));
                int sec = Int32.Parse(timeSwam.Substring(3, 2));
                int miliSec = Int32.Parse(timeSwam.Substring(6, 2)) * 10;         
                TimeSpan currentTime = new TimeSpan(0, 0, min, sec, miliSec);
                if (aswimmer.BestTimeEvent.Count == 0)
                {
                    aswimmer.BestTimeEvent.Add(this);
                    aswimmer.BestTimeTimeSpan.Add(currentTime);
                }                
                bool assigned = false;
                for (int i = 0; i < aswimmer.BestTimeEvent.Count; i++)
                {
                    if (aswimmer.BestTimeEvent[i].StrokeValue == this.StrokeValue && aswimmer.BestTimeEvent[i].DistanceValue == this.DistanceValue && aswimmer.BestTimeEvent[i].SweeMeets.Course == this.SweeMeets.Course)
                    {
           
                        if (TimeSpan.Compare(aswimmer.BestTimeTimeSpan[i], currentTime) == 1)
                        {
                            aswimmer.BestTimeTimeSpan[i] = currentTime;
                        }
                        assigned = false;
                        break;
                    }
                    else if (!assigned)
                    {
                        assigned = true;
                    }
                }
                if (assigned)
                {
                    aswimmer.BestTimeEvent.Add(this);
                    aswimmer.BestTimeTimeSpan.Add(currentTime);
                }
            }
        }    
    }
}