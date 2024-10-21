﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KomarovaMV.Sprint3.Task6.V10.Lib
{
    public class DataService : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        if (y > 12) { sum += y; }
                    }
                }
            }
            return sum;
        }
    }
}
