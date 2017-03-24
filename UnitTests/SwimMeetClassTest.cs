using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;
namespace UnitTests
{
    [TestClass]
    public class SwimMeetClassTest
    {
        [TestMethod]
        public void Test_SwimMeet_NumberOfEvents()
        {
            int expectedResult = 2;
            SwimMeet meet1 = new SwimMeet();
            Event event1 = new Event();
            Event event2 = new Event();

            meet1.AddEvent(event1);
            meet1.AddEvent(event2);

            Assert.AreEqual(expectedResult, meet1.NoOfEvents);
        }

        [TestMethod]
        public void Test_SwimMeet_Property()
        {
            string Name = "Winnter Splash";
            DateTime startDate = new DateTime(2017, 1, 10);
            DateTime endDate = new DateTime(2017, 1, 12);
            int noOfLanes = 8;

            SwimMeet meet1 = new SwimMeet();
            meet1.NameOfMeet = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;

            Assert.AreEqual(Name, meet1.NameOfMeet);
            Assert.AreEqual(startDate, meet1.StartDate);
            Assert.AreEqual(endDate, meet1.EndDate);
            Assert.AreEqual(noOfLanes, meet1.NoOfLanes);

        }
        [TestMethod]
        public void Test_SwimMeet_GetInfoWithoutEvents()
        {
            SwimMeet meet1 = new SwimMeet();
            meet1.NameOfMeet = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;
            string expectedResult;
            expectedResult = string.Format("Sweem meet name: {2} \nFrom-to:{0} to {1} \nPool type: {3} \nNo lanes: {4}",
                meet1.StartDate, meet1.EndDate, meet1.NameOfMeet, meet1.course, meet1.NoOfLanes);
            int i = 0;
            expectedResult += "\t\nEvents: ";
            while (meet1.Events[i] != null)
            {
                expectedResult += string.Format(meet1.Events[i].GetInfo());
                i++;
            }

            Assert.AreEqual(expectedResult, meet1.GetInfo());
        }


        [TestMethod]
        public void Test_SwimMeet_GetInfoWithEvents()
        {
            SwimMeet meet1 = new SwimMeet();
            meet1.NameOfMeet = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;

            Event _100fly = new Event(Event.Distance._100, Event.Stroke.Butterfly);
            Event _200breast = new Event(Event.Distance._200, Event.Stroke.Breaststroke);

            meet1.AddEvent(_100fly);
            meet1.AddEvent(_200breast);

            string expectedResult;
            expectedResult = string.Format("Sweem meet name: {2} \nFrom-to:{0} to {1} \nPool type: {3} \nNo lanes: {4}",
                meet1.StartDate, meet1.EndDate, meet1.NameOfMeet, meet1.course, meet1.NoOfLanes);
            int i = 0;
            expectedResult += "\t\nEvents: ";
            while (meet1.Events[i] != null)
            {
                expectedResult += string.Format(meet1.Events[i].GetInfo());
                i++;
            }

            Assert.AreEqual(expectedResult, meet1.GetInfo());
        }



    }
}
