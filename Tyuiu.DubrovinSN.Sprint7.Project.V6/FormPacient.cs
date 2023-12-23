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
        string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint7\Tyuiu.DubrovinSN.Sprint7.Project.V6\bin\Debug\Информация о пациентах.csv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonFunction_DSN_Click(object sender, EventArgs e)
        {
            FormFunction formFunc = new FormFunction();
            formFunc.ShowDialog();
        }
        private void buttonOpenFile_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                openFile = openFileDialog.FileName;

                matrix = ds.GetMatrix(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewInMatrix_DSN.RowCount = rows;
                dataGridViewInMatrix_DSN.ColumnCount = columns;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewInMatrix_DSN.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewInMatrix_DSN.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Проблема с открытием файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = "Информация о пациентах(выгрузка).csv";
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    DataTable newMatrix = new DataTable();
                    foreach (DataGridViewColumn column in dataGridViewInMatrix_DSN.Columns)
                    {
                        newMatrix.Columns.Add(column.HeaderText);
                    }
                    foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                    {
                        if (row.Visible) 
                        {
                            DataRow nrows = newMatrix.Rows.Add();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                nrows[cell.ColumnIndex] = cell.Value;
                            }
                        }
                    }
                    StringBuilder strBuilder = new StringBuilder();
                    foreach (DataRow row in newMatrix.Rows)
                    {
                        foreach (DataColumn column in newMatrix.Columns)
                        {
                            strBuilder.Append(row[column]);

                            if (column.Ordinal < newMatrix.Columns.Count - 1)
                            {
                                strBuilder.Append(";");
                            }
                        }
                        strBuilder.AppendLine();
                    }

                    File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViltr_DSN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewInMatrix_DSN.RowCount - 1; i++)
            {
                string filterValue = textBoxVibor_DSN.Text.ToLower();
                dataGridViewInMatrix_DSN.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewInMatrix_DSN.ColumnCount; j++)
                {
                    var cellValue = dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (cellValue != null && cellValue == filterValue)
                    {
                        dataGridViewInMatrix_DSN.Rows[i].Visible = true;
                        break;
                    }
                }
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_DSN.Rows[matrix.GetLength(0) - 1].Cells[c].Value = "";
                }
            }
        }

        private void buttonDelete_DSN_Click(object sender, EventArgs e)
        {
            dataGridViewInMatrix_DSN.Rows.Clear();
        }

        private void buttonSerch_DSN_Click(object sender, EventArgs e)
        {
            string serchValue = textBoxReserch_DSN.Text.ToLower();
            for (int i = 0; i < dataGridViewInMatrix_DSN.RowCount; i++)
            {
                dataGridViewInMatrix_DSN.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewInMatrix_DSN.ColumnCount; j++)
                {
                    var serchEl = dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (serchEl != null)
                    {
                        if (serchEl.ToString().Contains(textBoxReserch_DSN.Text))
                        {
                            dataGridViewInMatrix_DSN.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
    
        }

        private void солбецВозрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortVozr(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецКабинетВрачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortVozr(mx, 8);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецСрокЛеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortVozr(mx, 13);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void солбецВозрастToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortYb(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецКабинетВрачаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortYb(mx, 8);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецСрокЛеченияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.SortYb(mx, 13);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void buttonBackMatrix_DSN_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < rows; r++)
            {
                dataGridViewInMatrix_DSN.Rows[r].Visible = true;
            }
            dataGridViewInMatrix_DSN.Rows.Clear();
            matrix = ds.GetMatrix(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            dataGridViewInMatrix_DSN.RowCount = rows + 1;
            dataGridViewInMatrix_DSN.ColumnCount = columns;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = matrix[i, j];
                    dataGridViewInMatrix_DSN.Rows[i].Cells[j].Selected = false;
                }
            }
        }

        private void buttonDone_DSN_Click(object sender, EventArgs e)
        {
            int ageColumn = 4;
            int srokColumn = 13;
            int maxValue = int.MinValue;
            if (comboBoxMax_DSN.SelectedItem.ToString() == "Возраст")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[ageColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[ageColumn].Value.ToString(), out int cellValue))
                        {
                            maxValue = Math.Max(maxValue, cellValue);
                        }
                    }
                }
            }
            else if (comboBoxMax_DSN.SelectedItem.ToString() == "Срок лечения(дни)")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[srokColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[srokColumn].Value.ToString(), out int cellValue))
                        {
                            maxValue = Math.Max(maxValue, cellValue);
                        }
                    }
                }
            }
            textBoxMax_DSN.Text = maxValue.ToString();
        }

        private void buttonMin_DSN_Click(object sender, EventArgs e)
        {
            int ageColumn = 4;
            int srocColumn = 13;
            int minValue = int.MaxValue;
            if (comboBoxMin_DSN.SelectedItem.ToString() == "Возраст")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[ageColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[ageColumn].Value.ToString(), out int cellValue))
                        {
                            minValue = Math.Min(minValue, cellValue);
                        }
                    }
                }
            }
            else if (comboBoxMin_DSN.SelectedItem.ToString() == "Срок лечения(дни)")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[srocColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[srocColumn].Value.ToString(), out int cellValue))
                        {
                            minValue = Math.Min(minValue, cellValue);
                        }
                    }
                }
            }
             textBoxMin_DSN.Text = minValue.ToString();
        }

        private void buttonSrZnach_DSN_Click(object sender, EventArgs e)
        {
            int ageColumn = 4;
            int srokColumn = 13;
            int sum = 0;
            int count = 0;

            if (comboBoxSr_DSN.SelectedItem?.ToString() == "Возраст")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[ageColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[ageColumn].Value.ToString(), out int cellValue))
                        {
                            sum += cellValue;
                            count++;
                        }
                    }
                }
            }
            else if (comboBoxSr_DSN.SelectedItem?.ToString() == "Срок лечения(дни)")
            {
                foreach (DataGridViewRow row in dataGridViewInMatrix_DSN.Rows)
                {
                    if (row.Cells[srokColumn].Value != null)
                    {
                        if (int.TryParse(row.Cells[srokColumn].Value.ToString(), out int cellValue))
                        {
                            sum += cellValue;
                            count++;
                        }
                    }
                }
            }
            if (count > 0)
            {
                double sr = Math.Round((double)sum / count,3);
                textBoxSr_DSN.Text = sr.ToString();
            }
        }
    }
}
