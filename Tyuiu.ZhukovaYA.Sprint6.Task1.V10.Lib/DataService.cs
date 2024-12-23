﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhukovaYA.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x)+(2/(3*x+0.5))-2*Math.Cos(x)*2*x;
                valueArray[count] = Math.Round(y, 2);
                count++;
                if ((Math.Cos(x) + x) == 0)
                {
                    valueArray[count] = 0;
                }
            }
            return valueArray;
        }
    }
}
