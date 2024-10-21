using Tyuiu.KomarovaMV.Sprint3.Task7.V19.Lib;
namespace Tyuiu.KomarovaMV.Sprint3.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int b = 5;
            double[] res=ds.GetMassFunction(a, b);
            double[] t = new double[] { 23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 };
            CollectionAssert.AreEqual(t, res);
        }
    }
}