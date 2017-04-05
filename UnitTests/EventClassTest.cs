using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimMeetLibrary;

namespace UnitTests
{
    [TestClass]
    public class EventClassTest
    {
       
       
        [TestMethod]
        public void Test_Event_Properties()
        {
            string expectedDistance = "_50";
            string expectedValue = "Freestyle";
            Event _50free1 = new Event();
            _50free1.DistanceValue = Event.Distance._50;
            _50free1.StrokeValue = Event.Stroke.Freestyle;

            Assert.AreEqual(expectedDistance, _50free1.DistanceValue.ToString());
            Assert.AreEqual(expectedValue, _50free1.StrokeValue.ToString());
        }


        [TestMethod]
        public void Test_Event_AddSwimmerMethod()
        {
            string expectedResult = "Freestyle";
            Event _50free1 = new Event();
            _50free1.DistanceValue = Event.Distance._50;
            _50free1.StrokeValue = Event.Stroke.Freestyle;

            Registrant swimmer1 = new Registrant();

            _50free1.AddSwimmer(swimmer1);

            Assert.AreEqual(expectedResult, swimmer1.ItsEvent.StrokeValue.ToString());
        }


        [TestMethod]
        public void Test_Event_AddSwimmerMethodDublicate()
        {
            string expectedResult = "Freestyle";
            Event _50free1 = new Event();
            _50free1.DistanceValue = Event.Distance._50;
            _50free1.StrokeValue = Event.Stroke.Freestyle;
            Event event2 = new Event();

            Registrant swimmer1 = new Registrant();

            _50free1.AddSwimmer(swimmer1);
            event2.AddSwimmer(swimmer1);

            Assert.AreEqual(expectedResult, swimmer1.ItsEvent.StrokeValue.ToString());
        }

        [TestMethod]
        public void Test_Event_AddEventAddSwimmerSeedAddTimeMethods()
        {
            SwimMeet meet1 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.LCM, 2);
            Event _200medley = new Event();
            _200medley.DistanceValue = Event.Distance._200;
            _200medley.StrokeValue = Event.Stroke.Individualmedley;
            meet1.AddEvent(_200medley);

            Registrant aSwimmer = new Registrant();
            _200medley.AddSwimmer(aSwimmer);
            meet1.Seed();
            _200medley.EnterSwimmersTime(aSwimmer, "00:30.13");

            Assert.AreEqual("00:30.13", _200medley.Swims[0].TimeSwam);
        }

        [TestMethod]
        public void Test_Event_AddTimeExceptionHandle()
        {
            SwimMeet meet1 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), SwimMeet.PoolCourse.LCM, 2);
            Event _200medley = new Event();
            _200medley.DistanceValue = Event.Distance._200;
            _200medley.StrokeValue = Event.Stroke.Individualmedley;
            meet1.AddEvent(_200medley);
           

            Registrant aSwimmer = new Registrant();
         
            meet1.Seed();
            try
            {
                _200medley.EnterSwimmersTime(aSwimmer, "00:30.13");
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }
        }


    }
}
