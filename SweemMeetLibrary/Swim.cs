using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
   public class Swim
    {
     
        public int Heat { get; set; }
        public int Lane { get; set; }
        public string TimeSwam { get; set; }
        public Event Events { get; set; }

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


        #region ToString Method
        public override string ToString()
        {
            return string.Format("#Lane#: {0} \n#Heat: {1} \n#TimeSwam: {2}\n/---------------------", Lane, Heat, TimeSwam);
        }
        #endregion
    }
}
