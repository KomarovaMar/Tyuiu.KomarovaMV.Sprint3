using System.ComponentModel.Design.Serialization;
using Tyuiu.KomarovaMV.Sprint3.Task5.V28.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int x = 2;
            int i1 = 1;
            int i2 = 3;
            int k1 = 1;
            int k2 = 12;
            Assert.AreEqual(27020,ds.GetSumSumSeries(x,i1,i2,k1,k2));
        }
    }
}