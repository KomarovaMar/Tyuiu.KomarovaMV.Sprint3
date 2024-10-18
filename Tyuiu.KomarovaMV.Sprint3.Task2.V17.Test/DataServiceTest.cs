using Tyuiu.KomarovaMV.Sprint3.Task2.V17.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int i = 1;
            int j = 10;
            Assert.AreEqual(4.399, ds.GetSumSeries(i,j));
        }
    }
}