using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class SwimmersManagerTest
    {
        [TestMethod]
        public void Test_SwimmersManager_LoadSwimmersMethod()
        {
            string expectedResult = string.Format("Swimmer 4");        
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);

            swmMngr.LoadSwimmers(@"C:\A2\Swimmers.txt", ",");
           string actualResult =  swmMngr.Swimmers[0].RegistrantName;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]   
        public void Test_SwimmersManager_LoadSwimmersNullReferenceException()
        {
            ClubsManager clbMngr = new ClubsManager();
            SwimmersManager swmMngr = new SwimmersManager(clbMngr);

           
            try
            {
                swmMngr.LoadSwimmers(@"C:\A2\Swimmers.txt", ",");
                swmMngr.Swimmers[9].GetInfo();
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }
        }

        

    }
}
