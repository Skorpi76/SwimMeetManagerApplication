using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class SwimmerClassTest
    {

        [TestMethod]
        [ExpectedException(typeof(Exception), "Coach is not assigned to the club")]
        public void Swimmer_CoachProperty_CoachNotAssigned()
        {
            Swimmer aSwimmer = new Swimmer();
            Club aClub = new Club();
            aClub.AddSwimmer(aSwimmer);
            Coach aCoach = new Coach();
            aSwimmer.ItsCoach = aCoach;
        }


        [TestMethod]
        public void Swimmer_ConstructorValidation_FilledParameters()
        {
            Swimmer aSwimmer = new Swimmer("Ann Smith", new DateTime(1975, 1, 1), new Adress("5 Queen St", "Toronto", "ON", "M2M 4M4"), 4163333333);
            Assert.AreEqual("Ann Smith", aSwimmer.Name);
        }
    }
}
