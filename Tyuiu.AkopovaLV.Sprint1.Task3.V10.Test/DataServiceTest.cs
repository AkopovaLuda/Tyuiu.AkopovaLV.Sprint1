using Tyuiu.AkopovaLV.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.AkopovaLV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double num = 30.5;
            var res = ds.NumberToMoney(num);
            Assert.AreEqual($"30.5 руб. - это 30 руб. 50 коп.", res);
        }
    }
}
