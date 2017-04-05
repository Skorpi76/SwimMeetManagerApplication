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
        public Distance Distance1 { get; set; }
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
            Distance1 = distance;
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
            info = string.Format("\n\t{0} {1}", Distance1, StrokeValue);
            info += string.Format("\n\tSwimmers: ");
            int i = 0;
            foreach (var swimmers in Swimmers)
            {

                info += string.Format("\n\t{0,-10}", swimmers.RegistrantName);

                if (noOfSwims > 0)
                {
                    info += string.Format("\t{0,5}{1}  time: {2}", "H" + Swims[i].Heat, "L" + Swims[i].Lane, Swims[i].TimeSwam != null ? Swims[i].TimeSwam : "no time");
                }
                else
                {
                    info += string.Format("\n\t\tNot seeded/no swim");
                }
                i++;



            }

         
            return info;
        }

        public void AddSwimmer(Registrant swimmer)
        {
            if (NoOfSwimers == 0 || Swimmers[NoOfSwimers - 1] != swimmer)
            {
                if (swimmer.NEvent == null || swimmer.NEvent == this)
                {
                    Swimmers.Add(swimmer);
                    NoOfSwimers++;
                    if (swimmer.NClub == null)
                    {
                        swimmer.NEvent = this;
                    }
                }
            }
            else
            {

                throw new Exception(string.Format("Swimmer {0}, {1} already entered", swimmer.RegistrantName, swimmer.RegistrantID));
            }
        }

        public void AddSwim()
        {
            Swim swim = new Swim();

            Swims.Add(swim);
            noOfSwims++;
            swim.Events = this;
        }

        public void EnterSwimmersTime(Registrant registrant, string time)
        {
            try
            {
                int index = Swimmers.IndexOf(registrant);
                Swims[index].TimeSwam = time;
            }
            catch
            {
                throw new Exception(string.Format("Swimmer has not entered event"));
            }

            Swimmer swimmer = registrant as Swimmer;
            if (swimmer != null)
            {
                TimeSpan newTime = StringToTimeSpan(time);

                string thisTimeValue = SweeMeets.course + "|" + Distance1 + "|" + StrokeValue + "|" + time;
               

                if (swimmer.BestTimes.Count == 0)
                    swimmer.BestTimes.Add(thisTimeValue);

                int trigger = 0;
                for (int i = 0; i < swimmer.BestTimes.Count; i++)
                {
                    if (swimmer.BestTimes[i].Contains(SweeMeets.course.ToString()) && swimmer.BestTimes[i].Contains(Distance1.ToString()) && swimmer.BestTimes[i].Contains(StrokeValue.ToString()))
                    {
                        string thisTime = swimmer.BestTimes[i].Substring(swimmer.BestTimes[i].LastIndexOf('|') + 1, 8);
                        TimeSpan previousTime = StringToTimeSpan(thisTime);
                        if (TimeSpan.Compare(previousTime, newTime) == 1)
                        {
                            swimmer.BestTimes[i] = thisTimeValue;
                        }
                        trigger = 0;
                        break;
                    }
                    else if (trigger == 0)
                    {
                        trigger = -1;
                    }
                }
                if (trigger == -1)
                    swimmer.BestTimes.Add(thisTimeValue);
            }
        }
        public static TimeSpan StringToTimeSpan(string time)
        {
            int minutes = Int32.Parse(time.Substring(0, 2));
            int seconds = Int32.Parse(time.Substring(3, 2));
            int milliseconds = Int32.Parse(time.Substring(6, 2));
            TimeSpan newTime = new TimeSpan(0, 0, minutes, seconds, milliseconds * 10);
            return newTime;
        }
    }
}

