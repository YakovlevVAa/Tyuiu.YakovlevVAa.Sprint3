using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakovlevVAa.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double n = 1.2;
            double p = 1;
            int k = 1;
            while (k <= 7)
            {
                p *= Math.Pow(1.0 / Math.Pow(n, k), -1);
                k++; 
            }
            return Math.Round(p, 3);
        }
    }
}
