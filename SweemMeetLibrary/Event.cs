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
        private Distance distance;
        private SwimMeet sweeMeets;
        private Registrant[] swimmers;
        private int noOfSwimers;
        private Stroke value;
        private int noOfSwims;
        private Swim[] swims;    
        public enum Stroke
        {
            Butterfly, Backstroke, Breaststroke, Freestyle,
            IndividualMedley, None
        };


        #region Constructor | Setting Default values
        public Event(Distance distance, Stroke value)
        {
            swimmers = new Registrant[100];
            swims = new Swim[20];
            Distance1 = distance;
            Value = value;
          
        }

        public Event() : this(Distance.None, Stroke.None)
        {
            swimmers = new Registrant[100];
            swims = new Swim[20];
        }

        #endregion

        #region Properties 
        public SwimMeet SweeMeets
        {
            get
            {
                return sweeMeets;
            }

            set
            {
                sweeMeets = value;
            }
        }

        public Stroke Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Distance Distance1
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public Registrant[] Swimmers
        {
            get
            {
                return swimmers;
            }

            set
            {
                swimmers = value;
            }
        }

        public int NoOfSwimers
        {
            get
            {
                return noOfSwimers;
            }

            set
            {
                noOfSwimers = value;
            }
        }

        public Swim[] Swims
        {
            get
            {
                return swims;
            }

            set
            {
                swims = value;
            }
        }
        #endregion

        #region GetInfo Method
        public string GetInfo()
        {
            string info;
            info = string.Format("\n\t{0} {1}", distance, value);
            int i = 0;
            info += string.Format("\n\tSwimmers: ");
            while (Swimmers[i] != null)         
            {
                info += string.Format("\n\t{0,-10}", Swimmers[i].RegistrantName);

                if (Swims[i] != null)
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
        #endregion

        #region AddSwimmer Method
        public void AddSwimmer(Registrant swimmer)
        {
            if (NoOfSwimers == 0 || Swimmers[NoOfSwimers - 1] != swimmer)
            {
                if (swimmer.NEvent == null || swimmer.NEvent == this)
                {
                    Swimmers[NoOfSwimers] = swimmer;
                    NoOfSwimers++;
                    if (swimmer.NClub == null)
                    {
                        swimmer.NEvent = this;
                    }
                }
            }
            else
            {
               // Console.WriteLine("Swimmer {0} already entered", swimmer.RegistrantName);
                throw new Exception(string.Format("Swimmer {0}, {1} already entered", swimmer.RegistrantName, swimmer.RegistrantID));
            }
        }
        #endregion

        #region AddSwim Method
        public void AddSwim()
        {
            Swim swim = new Swim();
            Swims[noOfSwims++] = swim;
            swim.Events = this; 
        }
        #endregion

        #region EnterSwimmersTime
        public void EnterSwimmersTime(Registrant registrant, string time)
        {
           try {
                int index = Array.IndexOf(Swimmers, registrant);
                Swims[index].TimeSwam = time;
            }
           catch
            { 
                throw new Exception(string.Format("Swimmer has not entered event"));
            }
        }
        #endregion
    }
}
