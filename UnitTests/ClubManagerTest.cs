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
    }
}
