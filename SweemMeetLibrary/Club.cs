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
        private int clubID;
        private string clubName;
        private long clubPhoneNumber;
        private int numberOfSwimmers = 0;
        Adress address;
        Registrant[] swimmers;

        #region Constructor | Setting Default values
        public Club(string clubName, Adress PhysicalLocation, long clubPhoneNumber)
        {
            ClubName = clubName;
            ClubPhoneNumber = clubPhoneNumber;
            clubID = clubNumber++;
            swimmers = new Registrant[20];
            Address = PhysicalLocation;
        }
        public Club()
        {
            swimmers = new Registrant[20];
            clubID = clubNumber++;
        }
        static Club()
        {
            clubNumber = 1;
        }
        #endregion

        #region Properties
        public int ClubID
        {
            get
            {
                return clubID;
            }
            set
            {
                clubID = value;
            }
        }
        public string ClubName
        {
            get
            {
                return clubName;
            }
            set
            {
                clubName = value;
            }
        }

        public long ClubPhoneNumber
        {
            get
            {
                return clubPhoneNumber;
            }
            set
            {
                clubPhoneNumber = value;
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

        public int NumberOfSwimmers
        {
            get
            {
                return numberOfSwimmers;
            }

            set
            {
                numberOfSwimmers = value;
            }
        }

        public Adress Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        #endregion

        #region GetInfo Method
        public string GetInfo()
        {
            string info;

            info = string.Format("\nName: {1} \nAdress: {2} \n#hone number: {3} \nReg number: {0}", ClubID, ClubName, Address.GetInfo(), PhoneNumber(ClubPhoneNumber));

            info += string.Format("\nSwimmers:");
            int i = 0;
            while (Swimmers[i] != null)
            {
                info += string.Format("\n\t{0}", Swimmers[i].RegistrantName);
                i++;
            }

            return info;
        }
        #endregion

        #region PhoneNumber Method | Convering String 
        public static string PhoneNumber(long rawValue)
        {
            string value = rawValue.ToString();
            if (value == "None")
            {
                value = "None";
            }
            else
            {
                value = new System.Text.RegularExpressions.Regex(@"\D")
                    .Replace(value, string.Empty);
                value = value.TrimStart('1');
                if (value.Length == 10)
                    return Convert.ToInt64(value).ToString("+1(###)-###-####");
                if (value.Length > 10)
                    return Convert.ToInt64(value)
                        .ToString("+1(###)-###-#### " + new String('#', (value.Length - 10)));
            }
            return value;
        }
        #endregion

        #region AddSwimmer Method 
        public void AddSwimmer(Registrant swimmer)
        {
            if (NumberOfSwimmers == 0 || Swimmers[NumberOfSwimmers - 1] != swimmer)
            {
                if (swimmer.NClub == null || swimmer.NClub == this)
                {
                    Swimmers[NumberOfSwimmers] = swimmer;
                    NumberOfSwimmers++;
                    if (swimmer.NClub == null)
                    {
                        swimmer.NClub = this;
                    }
                }              
                else
                {
                    Console.WriteLine("Swimmer already assigned to {0} club", swimmer.NClub.ClubName);
                }

            }
        }
        #endregion

    }
}
