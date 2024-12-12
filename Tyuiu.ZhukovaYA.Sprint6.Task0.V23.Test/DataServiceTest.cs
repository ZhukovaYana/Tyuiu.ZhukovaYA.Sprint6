using Tyuiu.ZhukovaYA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.223, ds.Calculate(3));
        }
    }
}