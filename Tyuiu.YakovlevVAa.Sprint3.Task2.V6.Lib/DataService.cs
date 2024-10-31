using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakovlevVAa.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double a = 0.25;
            double p = 1.0;
            int k = 1;
            do
            {
                p *= (Math.Pow(a, k) + 1) * Math.Cos(4);
                k++;
            } while (k <= 10);
            return Math.Round(p, 3);
        }
    }
}
