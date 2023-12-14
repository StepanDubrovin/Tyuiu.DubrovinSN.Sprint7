
namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    partial class FormFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFunction_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend1);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series1);
            this.chartFunction_DSN.Size = new System.Drawing.Size(800, 450);
            this.chartFunction_DSN.TabIndex = 0;
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFunction_DSN);
            this.Name = "FormFunction";
            this.Text = "График функции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
    }
}