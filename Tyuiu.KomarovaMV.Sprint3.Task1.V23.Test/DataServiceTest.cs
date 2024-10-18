using Tyuiu.KomarovaMV.Sprint3.Task1.V23.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();
            int x = 5;
            int i = 1;
            int j=5;
            Assert.AreEqual(8734, 911, ds.GetMultiplySeries(x,i,j));
        }
    }
}