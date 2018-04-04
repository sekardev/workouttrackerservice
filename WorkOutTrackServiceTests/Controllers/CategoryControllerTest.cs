using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkOutDBLayer.Model;

namespace WorkOutTrackServiceTests.Controllers
{
    [TestClass]
    public class CategoryControllerTest
    {
        [TestMethod]
        public void GetTest()
        {
            WorkOutDBLayer.CateogryDb db = new WorkOutDBLayer.CateogryDb();
            int expectedCount = 1;
            int actualCount = db.GetAll().Count;
            Assert.AreEqual(expectedCount, actualCount);

        }
        [TestMethod]
        public void GetByIdTest()
        {
            WorkOutDBLayer.CateogryDb db = new WorkOutDBLayer.CateogryDb();
            string expectedName = "Walking";
            string actualName = db.GetById(1).CategoryName ;
            Assert.AreEqual(expectedName, actualName);

        }



    }
}
