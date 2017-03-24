using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimMeetLibrary
{
   public class ClubsManager
    {
        private Club[] clubs;
        private int numberOfClubs;
        private SwimmersManager swimmerManager;

        #region Constructor 
        public ClubsManager()
        {
            Clubs = new Club[100];
            SwimmerManager = new SwimmersManager(this);
        }
        #endregion

        #region Properties
        public int NumberOfClubs
        {
            get
            {
                return numberOfClubs;
            }

            set
            {
                numberOfClubs = value;
            }
        }

        public Club[] Clubs
        {
            get
            {
                return clubs;
            }

            set
            {
                clubs = value;
            }
        }

        public SwimmersManager SwimmerManager
        {
            get
            {
                return swimmerManager;
            }

            set
            {
                swimmerManager = value;
            }
        }
        #endregion

        #region LoadClubs Method
        public void LoadClubs(string fileName, string delimeter)
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
                    Club aClub = new Club();


                    try
                    {
                        if (fields[0] == "")
                            throw new Exception(string.Format("Invalid club record. Registration number is missing: "));
                        if (fields[1] == "")
                            throw new Exception(string.Format("Invalid club record. Club name is missing: "));
                        if (fields[6] == "")
                            throw new Exception(string.Format("Invalid club record. Phone number is missing: "));
                    }
                    catch
                    {
                        throw;
                    }

                    int valID;
                    valID = Convert.ToInt32(fields[0]);
                    for (int i = 0; i < NumberOfClubs; i++)
                    {
                        if (valID == Clubs[i].ClubID)
                        {
                           
                            throw new Exception("Invalid club record. Club with the registration number already exists: ");

                        }
                    }
                    try
                    {
                        aClub.ClubID = Convert.ToInt32(fields[0]);
                    }
                    catch(Exception)
                    {
                        throw new Exception(string.Format("Invalid club record Club number is not valid:"));
                    }
                    aClub.ClubName = fields[1];
                    aClub.Address = new Adress(fields[2], fields[3], fields[4], fields[5]);
                    try
                    {
                        aClub.ClubPhoneNumber = Convert.ToInt64(fields[6]);
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Invalid club record. Phone number wrong format:"));
                    }
                    AddClub(aClub);
                    // Console.WriteLine("{0,-5}{1,-12}{2,8} {3}", aClub.ClubID, aClub.ClubName, aClub.Address.City, aClub.ClubPhoneNumber); // temp
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
        #endregion

        #region SaveClubs Method
        public void SaveClubs(string fileName, string delimeter)
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                for (int i = 0; i < numberOfClubs; i++)
                {
                    writer.WriteLine(Clubs[i].ClubID + delimeter + Clubs[i].ClubName + delimeter + Clubs[i].Address.Street + delimeter + Clubs[i].Address.City + delimeter + Clubs[i].Address.Province + delimeter + Clubs[i].Address.Zip + delimeter + Clubs[i].ClubPhoneNumber);
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

        #region GetClub Method
        public Club GetClub(int regNumber)
        {
            Club returnValue = null;

            for (int i = 0; i < numberOfClubs; i++)
            {
                if (Clubs[i].ClubID == regNumber)
                    returnValue = Clubs[i];
            }

            return returnValue;
        }
        #endregion

        #region AddClub Method
        public void AddClub(Club aClub)
        {
            Clubs[NumberOfClubs++] = aClub;
        }
        #endregion

    }
}
