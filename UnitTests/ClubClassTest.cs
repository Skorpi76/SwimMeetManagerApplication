using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;

namespace UnitTests
{
    [TestClass]
    public class ClubClassTest
    {
      


        [TestMethod]
        public void Test_Club_PhoneNumberProperty()
        {
            Club club1;
            club1 = new Club();
            long expectedResult = 4164444444;
            club1.PhoneNumber = 4164444444;


            Assert.AreEqual(expectedResult, club1.PhoneNumber);
        }

        [TestMethod]
        public void Test_Club_NameProperty()
        {
            Club club1;
            club1 = new Club();
            string expectedResult = "Club2";
            club1.Name = "Club2";


            Assert.AreEqual(expectedResult, club1.Name);
        }
        [TestMethod]
        public void Test_Club_PhoneNumberMethod()
        {
            Club club1;
            club1 = new Club();
            string expectedResult = "+1(416)-444-4444";
            club1.PhoneNumber = 4164444444;
            long currentResult = club1.PhoneNumber;


            Assert.AreEqual(expectedResult, Club.ConvertPhoneNumber(currentResult));
        }

        [TestMethod]
        public void Test_Club_AddSwimmerMethodNumberOfSwimmers()
        {
            int expectedResult = 2;
            Club club1 = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            Registrant swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            Registrant swimmer2 = new Registrant();
            club1.AddSwimmer(swimmer1);
            club1.AddSwimmer(swimmer2);


            Assert.AreEqual(expectedResult, club1.NumberOfSwimmers);
        }

        [TestMethod] // Testing Registrant ones he is in a club 
        public void Test_Club_AddSwimmerMethodSwimmers()
        {
            string expectedResult = "CCAC";
            Club club1 = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            Registrant swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);

            club1.AddSwimmer(swimmer1);
            try
            {
                Assert.AreEqual(expectedResult, swimmer1.ItsClub.Name);
            }
            catch
            {
                throw new Exception(string.Format("Swimmer: {0}, Clubname {1}", swimmer1.Name, swimmer1.ItsClub.Name));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Registrant is assigned to Canada Fitness club")]
        public void Test_Club_AddSwimmer_TomultipleClubs()
        {
            Club aClub = new Club();
            Registrant aSwimmer = new Registrant();
            aClub.AddSwimmer(aSwimmer);
            Club bClub = new Club();
            bClub.AddSwimmer(aSwimmer);
        }

        [TestMethod]
        public void Test_Club_AddSwimmerMethodReAssignSwimmer()
        {
            Club club1 = new Club("CCAC", new Adress("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);
            Club club2 = new Club();
            club2.Name = "Club2";
            Registrant swimmer1 = new Registrant();
            try
            {
                club1.AddSwimmer(swimmer1);
                club2.AddSwimmer(swimmer1);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }
        }
    }
}
