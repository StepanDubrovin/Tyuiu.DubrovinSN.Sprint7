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
using System.Windows.Forms.DataVisualization.Charting;


namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    public partial class FormFunction : Form
    {
        public FormFunction()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint7\Tyuiu.DubrovinSN.Sprint7.Project.V6\bin\Debug\Информация о пациентах.csv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;

        private void столбецДиагнозToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = ds.GetMatrix(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            int columnD = 9; 
            Dictionary<string, int> count = new Dictionary<string, int>();
            
            if (columns > columnD)
            {
                for (int r = 0; r < rows; r++)
                {
                    string d = matrix[r, columnD].ToString();
                    if (count.ContainsKey(d))
                    {
                        count[d]++;
                    }
                    else
                    {
                        count.Add(d, 1);
                    }
                }
                chartFunction_DSN.Series.Clear();
                Series series = new Series("Диагноз");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DarkSlateGray;
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Диагноз";
                this.chartFunction_DSN.ChartAreas[0].AxisY.Title = "Количесвто";
                chartFunction_DSN.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold); 
                chartFunction_DSN.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold); 
                foreach (var i in count)
                {
                    series.Points.AddXY(i.Key, i.Value); 
                }
                chartFunction_DSN.Series.Add(series);
                chartFunction_DSN.Update();
            }
        }

        private void столбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = ds.GetMatrix(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            int columnD = 11;
            Dictionary<string, int> count = new Dictionary<string, int>();

            if (columns > columnD)
            {
                for (int r = 1; r < rows; r++)
                {
                    string d = matrix[r, columnD].ToString();
                    if (count.ContainsKey(d))
                    {
                        count[d]++;
                    }
                    else
                    {
                        count.Add(d, 1);
                    }
                }
                chartFunction_DSN.Series.Clear();
                Series series = new Series("Диспансерный учёт");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DarkSlateGray;
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Диспансерный учёт";
                this.chartFunction_DSN.ChartAreas[0].AxisY.Title = "Количесвто";
                chartFunction_DSN.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                chartFunction_DSN.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                foreach (var i in count)
                {
                    series.Points.AddXY(i.Key, i.Value);
                }
                chartFunction_DSN.Series.Add(series);
                chartFunction_DSN.Update();
            }
        }

        private void амбулаторноеЛечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = ds.GetMatrix(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            int columnD = 10;
            Dictionary<string, int> count = new Dictionary<string, int>();

            if (columns > columnD)
            {
                for (int r = 1; r < rows; r++)
                {
                    string d = matrix[r, columnD].ToString();
                    if (count.ContainsKey(d))
                    {
                        count[d]++;
                    }
                    else
                    {
                        count.Add(d, 1);
                    }
                }
                chartFunction_DSN.Series.Clear();
                Series series = new Series("Амбулаторное лечение");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DarkSlateGray;
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Амбулаторное лечение";
                this.chartFunction_DSN.ChartAreas[0].AxisY.Title = "Количесвто";
                chartFunction_DSN.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                chartFunction_DSN.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                foreach (var i in count)
                {
                    series.Points.AddXY(i.Key, i.Value);
                }
                chartFunction_DSN.Series.Add(series);
                chartFunction_DSN.Update();
            }
        }

        private void должностьВрачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = ds.GetMatrix(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            int columnD = 6;
            Dictionary<string, int> count = new Dictionary<string, int>();

            if (columns > columnD)
            {
                for (int r = 1; r < rows; r++)
                {
                    string d = matrix[r, columnD].ToString();
                    if (count.ContainsKey(d))
                    {
                        count[d]++;
                    }
                    else
                    {
                        count.Add(d, 1);
                    }
                }
                chartFunction_DSN.Series.Clear();
                Series series = new Series("Должность варча");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DarkSlateGray;
                this.chartFunction_DSN.ChartAreas[0].AxisX.Title = "Должность варча";
                this.chartFunction_DSN.ChartAreas[0].AxisY.Title = "Количесвто";
                chartFunction_DSN.ChartAreas[0].AxisX.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                chartFunction_DSN.ChartAreas[0].AxisY.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                foreach (var i in count)
                {
                    series.Points.AddXY(i.Key, i.Value);
                }
                chartFunction_DSN.Series.Add(series);
                chartFunction_DSN.Update();
            }
        }

        private void buttonBack_DSN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveGraph_DSN_Click(object sender, EventArgs e)
        {
            string saveCh = Environment.CurrentDirectory + "\\chartFunction_DSN.png";
            chartFunction_DSN.SaveImage(saveCh, ChartImageFormat.Png);
            MessageBox.Show("Диаграмма успешно сохранена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
