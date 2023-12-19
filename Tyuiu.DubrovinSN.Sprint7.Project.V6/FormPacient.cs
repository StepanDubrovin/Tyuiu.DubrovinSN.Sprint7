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


                for (int i = 1; i < rows; i++)
                {
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewInMatrix_DSN.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewInMatrix_DSN.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewInMatrix_DSN.Columns[0].Width = 200;
                dataGridViewInMatrix_DSN.Columns[1].Width = 150;
                dataGridViewInMatrix_DSN.Columns[3].Width = 150;
            }
            catch
            {
                MessageBox.Show("Проблема с открытием файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_DSN_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = "OutPutFileTask7.csv";
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
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
