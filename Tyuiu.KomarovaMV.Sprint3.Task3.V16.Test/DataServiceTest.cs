using Tyuiu.KomarovaMV.Sprint3.Task3.V16.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string i = "ice nice ice creamcc";
            char j = 'c';
            Assert.AreEqual(6, ds.GetCharCount(i,j));
        }
    }
}