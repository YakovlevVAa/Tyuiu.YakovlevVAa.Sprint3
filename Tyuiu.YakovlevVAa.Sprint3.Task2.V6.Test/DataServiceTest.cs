using Tyuiu.YakovlevVAa.Sprint3.Task2.V6.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.019;
            Assert.AreEqual(wait, res);
        }
    }
}