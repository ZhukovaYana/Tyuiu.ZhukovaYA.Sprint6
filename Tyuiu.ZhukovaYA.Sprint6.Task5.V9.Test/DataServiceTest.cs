using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.ZhukovaYA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"E:\repos\Tyuiu.ZhukovaYA.Sprint6\Tyuiu.ZhukovaYA.Sprint6.Task5.V9\bin\DebugInPutFileTask5V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
