using Tyuiu.KomarovaMV.Sprint3.Task0.V28.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int i = 1;
            int j = 17;
            Assert.AreEqual(411589.5372020042, ds.GetMultiplySeries(x,i,j));
        }
    }
}