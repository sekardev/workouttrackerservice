using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutDBLayer;
namespace WorkOutTrackServiceTests.Controllers
{
    [TestClass]
    public class ReportControllerTest
    {
         [TestMethod]
        public void GetWorkOutSummaryTest()
        {
            WorkOutDBLayer.WorkOutActiveDb db = new WorkOutDBLayer.WorkOutActiveDb();
            int expected = 120;
            int actualCount = db.GetWorkOutSummary().CurrentWeek;
            Assert.AreEqual(expected, actualCount);
            
        }
        [TestMethod]
         public void GetWeeklyChartTest()
         {
             WorkOutDBLayer.WorkOutActiveDb db = new WorkOutDBLayer.WorkOutActiveDb();
             int expected = 7;
             int actualCount = db.GetWeeklyChart().ChartData.Count;
             Assert.AreEqual(expected, actualCount);

         }
        [TestMethod]
        public void GetMonthlyChartTest()
        {
            WorkOutDBLayer.WorkOutActiveDb db = new WorkOutDBLayer.WorkOutActiveDb();
            int expected = 5;
            int actualCount = db.GetMonthlyChart().ChartData.Count;
            Assert.AreEqual(expected, actualCount);

        }
    }
}
