using Tyuiu.AkopovaLV.Sprint1.Task4.V7.Lib;
namespace Tyuiu.AkopovaLV.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double z = 2.414;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z , res);
        }
    }
}
