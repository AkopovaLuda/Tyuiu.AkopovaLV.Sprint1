using Tyuiu.AkopovaLV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.AkopovaLV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double num = 26.6;
            var res = ds.NumberToMoney(num);
            Assert.AreEqual("26 руб. 60 коп.", res);
        }
    }
}
