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
        public List<Registrant> Swimmers { get; set; }
        public ClubsManager ClubManager { get; set; }

        #region Constuctor 
        public SwimmersManager(ClubsManager clubManager)
        {
            ClubManager = clubManager;
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

                    TestID(fields[0]);
                    TestPhoneNumber(fields[7]);
                    TestDOB(fields[2]);


                    if (fields[1] == "") // Fields[1] = Name
                        throw new Exception(string.Format("Invalid swimmer record. Invalid swimmer name:   "));


                    aSwimmer.ID = Convert.ToInt32(fields[0]);
                    aSwimmer.Name = fields[1];
                    aSwimmer.DOB = DateTime.Parse(fields[2]);
                    aSwimmer.Address = new Adress(fields[3], fields[4], fields[5], fields[6]);
                    aSwimmer.PhoneNumber = Convert.ToInt64(fields[7]);




                    if (fields[8] != "")
                    {
                        int clubNumber = Convert.ToInt32(fields[8]);

                        if (clubNumber != 0)
                        {
                            for (int i = 0; i < ClubManager.Number; i++)
                            {
                                if (ClubManager.Clubs[i].ID == clubNumber)
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
                    //string exceptions = "";
                    //exceptions += string.Format("{1} \n\t{0}", recordIn, e.Message);
                    //Console.WriteLine(exceptions);
                    //throw new Exception(string.Format("{1} \n\t{0}", recordIn, e.Message));
                    //throw;
                    Console.WriteLine("{1} \n\t{0}", recordIn, e.Message);
                }
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }

        #region Validation methods
        private void TestID(string validationNumber)
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
                    if (valID == Swimmers[i].ID)
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
        private void TestPhoneNumber(string validationNumber)
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

        private void TestDOB(string validationNumber)
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
                foreach (var item in Swimmers)
                {
                    string clubId;
                    if (item.ItsClub == null)
                    {
                        clubId = "";
                    }
                    else
                    {
                        clubId = item.ItsClub.ID.ToString();
                    }
                    writer.WriteLine(item.ID + delimeter + item.Name + delimeter +
                        item.DOB + delimeter + item.Address.Street + delimeter +
                        item.Address.City + delimeter + item.Address.Province + delimeter +
                        item.Address.Zip + delimeter + item.PhoneNumber + delimeter + clubId);


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

            bool trigger = false;
            foreach (Club club in ClubManager.Clubs)
            {
                if (aSwimmer.ItsClub == club)
                    trigger = true;
            }
            if (!trigger && aSwimmer.ItsClub != null)
            {
                ClubManager.Add(aSwimmer.ItsClub);
            }
        }
        #endregion

        #region GetSwimmer Method
        public Registrant GetByRegNum(int regNumber)
        {
            Registrant returnValue = null;

            for (int i = 0; i < Number; i++)
            {
                if (Swimmers[i].ID == regNumber)
                    returnValue = Swimmers[i];
            }

            return returnValue;
        }
        #endregion
    }
}
