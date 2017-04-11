using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Eskender Memetov 
* Student Number: 300805013 */

namespace SwimMeetLibrary
{
    public class Club
    {
        private static int clubNumber;
        public int ID { set; get; }
        public long PhoneNumber { get; set; }
        public string Name { get; set; }
        public Adress Address { get; set; }
        public List<Registrant> Swimmers { get; set; }
        public List<Coach> Coaches { get; set; }
        public int NumberOfSwimmers { get; set; }



        #region Constructor | Setting Default values
        public Club(string clubName, Adress PhysicalLocation, long clubPhoneNumber)
        {
            Name = clubName;
            PhoneNumber = clubPhoneNumber;
            ID = clubNumber++;           
            Address = PhysicalLocation;
            Swimmers = new List<Registrant>(20);
            Coaches = new List<Coach>(20);
        }
        public Club()
        {          
            Coaches = new List<Coach>(20);
            Swimmers = new List<Registrant>(20);
            ID = clubNumber++;
        }
        static Club()
        {
            clubNumber = 1;
        }
        #endregion



        #region ToString Method
        public override string ToString()
        {
            string info;



            info = string.Format("\nName: {1} \nAdress: {2} \nPhone number: {3} \nReg number: {0}", ID, Name, Address.ToString(), ConvertPhoneNumber(PhoneNumber));

            info += string.Format("\nSwimmers:");
            foreach (var swimmer in Swimmers)
            {
                info += string.Format("\n\t  {0}", swimmer.Name);
            }
            info += string.Format("\nCoaches: ");
            foreach (var coach in Coaches)
            {
                info += string.Format("\n\t  {0}", coach.Name);
            }


            return info;
        }
        #endregion

        #region PhoneNumber Method | Convering String 
        public static string ConvertPhoneNumber(long rawValue)
        {
            string line = rawValue.ToString();

            if (line == "0")
            {
                line = "+1 (000) 000-0000";
            }
            else if (line.Length < 10)
            {
                line = "Invalid number";
            }
            else
            {
                line = "+1 (" + line.Substring(0, 3) + ") " + line.Substring(3, 3) + "-" + line.Substring(6, 4);
            }

            return line;
        }
        #endregion

        #region AddSwimmer Method 
        public void AddSwimmer(Registrant swimmer)
        {
            if (NumberOfSwimmers == 0 || Swimmers[NumberOfSwimmers - 1] != swimmer)
            {
                if (swimmer.ItsClub == null || swimmer.ItsClub == this)
                {
                    Swimmers.Add(swimmer);
                    NumberOfSwimmers++;
                    if (swimmer.ItsClub == null)
                    {
                        swimmer.ItsClub = this;
                    }
                                               
                }
                else
                {
                    throw new Exception(string.Format("Swimmer already assigned to {0} club", swimmer.ItsClub.Name));
                }

            }
        }
        #endregion
        public void AddCoach(Coach coach)
        {
            Coaches.Add(coach);
            coach.ItsClub = this;
        }
    }
}
