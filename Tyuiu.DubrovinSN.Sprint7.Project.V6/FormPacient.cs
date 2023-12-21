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
        private BindingSource bindingSource = new BindingSource();
        private DataTable dataTable = new DataTable();
        public FormPacient()
        {
            InitializeComponent();

        }
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
                saveFileDialog.FileName = "Информация о пациентах.csv";
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    int rows = dataGridViewInMatrix_DSN.RowCount;
                    int columns = dataGridViewInMatrix_DSN.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value);

                            if (j != columns - 1)
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
                MessageBox.Show("Не удалось сохранить файл","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViltr_DSN_Click(object sender, EventArgs e)
        {
            string filterValue = textBoxVibor_DSN.Text.ToLower();
            for (int i = 0; i < dataGridViewInMatrix_DSN.RowCount - 1; i++) 
            {
                bool rowVisible = false;
                for (int j = 0; j < dataGridViewInMatrix_DSN.ColumnCount; j++)
                {
                    var cellValue = dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (cellValue != null && cellValue == filterValue)
                        {
                            rowVisible = true;
                            break;
                        }
                }
                dataGridViewInMatrix_DSN.Rows[i].Visible = rowVisible;
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
    }
}
