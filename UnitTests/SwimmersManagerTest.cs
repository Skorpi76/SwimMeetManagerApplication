using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class SwimmersManagerTest
    {
        [TestMethod]
        public void Test_SwimmersManager_LoadMethod()
        {
            string expectedResult = string.Format("Swimmer 4");
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);

            swmMngr.Load(@"C:\A2\Swimmers.txt", ",");
            string actualResult = swmMngr.Swimmers[0].Name;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_SwimmersManager_NumberProperty()
        {
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);
            swmMngr.Number = 8;
            Assert.AreEqual(8, swmMngr.Number);
        }

        [TestMethod]
        public void Test_SwimmersManager_Costructor()
        {
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);
            Assert.AreEqual(true, swmMngr.Swimmers != null && swmMngr.ClubManager != null);
        }

        [TestMethod]
        public void Test_SwimmerManager_AddMethod()
        {
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);
            Registrant aRegistrant = new Registrant();
            swmMngr.Add(aRegistrant);
            Assert.AreEqual(aRegistrant, swmMngr.Swimmers[0]);
        }


        [TestMethod]
        public void Test_SwimmerManager_LoadGetByRegNumberMethodFull()
        {

            IClubsRepository clbMngr = new ClubsManager();
            ISwimmersRepository swmMngr = new SwimmersManager((ClubsManager)clbMngr);
            try
            {
                swmMngr.Load(@"C:\A2\Swimmers.txt", ",");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Assert.AreEqual("Swimmer 4", swmMngr.GetByRegNum(3004).Name);

        }
        [TestMethod]
        public void Test_SwimmerManager_LoadWrongDateException()
        {

            IClubsRepository clbMngr = new ClubsManager();
            ISwimmersRepository swmMngr = new SwimmersManager((ClubsManager)clbMngr);
            try
            {
                swmMngr.Load(@"C:\A2\Swimmers.txt", ",");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                Assert.AreEqual("S wrong date", swmMngr.GetByRegNum(3014).Name); // will not create it
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.NullReferenceException);
            }
        }
        [TestMethod]
        public void Test_SwimmerManager_LoadWrongPhoneException()
        {

            IClubsRepository clbMngr = new ClubsManager();
            ISwimmersRepository swmMngr = new SwimmersManager((ClubsManager)clbMngr);
            try
            {
                swmMngr.Load(@"C:\A2\Swimmers.txt", ",");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {

                Assert.AreEqual("S wrong phone", swmMngr.GetByRegNum(3015).Name); // will not create it
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.NullReferenceException);
            }
        }
        
    }
}
