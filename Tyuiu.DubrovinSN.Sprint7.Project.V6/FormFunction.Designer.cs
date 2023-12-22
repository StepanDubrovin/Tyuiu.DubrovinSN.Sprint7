
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOpenMat_DSN = new System.Windows.Forms.Button();
            this.buttonSaveGraph_DSN = new System.Windows.Forms.Button();
            this.dataGridViewInMatGa_DSN = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatGa_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFunction_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea1);
            this.chartFunction_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend1);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            this.chartFunction_DSN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series1);
            this.chartFunction_DSN.Size = new System.Drawing.Size(612, 712);
            this.chartFunction_DSN.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveGraph_DSN);
            this.panel1.Controls.Add(this.buttonOpenMat_DSN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 712);
            this.panel1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(98, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 712);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewInMatGa_DSN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(101, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 712);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunction_DSN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(752, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 712);
            this.panel3.TabIndex = 4;
            // 
            // buttonOpenMat_DSN
            // 
            this.buttonOpenMat_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_open_file_4847498;
            this.buttonOpenMat_DSN.Location = new System.Drawing.Point(12, 23);
            this.buttonOpenMat_DSN.Name = "buttonOpenMat_DSN";
            this.buttonOpenMat_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonOpenMat_DSN.TabIndex = 0;
            this.buttonOpenMat_DSN.UseVisualStyleBackColor = true;
            this.buttonOpenMat_DSN.Click += new System.EventHandler(this.buttonOpenMat_DSN_Click);
            // 
            // buttonSaveGraph_DSN
            // 
            this.buttonSaveGraph_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.direct_download;
            this.buttonSaveGraph_DSN.Location = new System.Drawing.Point(12, 99);
            this.buttonSaveGraph_DSN.Name = "buttonSaveGraph_DSN";
            this.buttonSaveGraph_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonSaveGraph_DSN.TabIndex = 1;
            this.buttonSaveGraph_DSN.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInMatGa_DSN
            // 
            this.dataGridViewInMatGa_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatGa_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatGa_DSN.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInMatGa_DSN.Name = "dataGridViewInMatGa_DSN";
            this.dataGridViewInMatGa_DSN.Size = new System.Drawing.Size(651, 712);
            this.dataGridViewInMatGa_DSN.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 712);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График функции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatGa_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenMat_DSN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSaveGraph_DSN;
        private System.Windows.Forms.DataGridView dataGridViewInMatGa_DSN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}