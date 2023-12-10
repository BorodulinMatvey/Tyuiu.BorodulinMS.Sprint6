using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;


namespace Tyuiu.BorodulinMS.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {

        public int[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);

            int rows = str.Length;
            int columns = str[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string strIndex = str[i];
                string[] strArr = strIndex.Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[i, c] = Convert.ToInt32(strArr[c]);
                }
            }

            // Изменение нечетных значений в пятой строке на -1
            for (int c = 0; c < columns; c++)
            {
                if (matrix.GetLength(0) > 4 && matrix[4, c] % 2 != 0)
                {
                    matrix[4, c] = -1;
                }
            }
            return matrix;
        }
    }
}