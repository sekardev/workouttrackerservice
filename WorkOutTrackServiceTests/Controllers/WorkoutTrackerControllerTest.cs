using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOutDBLayer.Model;


namespace WorkOutTrackServiceTests.Controllers
{
    class WorkoutTrackerControllerTest
    {
        [TestMethod]
        public void GetTest()
        {
            WorkOutDBLayer.WorkOutDb db = new WorkOutDBLayer.WorkOutDb();
            int expectedCount = 4;
            int actualCount = db.GetAll().Count;
            Assert.AreEqual(expectedCount, actualCount);

        }
        [TestMethod]
        public void GetByIdTest()
        {
            WorkOutDBLayer.WorkOutDb db = new WorkOutDBLayer.WorkOutDb();
            int expectId = 1;
            int actualID = db.GetById(1).WorkOutId;
            Assert.AreEqual(expectId, actualID);

        }

    }
}
