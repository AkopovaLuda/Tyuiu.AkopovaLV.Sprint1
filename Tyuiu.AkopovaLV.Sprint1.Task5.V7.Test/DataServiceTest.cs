using Tyuiu.AkopovaLV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.AkopovaLV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 90;
            int result = ds.AngleToHoursMinutes(f);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
