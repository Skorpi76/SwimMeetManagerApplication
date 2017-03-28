using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Eskender Memetov 
 * Student Number: 300805013 */
namespace SwimMeetLibrary
{
    public class Registrant
    {
        private static int registrantNo;
        private int registrantID;
        private string registrantName;
        private DateTime registrantDateOFBirth;
        private Adress registrantAdress;
        private long registrantPhoneNo;
        private Club nClub;
        private Event nEvent;

        #region Constructor | Setting Default values
        public Registrant(string registrantName, DateTime registrantDateOFBirth, Adress PhysicalLocation, long registrantPhoneNo)
        {
            RegistrantName = registrantName;
            RegistrantDateOFBirth = registrantDateOFBirth;
            RegistrantAdress = PhysicalLocation;
            RegistrantPhoneNo = registrantPhoneNo;
            RegistrantID = registrantNo++;
        }
        public Registrant()
        {
            RegistrantID = registrantNo++;
        }
        static Registrant()
        {
            registrantNo = 1;
        }
        #endregion

        #region Registrant Properties
        public int RegistrantID
        {
            get
            {
                return registrantID;
            }
            set
            {
                registrantID = value;
            }

        }
        public string RegistrantName
        {
            get
            {
                return registrantName;
            }
            set
            {
                registrantName = value;
            }
        }
        public DateTime RegistrantDateOFBirth
        {
            get
            {
                return registrantDateOFBirth;
            }
            set
            {
                registrantDateOFBirth = value;
            }
        }
        public long RegistrantPhoneNo
        {
            get
            {
                return registrantPhoneNo;
            }
            set
            {

                registrantPhoneNo = value;
            }
        }

        public virtual Club NClub
        {
            get
            {
                return nClub;
            }

            set
            {

                if (nClub == null)
                {
                    nClub = value;
                    NClub.AddSwimmer(this);
                }
                else
                {
                    throw new Exception(string.Format("Swimmer is registered with a different club"));
                }
            }
        }

        public Adress RegistrantAdress
        {
            get
            {
                return registrantAdress;
            }

            set
            {

                registrantAdress = value;
            }
        }

        public Event NEvent
        {
            get
            {
                return nEvent;
            }

            set
            {

                nEvent = value;
            }

        }
        #endregion

        #region GetInfo Method
        public override string ToString()
        {
            return string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
                RegistrantID, RegistrantName, RegistrantDateOFBirth, RegistrantAdress.ToString(), Club.PhoneNumber(RegistrantPhoneNo), NClub != null ? NClub.ClubName : "not assigned");

        }
        #endregion

    }
}
