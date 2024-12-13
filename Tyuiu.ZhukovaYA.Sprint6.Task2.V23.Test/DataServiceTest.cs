using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZhukovaYA.Sprint6.Task2.V23.Lib.WorkingVersion;
namespace Tyuiu.ZhukovaYA.Sprint6.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 5.36;
            valueWaitArray[1] = 2.5;
            valueWaitArray[2] = 0;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
