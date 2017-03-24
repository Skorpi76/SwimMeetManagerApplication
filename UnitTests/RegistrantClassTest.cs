using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class RegistrantClassTest
    {
        [TestMethod]
        public void Test_Registrant_PhoneNumberProperty()
        {
            Registrant swimmer1;
            swimmer1 = new Registrant();
            long expectedResult = 4164444444;
            swimmer1.RegistrantPhoneNo = 4164444444;


            Assert.AreEqual(expectedResult, swimmer1.RegistrantPhoneNo);
        }

        [TestMethod]
        public void Test_Registrant_NameProperty()
        {
            Registrant swimmer1;
            swimmer1 = new Registrant();
            string expectedResult = "swimmer1";
            swimmer1.RegistrantName = "swimmer1";


            Assert.AreEqual(expectedResult, swimmer1.RegistrantName);
        }
        [TestMethod]
        public void Test_Registrant_PhoneNumberMethod() // Making sure there is acces to this method from Registrant Class
        {
            Registrant swimmer1;
            swimmer1 = new Registrant();
            string expectedResult = "+1(416)-444-4444";
            swimmer1.RegistrantPhoneNo = 4164444444;
            long currentResult = swimmer1.RegistrantPhoneNo;


            Assert.AreEqual(expectedResult, Club.PhoneNumber(currentResult));
        }

        [TestMethod]
        public void Test_Registrant_GetInfo()
        {
            Registrant swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            string expectedResult = string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
               swimmer1.RegistrantID, swimmer1.RegistrantName, swimmer1.RegistrantDateOFBirth, swimmer1.RegistrantAdress.GetInfo(), Club.PhoneNumber(swimmer1.RegistrantPhoneNo), swimmer1.NClub != null ? swimmer1.NClub.ClubName : "not assigned");

            Assert.AreEqual(expectedResult, swimmer1.GetInfo());
        }

        

    }
}
