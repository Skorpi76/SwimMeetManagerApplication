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
        public int RegistrantID { set; get; }
        public string RegistrantName { set; get; }
        public DateTime RegistrantDateOFBirth { set; get; }
        public Adress RegistrantAdress { set; get; }
        public long RegistrantPhoneNo { set; get; }
        private Club nClub;
        public Event NEvent { set; get; }

        
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

     
      

        #region ToSting Method
        public override string ToString()
        {
            return string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
                RegistrantID, RegistrantName, RegistrantDateOFBirth, RegistrantAdress.ToString(), Club.PhoneNumber(RegistrantPhoneNo), NClub != null ? NClub.ClubName : "not assigned");

        }
        #endregion

    }
}
