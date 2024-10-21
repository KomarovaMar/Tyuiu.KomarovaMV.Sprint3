using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KomarovaMV.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res[c] = Math.Round(((5*x+2.5)/(Math.Sin(x)-2))+2,2);
                if (Math.Sin(x) - 2 == 0) { res[c] = 0; }
                c++;
            }
            return res;
        }
    }
}
