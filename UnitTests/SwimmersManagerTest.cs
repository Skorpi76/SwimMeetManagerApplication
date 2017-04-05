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
           string actualResult =  swmMngr.Swimmers[0].Name;
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

        

    }
}
