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
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int cols = line[0].Split(';').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = line[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }
            return matrix;
        }
    }
}
