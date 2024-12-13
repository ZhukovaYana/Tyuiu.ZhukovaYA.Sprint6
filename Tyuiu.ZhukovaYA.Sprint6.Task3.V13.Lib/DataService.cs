namespace Tyuiu.ZhukovaYA.Sprint6.Task3.V13.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] array = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == matrix[i, 1])
                    {
                        array[i] = matrix[i, j];
                    }

                }
            }

            Array.Sort(array);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == matrix[i, 1])
                    {
                        matrix[i, j] = array[i];
                    }
                }
            }
            return matrix;
        }
    }
}
