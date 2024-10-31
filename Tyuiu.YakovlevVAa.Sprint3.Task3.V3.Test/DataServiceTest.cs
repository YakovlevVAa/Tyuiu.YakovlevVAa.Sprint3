using Tyuiu.YakovlevVAa.Sprint3.Task3.V3.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string str = "cvbmzff orffgtrr dkfvfffdr";
            char c = 'f';
            int res = ds.GetMinCharCount(str, c);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}