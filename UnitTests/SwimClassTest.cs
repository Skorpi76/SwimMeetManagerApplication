using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class SwimClassTest
    {

        [TestMethod]
        public void Test_Swim_HeatProperty()
        {
            Swim aSwim = new Swim();
            aSwim.Heat = 1;
            Assert.AreEqual(1, aSwim.Heat);
        }

        [TestMethod]
        public void Test_Swim_TimeSwamProperty()
        {
            string expectedResult = "15.34";
            Swim aSwim = new Swim();
            aSwim.TimeSwam = "15.34";
            Assert.AreEqual(expectedResult, aSwim.TimeSwam);
        }

        [TestMethod]
        public void Test_Swim_LaneProperty()
        {
            Swim aSwim = new Swim();
            aSwim.Lane = 1;
            Assert.AreEqual(1, aSwim.Lane);
        }



        [TestMethod]
        public void Test_Swim_ConstructorFull()
        {
            Swim aSwim = new Swim(4, 6, "11.21");
            Assert.AreEqual(4 + 6, aSwim.Heat + aSwim.Lane);
        }

        [TestMethod]
        public void Test_Swim_ConstructorEmpty()
        {
            Swim aSwim = new Swim();
            Assert.AreEqual(0, aSwim.Heat + aSwim.Lane);
        }

        [TestMethod]
        public void Test_Swim_ToStringMethod()
        {
            Swim aSwim = new Swim(3, 3, "12:12.33");
            Assert.AreEqual("\n\tLane: 3\n\tHeat: 3\n\tTime 12:12.33\n", aSwim.ToString());
        }

    }
}

