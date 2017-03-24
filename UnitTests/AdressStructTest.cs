using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class AdressStructTest
    {
        [TestMethod]
        public void Test_Adress_Property()
        {
            string street = "35 River St";
            string city = "Toronto";
            string province = "ON";
            string zip = "M2M 5M5";
            Adress adress = new Adress("35 River St", "Toronto", "ON", "M2M 5M5");


            Assert.AreEqual(street, adress.Street);
            Assert.AreEqual(city, adress.City);
            Assert.AreEqual(province, adress.Province);
            Assert.AreEqual(zip, adress.Zip);
        }
        [TestMethod]
        public void Test_Adress_GetInfo()
        {
            Adress adress = new Adress("35 River St", "Toronto", "ON", "M2M 5M5");
            string expectedResult = string.Format("\n\t {0} \n\t {1} \n\t {2} \n\t {3} ", adress.Street, adress.City, adress.Province, adress.Zip);

            Assert.AreEqual(expectedResult, adress.GetInfo());
        }
    }
}
