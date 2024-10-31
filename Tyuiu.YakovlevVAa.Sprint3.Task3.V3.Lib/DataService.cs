using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakovlevVAa.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minFCount = int.MaxValue;
            int count = 0;
            foreach (char c in value)
            {
                if (c == 'f')
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        minFCount = Math.Min(minFCount, count);
                        count = 0;
                    }
                }

            }
            return minFCount;
        }
        
    }
}
