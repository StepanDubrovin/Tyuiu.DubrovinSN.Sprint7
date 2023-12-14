using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.DubrovinSN.Sprint7.Project.V6.Lib;

namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    public partial class FormPacient : Form
    {
        public FormPacient()
        {
            InitializeComponent();
        }
        string openFile = @"C:\Sprint7\Pacients.csv";
        static int rows;
        static int columns;
        DataService ds = new DataService();
        private void buttonFunction_DSN_Click(object sender, EventArgs e)
        {
            FormFunction formFunc = new FormFunction();
            formFunc.ShowDialog();
        }
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonOpenFile_DSN_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFile);

            dataGridViewInMatrix_DSN.RowCount = rows;
            dataGridViewInMatrix_DSN.ColumnCount = columns;
            //dataGridViewOutMatrix_DSN.RowCount = rows;
            //dataGridViewOutMatrix_DSN.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_DSN.Columns[i].Width = 50;
                //dataGridViewOutMatrix_DSN.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_DSN.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }       
        }
    }
}
