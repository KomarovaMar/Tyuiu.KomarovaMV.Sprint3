using Tyuiu.KomarovaMV.Sprint3.Task6.V10.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 20;
            int b = 32;
            Assert.AreEqual(396,ds.GetSumTheDivisors(a,b));
        }
    }
}