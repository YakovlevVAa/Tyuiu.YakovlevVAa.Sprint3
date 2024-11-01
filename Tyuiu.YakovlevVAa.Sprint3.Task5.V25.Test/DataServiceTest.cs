using Tyuiu.YakovlevVAa.Sprint3.Task5.V25.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 10;
            int stopValue2 = 3;
            int x = 2;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 132.342;
            Assert.AreEqual(wait, res);
        }
    }
}