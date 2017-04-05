using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimMeetLibrary
{
   public class ClubsManager : IClubsRepository
    {
        
        public int Number { set; get; }      
        public List<Club> Clubs { set; get; }
        
        public SwimmersManager SwimmerManager { set; get; }

        #region Constructor 
        public ClubsManager()
        {
            Clubs = new List<Club>(100);
            SwimmerManager = new SwimmersManager(this);
        }
        #endregion

    
       
        #region LoadClubs Method
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
                    for (int i = 0; i < Number; i++)
                    {
                        if (valID == Clubs[i].ID)
                        {
                           
                            throw new Exception("Invalid club record. Club with the registration number already exists: ");

                        }
                    }
                    try
                    {
                        aClub.ID = Convert.ToInt32(fields[0]);
                    }
                    catch(Exception)
                    {
                        throw new Exception(string.Format("Invalid club record Club number is not valid:"));
                    }
                    aClub.Name = fields[1];
                    aClub.Address = new Adress(fields[2], fields[3], fields[4], fields[5]);
                    try
                    {
                        aClub.PhoneNumber = Convert.ToInt64(fields[6]);
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format("Invalid club record. Phone number wrong format:"));
                    }
                    Add(aClub);
                   
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
                    writer.WriteLine(Clubs[i].ID + delimeter + Clubs[i].Name + delimeter + Clubs[i].Address.Street + delimeter + Clubs[i].Address.City + delimeter + Clubs[i].Address.Province + delimeter + Clubs[i].Address.Zip + delimeter + Clubs[i].PhoneNumber);
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
        public Club GetByRegNum(int regNumber)
        {
            Club returnValue = null;

            for (int i = 0; i < Number; i++)
            {
                if (Clubs[i].ID == regNumber)
                    returnValue = Clubs[i];
            }

            return returnValue;
        }
        #endregion

        #region AddClub Method
        public void Add(Club aClub)
        {
            Clubs.Add(aClub);
            Number++;
        }
        #endregion

    }
}
