using Tyuiu.AkopovaLV.Sprint1.Task7.V23.Lib;
namespace Tyuiu.AkopovaLV.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = Math.Round(1.2651, 3);
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);

        }
    }
}
