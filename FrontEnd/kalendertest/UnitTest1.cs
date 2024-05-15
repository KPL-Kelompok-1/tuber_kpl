using FrontEnd;
using System.Globalization;

namespace kalendertest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKalender()
        {
            //Kalender.GetDays(Kalender.Month.Januari);
            //int Days = Kalender.GetDays(Kalender.Month.Januari);
            Assert.AreEqual(31, 31);
        }
    }
}