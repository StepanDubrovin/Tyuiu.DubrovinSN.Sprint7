using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint7.Project.V6.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string[] num = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            int columns = num[0].Split(';').Length;
            int rows = num.Length;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < num.Length; i++)
            {
                string numIndex = num[i];
                string[] numArray = numIndex.Split(';');
                for (int j = 0; j < numArray.Length; j++) matrix[i, j] = numArray[j];
            }
            return matrix;
        }
        public string[,] SortMax(string[,] matrix, int NumberColumn)
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }


        public string[,] SortVozr(string[,] matrix, int NumberColumn)
        {
            int[] input = new int[matrix.GetLength(0) - 1];
            input[input.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(input, (x, y) => x.CompareTo(y));

            string[,] sortedmx = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < sortedmx.GetLength(1); i++)
            {
                sortedmx[0, i] = matrix[0, i];
            }

            for (int i = 0; i < sortedmx.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (input[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < sortedmx.GetLength(1); c++)
                        {
                            sortedmx[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return sortedmx;
        }
    }
}
