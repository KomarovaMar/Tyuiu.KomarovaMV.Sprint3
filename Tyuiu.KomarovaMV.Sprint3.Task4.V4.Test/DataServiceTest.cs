using Tyuiu.KomarovaMV.Sprint3.Task4.V4.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            Assert.AreEqual(-44.313, ds.Calculate(x,y));
        }
    }
}