using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DubrovinSN.Sprint7.Project.V6.Lib;


namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    public partial class FormFunction : Form
    {
        public FormFunction()
        {
            InitializeComponent();
        }
        string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint7\Tyuiu.DubrovinSN.Sprint7.Project.V6\bin\Debug\Информация о пациентах.csv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonOpenMat_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                openFile = openFileDialog.FileName;

                matrix = ds.GetMatrix(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewInMatGa_DSN.RowCount = rows;
                dataGridViewInMatGa_DSN.ColumnCount = columns;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInMatGa_DSN.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewInMatGa_DSN.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewInMatGa_DSN.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Проблема с открытием файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
