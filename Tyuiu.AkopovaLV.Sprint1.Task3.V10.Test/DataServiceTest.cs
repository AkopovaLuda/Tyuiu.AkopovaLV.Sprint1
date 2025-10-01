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
            double number = 23.6;
            string wait = "23 руб. 60 коп.";
            string res = ds.NumberToMoney(number);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double number = 23.45;
            string wait = "23 руб. 45 коп.";
            string res = ds.NumberToMoney(number);
            Assert.AreEqual(wait, res);
        }
    }
}
