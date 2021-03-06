﻿using System;
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
            swimmer1.PhoneNumber = 4164444444;


            Assert.AreEqual(expectedResult, swimmer1.PhoneNumber);
        }

        [TestMethod]
        public void Test_Registrant_NameProperty()
        {
            Registrant swimmer1;
            swimmer1 = new Registrant();
            string expectedResult = "swimmer1";
            swimmer1.Name = "swimmer1";


            Assert.AreEqual(expectedResult, swimmer1.Name);
        }
        [TestMethod]
        public void Test_Registrant_EmptyValues()
        {
            Registrant aSwimmer = new Registrant();
            string expectedResult = string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
                aSwimmer.ID, "", aSwimmer.DOB, aSwimmer.Address.ToString(), Club.ConvertPhoneNumber(aSwimmer.PhoneNumber), "not assigned");

            Assert.AreEqual(expectedResult, aSwimmer.ToString());
        }
        [TestMethod]
        public void Test_Registrant_PhoneNumberMethod() 
        {
            Registrant swimmer1;
            swimmer1 = new Registrant();
            string expectedResult = "+1(416)-444-4444";
            swimmer1.PhoneNumber = 4164444444;
            long currentResult = swimmer1.PhoneNumber;


            Assert.AreEqual(expectedResult, Club.ConvertPhoneNumber(currentResult));
        }

        [TestMethod]
        public void Test_Registrant_GetInfo()
        {
            Registrant swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Adress("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4161234567);
            string expectedResult = string.Format("Name: {1} \nAdress: {3} \nPhone: {4} \nDOB: {2} \nReg number: {0} \nClub: {5}",
               swimmer1.ID, swimmer1.Name, swimmer1.DOB, swimmer1.Address.ToString(), Club.ConvertPhoneNumber(swimmer1.PhoneNumber), swimmer1.ItsClub != null ? swimmer1.ItsClub.Name : "not assigned");

            Assert.AreEqual(expectedResult, swimmer1.ToString());
        }

        [TestMethod]
        public void Test_Registrant_ChangeClubUsingProperty()
        {
            Club club1 = new Club();
            Registrant swimmer1 = new Registrant();
            Club club2 = new Club();
            try
            {
                swimmer1.ItsClub = club1;
                swimmer1.ItsClub = club2;
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }

        }



        [TestMethod]
        public void Test_Registrant_GetEvent()
        {
            Event _200medley = new Event();
            _200medley.DistanceValue = Event.Distance._200;
            _200medley.StrokeValue = Event.Stroke.Individualmedley;

            Registrant aSwimmer = new Registrant();
            _200medley.AddSwimmer(aSwimmer);

            Assert.AreEqual(_200medley, aSwimmer.ItsEvent);
        }




 


    }
}

