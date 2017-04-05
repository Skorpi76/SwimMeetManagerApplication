using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class ClubManagerTest
    {
        [TestMethod]
        public void Test_ClubsManager_Constuctor()
        {
            ClubsManager clbMngr = new ClubsManager();
            Assert.AreEqual(true, clbMngr.Clubs != null && clbMngr.SwimmerManager != null);
        }

        [TestMethod]
        public void Test_ClubsManager_NumberProperty()
        {
            ClubsManager clbMngr = new ClubsManager();
            clbMngr.Number = 9;
            Assert.AreEqual(9, clbMngr.Number);
        }

        [TestMethod]
        public void Test_ClubsManager_AddMethod()
        {
            ClubsManager clbMngr = new ClubsManager();
            Club aClub = new Club();
            clbMngr.Add(aClub);
            Assert.AreEqual(aClub, clbMngr.Clubs[0]);
        }
        [TestMethod]
        public void Test_ClubsManager_LoadMethodAndTestEmpty()
        {
            IClubsRepository clbMngr = new ClubsManager();
            try
            {
                clbMngr.Load(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual("Club 1", clbMngr.GetByRegNum(3004).Name); 
        }
        [TestMethod]
        public void Test_ClubsManager_LoadMethodAndTestFull()
        {
            IClubsRepository clbMngr = new ClubsManager();
            try
            {
                clbMngr.Load(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual("Club 7", clbMngr.GetByRegNum(3007).Name);
        }

        [TestMethod]
        public void Test_ClubsManager_LoadMethodDuplicateException ()
        {
            IClubsRepository clbMngr = new ClubsManager();
            try
            {
                clbMngr.Load(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Assert.AreNotEqual("Duplicate number", clbMngr.GetByRegNum(3006).Name);
        }
        [TestMethod]
        public void Test_ClubsManager_LoadWrongPhoneNumberException()
        {
            IClubsRepository clbMngr = new ClubsManager();
            try
            {
                clbMngr.Load(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            try
            {
                Assert.AreNotEqual(null, clbMngr.GetByRegNum(3008).Name);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.NullReferenceException);
            }

        }

    }
}
