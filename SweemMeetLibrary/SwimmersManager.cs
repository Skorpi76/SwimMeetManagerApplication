using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimMeetLibrary
{
    public class SwimmersManager : ISwimmersRepository
    {
        
        public int Number { get; set; }
        //public Registrant[] Swimmers { get; set; }
        public List<Registrant> Swimmers { get; set; }
        public ClubsManager ClubManager { get; set; }

        #region Constuctor 
        public SwimmersManager(ClubsManager clubManager)
        {
            ClubManager = clubManager;
           // Swimmers = new Registrant[100];
            Swimmers = new List<Registrant>(100);
        }
        #endregion

     

        #region LoadSwimmers Method + Validation
        public void Load(string fileName, string delimeter)
        {
            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                try
                {
                    fields = recordIn.Split(delimeter[0]);
                    Registrant aSwimmer = new Registrant();

                    ValidationRegistrantID(fields[0]);
                    ValidationRegistrantPhoneNo(fields[7]);
                    ValidationRegistrantBirthDate(fields[2]);


                    if (fields[1] == "") // Fields[1] = RegistrantName
                        throw new Exception(string.Format("Invalid swimmer record. Invalid swimmer name:   "));


                    aSwimmer.RegistrantID = Convert.ToInt32(fields[0]);
                    aSwimmer.RegistrantName = fields[1];
                    aSwimmer.RegistrantDateOFBirth = DateTime.Parse(fields[2]);
                    aSwimmer.RegistrantAdress = new Adress(fields[3], fields[4], fields[5], fields[6]);
                    aSwimmer.RegistrantPhoneNo = Convert.ToInt64(fields[7]);
                   



                    if (fields[8] != "")
                    {
                        int clubNumber = Convert.ToInt32(fields[8]);

                        if (clubNumber != 0)
                        {
                            for (int i = 0; i < ClubManager.Number; i++)
                            {
                                if (ClubManager.Clubs[i].ClubID == clubNumber)
                                {
                                    ClubManager.Clubs[i].AddSwimmer(aSwimmer);
                                    break;
                                }
                            }
                        }

                    }
                  
                Add(aSwimmer);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{1} \n\t{0}", recordIn, e.Message);
                    
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }

        #region Validation methods
        private void ValidationRegistrantID(string validationNumber)
        {
            int valID;
            try
            {
                if (validationNumber == "")
                    throw new Exception(string.Format("Invalid swimmer record. Registration number is missing: "));
                try
                {


                    valID = Convert.ToInt32(validationNumber);

                }
                catch (Exception)
                {
                    throw new Exception(string.Format("Invalid swimmer record. Invalid registration number: "));
                }
                valID = Convert.ToInt32(validationNumber);
                for (int i = 0; i < Number; i++)
                {
                    if (valID == Swimmers[i].RegistrantID)
                    {
                        throw new Exception(string.Format("Invalid swimmer record. Swimmer with the registration number already exists: "));
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void ValidationRegistrantPhoneNo(string validationNumber)
        {
            long valID;
            try
            {
                if (validationNumber == "")
                    throw new Exception(string.Format("Invalid swimmer record. Phone number is missing: "));

                try
                {
                    valID = Convert.ToInt64(validationNumber);
                }
                catch
                {
                    throw new Exception(string.Format("Invalid swimmer record. Phone number wrong format:"));
                }
            }
            catch
            {
                throw;
            }
        }

        private void ValidationRegistrantBirthDate(string validationNumber)
        {
            DateTime dateBirth;
            try
            {
                if (validationNumber == "")
                    throw new Exception(string.Format("Invalid swimmer record. Date of birth is missing: "));

                try
                {


                    dateBirth = DateTime.Parse(validationNumber);
                }
                catch
                {
                    throw new Exception(string.Format("Invalid swimmer record. Birth date is invalid:  "));

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #endregion

        #region SaveSwimmers Method
        public void Save(string fileName, string delimeter)
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                for (int i = 0; i < Number; i++)
                {
                    string clubId;
                    if (Swimmers[i].NClub == null)
                    {
                        clubId = "";
                    }
                    else
                    {
                        clubId = Swimmers[i].NClub.ClubID.ToString();
                    }
                        writer.WriteLine(Swimmers[i].RegistrantID + delimeter + Swimmers[i].RegistrantName + delimeter + 
                            Swimmers[i].RegistrantDateOFBirth + delimeter + Swimmers[i].RegistrantAdress.Street + delimeter + 
                            Swimmers[i].RegistrantAdress.City + delimeter + Swimmers[i].RegistrantAdress.Province + delimeter + 
                            Swimmers[i].RegistrantAdress.Zip + delimeter + Swimmers[i].RegistrantPhoneNo + delimeter + clubId);
                    
                    }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (writer != null) writer.Close();
                if (outFile != null) outFile.Close();
            }
        }
        #endregion

        #region AddSwimmer Method
        public void Add(Registrant aSwimmer)
        {
            Swimmers.Add(aSwimmer);
            Number++;
            int i = 0;
            bool trigger = false;
            while (ClubManager.Clubs[i] != null)
            {
                if (aSwimmer.NClub == ClubManager.Clubs[i])
                    trigger = true;
                i++;
            }
            if (!trigger && aSwimmer.NClub != null)
            {
                ClubManager.Add(aSwimmer.NClub);
            }
        }
        #endregion

        #region GetSwimmer Method
        public Registrant GetByRegNum(int regNumber)
        {
            Registrant returnValue = null;

            for (int i = 0; i < Number; i++)
            {
                if (Swimmers[i].RegistrantID == regNumber)
                    returnValue = Swimmers[i];
            }

            return returnValue;
        }
        #endregion
    }
}
