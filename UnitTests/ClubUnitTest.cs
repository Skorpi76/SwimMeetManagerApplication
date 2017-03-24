using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;

namespace UnitTests
{
    [TestClass]
    public class ClubUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Club club1;
            Club club2;
            club1 = new Club();
            club1.ClubPhoneNumber = 4164444444;
            club1.ClubName = "NYAC";
            club1.GetInfo();

            club2 = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            club2.GetInfo();
       
        }
    }
}
