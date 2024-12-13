using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZhukovaYA.Sprint6.Task5.V9.Lib.WorkingVersion
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task5V9
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val == 0).ToArray();

            return numsArray;
        }
    }
}
