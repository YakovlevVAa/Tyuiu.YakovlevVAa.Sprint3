using Tyuiu.YakovlevVAa.Sprint3.Task1.V13.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 1.2;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1406.572;
            Assert.AreEqual(wait, res);
        }
    }
}