using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
   public class Swim
    {
        private string timeSwam;
        private int heat;
        private int lane;
        private Event events;

        #region Constructor | Setting Default values
        public Swim(int lane, int heat, string timeSwam)
        {
            Lane = lane;
            Heat = heat;
            TimeSwam = timeSwam;

        }
        public Swim()
        {

        }
        #endregion

        #region Swim Properties
        public int Heat
        {
            get
            {
                return heat;
            }
            set
            {
                heat = value;
            }
        }
        public int Lane
        {
            get
            {
                return lane;
            }
            set
            {
                lane = value;
            }
        }
        public string TimeSwam
        {
            get
            {
                return timeSwam;
            }
            set
            {
                timeSwam = value;
            }
        }

        public Event Events
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
        #endregion

        #region GetInfo Method
        public string GetInfo()
        {
            return string.Format("#Lane#: {0} \n#Heat: {1} \n#TimeSwam: {2}\n/---------------------", Lane, Heat, TimeSwam);
        }
        #endregion
    }
}
