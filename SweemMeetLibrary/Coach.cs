using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public class Coach : Registrant
    {
      
        public List<Swimmer> Swimmers { get; set; } 
        public string Credentials { get; set; }
        public override Club ItsClub { get; set; }
        
        public Coach(string registrantName, DateTime registrantDateOFBirth, Adress PhysicalLocation, long registrantPhoneNo) : base(registrantName, registrantDateOFBirth, PhysicalLocation, registrantPhoneNo)
        {
            Swimmers = new List<Swimmer>(20);
        }
        public Coach()
        {
            Swimmers = new List<Swimmer>(20);
        }

     

        public void AddSwimmer(Swimmer aSwimmer)
        {

            if (ItsClub == aSwimmer.ItsClub && !Swimmers.Contains(aSwimmer))
            {
                if (aSwimmer.ItsCoach != this)
                    aSwimmer.ItsCoach = this;
                if (!Swimmers.Contains(aSwimmer))
                    Swimmers.Add(aSwimmer);
            }
            else if (ItsClub != aSwimmer.ItsClub && ItsClub != null)
            {
                throw new Exception("Coach and swimmer are not in the same club");
            }
            else if (ItsClub == null)
            {
                throw new Exception("Coach is not assigned to a club");
            }




        }

        public override string ToString()
        {    
           string info = base.ToString() + string.Format("\n Credentials: {0}\n Swimmers: ", Credentials);
            foreach (var item in Swimmers)
            {
                info += string.Format("\n\t  {0}", item.Name);
            }
            return info;
        }
    }
}

