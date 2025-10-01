using Tyuiu.AkopovaLV.Sprint1.Task6.V3.Lib;
namespace Tyuiu.AkopovaLV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "привет, дом, книга";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(str);
            string wait = "тма";
            Assert.AreEqual(wait, res);
        }
    }
}
