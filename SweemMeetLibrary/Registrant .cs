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
        public int ID { set; get; }
        public string Name { set; get; }
        public DateTime DOB { set; get; }
        public Adress Address { set; get; }
        public long PhoneNumber { set; get; }
        private Club itsClub;
        public Event ItsEvent { set; get; }

        
        public Registrant(string registrantName, DateTime registrantDateOFBirth, Adress PhysicalLocation, long registrantPhoneNo)
        {
            Name = registrantName;
            DOB = registrantDateOFBirth;
            Address = PhysicalLocation;
            PhoneNumber = registrantPhoneNo;
            ID = registrantNo++;
        }
        public Registrant()
        {
            ID = registrantNo++;
        }
        static Registrant()
        {
            registrantNo = 1;
        }


        public virtual Club ItsClub
        {
            get
            {
                return itsClub;
            }

            set
            {

                if (itsClub == null)
                {
                    itsClub = value;
                    ItsClub.AddSwimmer(this);
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
                ID, Name, DOB, Address.ToString(), Club.ConvertPhoneNumber(PhoneNumber), ItsClub != null ? ItsClub.Name : "not assigned");

        }
        #endregion

    }
}
