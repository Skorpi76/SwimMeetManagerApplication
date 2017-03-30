using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public class Swimmer : Registrant
    {
        //private DateTime bestTimeSCY;
        //private DateTime bestTSCM;
        //private DateTime bestTLCM;
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
                    throw new Exception (string.Format("Coach is not assigned to the club"));
                   
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
        }
        public Swimmer()
        {
        }

        //public TimeSpan GetBestTime(Event.Stroke stroke, Event.Distance distance, SwimMeet.PoolCourse course)
        //{

        //    return;
        //}

        //public AddAsBestTime(TimeSpan bestTime)
        //{

        //}

        public override string ToString()
        {
            string info;
            info = base.ToString() + string.Format("\n Coached By {0} ", NCoach != null ? NCoach.RegistrantName : "not assigned");
            return info;
        }

    }
}
