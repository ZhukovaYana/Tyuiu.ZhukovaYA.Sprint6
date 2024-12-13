using System.IO;

namespace Tyuiu.ZhukovaYA.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"E:\repos\Tyuiu.ZhukovaYA.Sprint6\Tyuiu.ZhukovaYA.Sprint6.Task5.V9\bin\DebugInPutFileTask6V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}