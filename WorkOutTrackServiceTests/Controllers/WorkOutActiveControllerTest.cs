using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOutDBLayer.Model;


namespace WorkOutTrackServiceTests.Controllers
{
    [TestClass]
    class WorkOutActiveControllerTest
    {

        [TestMethod]
        public void GetTest()
        {
            WorkOutDBLayer.WorkOutActiveDb db = new WorkOutDBLayer.WorkOutActiveDb();
            int expectedCount = 4;
            int actualCount = db.GetAll().Count;
            Assert.AreEqual(expectedCount, actualCount);

        }
        [TestMethod]
        public void GetByIdTest()
        {
            WorkOutDBLayer.WorkOutActiveDb db = new WorkOutDBLayer.WorkOutActiveDb();
            int expectId = 1;
            int actualID = db.GetById(1).WorkOutId;
            Assert.AreEqual(expectId, actualID);

        }


    }
}
