using Tyuiu.ZhukovaYA.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task1.V10.Test
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

            valueWaitArray[0] = 0.52;
            valueWaitArray[1] = 4;
            valueWaitArray[2] = -0.75;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}