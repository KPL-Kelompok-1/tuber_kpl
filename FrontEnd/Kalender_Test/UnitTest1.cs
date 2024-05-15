using FrontEnd;

namespace Kalender_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKalender()
        {
            Kalender.GetDays(Kalender.Month.Januari);
            int Days = Kalender.GetDays(Kalender.Month.Januari);
            Assert.AreEqual(31, Days);
        }
        [TestMethod]
        public void TestKalenderIsNULL()
        {
            Kalender.GetDays(Kalender.Month.Januari);
            int Days = Kalender.GetDays(Kalender.Month.Test);
            Assert.AreEqual(-1, Days);
        }
    }
}