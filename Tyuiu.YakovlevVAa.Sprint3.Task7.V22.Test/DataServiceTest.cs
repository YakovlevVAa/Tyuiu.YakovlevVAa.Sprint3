using Tyuiu.YakovlevVAa.Sprint3.Task7.V22.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valuesWaitArray;
            valuesWaitArray = new double[len];
            valuesWaitArray[0] = 8.04;
            valuesWaitArray[1] = 6.68;
            valuesWaitArray[2] = 4.84;
            valuesWaitArray[3] = 1.76;
            valuesWaitArray[4] = 0.45;
            valuesWaitArray[5] = 0.5;
            valuesWaitArray[6] = -0.87;
            valuesWaitArray[7] = -2.42;
            valuesWaitArray[8] = -3.88;
            valuesWaitArray[9] = -6.83;
            valuesWaitArray[10] = -8.88;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valuesWaitArray, res);

        }
    }
}