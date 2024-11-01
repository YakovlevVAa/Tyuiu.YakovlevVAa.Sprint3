﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakovlevVAa.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                double y = (x / (Math.Cos(x) - x)) + 2.5;
                result *= y;
            }
            return Math.Round(result, 3);

        }
    }
}
