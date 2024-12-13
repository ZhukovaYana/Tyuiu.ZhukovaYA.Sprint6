using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZhukovaYA.Sprint6.Task4.V6.Lib.WorkingVersion;

namespace Tyuiu.ZhukovaYA.Sprint6.Task4.V6.Test
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

            valueWaitArray[0] = 1.8;
            valueWaitArray[1] = -8;
            valueWaitArray[2] = -5.7;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
