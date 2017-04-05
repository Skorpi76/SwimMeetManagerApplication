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
        public void Test_SwimMeet_SeedMethod()
        {
            Event aEvent = new Event();
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.SCM, 2);
            Swimmer aRegistrant = new Swimmer();
            aMeet.AddEvent(aEvent);

            aEvent.AddSwimmer(aRegistrant);
            aMeet.Seed();
            Assert.AreEqual("1" + "1", aMeet.Events[0].Swims[0].Heat.ToString() + aMeet.Events[0].Swims[0].Lane.ToString());
        }

        [TestMethod]
        public void Test_SwimMeet_SeedMethodNewHeat()
        {
            Event aEvent = new Event();
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.SCM, 2);
            Swimmer aRegistrant = new Swimmer();
            Swimmer bRegistrant = new Swimmer();
            Swimmer cRegistrant = new Swimmer();
            aMeet.AddEvent(aEvent);

            aEvent.AddSwimmer(aRegistrant);
            aEvent.AddSwimmer(bRegistrant);
            aEvent.AddSwimmer(cRegistrant);
            aMeet.Seed();
            Assert.AreEqual("11" + "12" + "21", aMeet.Events[0].Swims[0].Heat.ToString() + aMeet.Events[0].Swims[0].Lane.ToString() + aMeet.Events[0].Swims[1].Heat.ToString() + aMeet.Events[0].Swims[1].Lane.ToString() + aMeet.Events[0].Swims[2].Heat.ToString() + aMeet.Events[0].Swims[2].Lane.ToString());
        }

        [TestMethod]
        public void Test_SwimMeet_AddEventsMethod()
        {
            string expectedResult = "Winnter Splash";
            SwimMeet meet1 = new SwimMeet();
            meet1.Name = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;
            SwimMeet meet2 = new SwimMeet();

            Event event1 = new Event();
            meet1.AddEvent(event1);
        
            try
            {
                Assert.AreEqual(expectedResult, event1.SweeMeets.Name);
            }
            catch
            {
                throw new Exception(string.Format("Event 1 {0}", event1.SweeMeets.Name));
            }
        }

        [TestMethod]
        public void Test_SwimMeet_Property()
        {
            string Name = "Winnter Splash";
            DateTime startDate = new DateTime(2017, 1, 10);
            DateTime endDate = new DateTime(2017, 1, 12);
            int noOfLanes = 8;

            SwimMeet meet1 = new SwimMeet();
            meet1.Name = "Winnter Splash";
            meet1.StartDate = new DateTime(2017, 1, 10);
            meet1.EndDate = new DateTime(2017, 1, 12);
            meet1.NoOfLanes = 8;

            Assert.AreEqual(Name, meet1.Name);
            Assert.AreEqual(startDate, meet1.StartDate);
            Assert.AreEqual(endDate, meet1.EndDate);
            Assert.AreEqual(noOfLanes, meet1.NoOfLanes);

        }
     


        


    }
}
