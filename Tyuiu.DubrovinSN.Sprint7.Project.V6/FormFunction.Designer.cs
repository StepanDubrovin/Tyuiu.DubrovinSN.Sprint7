
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveGraph_DSN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецДиагнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.амбулаторноеЛечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_DSN
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea3);
            this.chartFunction_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.BorderColor = System.Drawing.Color.Black;
            legend3.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend3);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 24);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            this.chartFunction_DSN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DarkSlateGray;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series3);
            this.chartFunction_DSN.Size = new System.Drawing.Size(1364, 605);
            this.chartFunction_DSN.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonSaveGraph_DSN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 629);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 83);
            this.panel1.TabIndex = 1;
            // 
            // buttonSaveGraph_DSN
            // 
            this.buttonSaveGraph_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveGraph_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_save_2550350;
            this.buttonSaveGraph_DSN.Location = new System.Drawing.Point(1280, 12);
            this.buttonSaveGraph_DSN.Name = "buttonSaveGraph_DSN";
            this.buttonSaveGraph_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonSaveGraph_DSN.TabIndex = 1;
            this.buttonSaveGraph_DSN.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunction_DSN);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 629);
            this.panel3.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem
            // 
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецДиагнозToolStripMenuItem,
            this.столбецToolStripMenuItem,
            this.амбулаторноеЛечениеToolStripMenuItem,
            this.должностьВрачаToolStripMenuItem});
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Name = "выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem";
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Size = new System.Drawing.Size(279, 20);
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.Text = "Выбирите столбец для построения диаграммы";
            // 
            // столбецДиагнозToolStripMenuItem
            // 
            this.столбецДиагнозToolStripMenuItem.Name = "столбецДиагнозToolStripMenuItem";
            this.столбецДиагнозToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.столбецДиагнозToolStripMenuItem.Text = "Столбец \"Диагноз\"";
            this.столбецДиагнозToolStripMenuItem.Click += new System.EventHandler(this.столбецДиагнозToolStripMenuItem_Click);
            // 
            // столбецToolStripMenuItem
            // 
            this.столбецToolStripMenuItem.Name = "столбецToolStripMenuItem";
            this.столбецToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.столбецToolStripMenuItem.Text = "Столбец \"На диспансерном учете\"";
            this.столбецToolStripMenuItem.Click += new System.EventHandler(this.столбецToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // амбулаторноеЛечениеToolStripMenuItem
            // 
            this.амбулаторноеЛечениеToolStripMenuItem.Name = "амбулаторноеЛечениеToolStripMenuItem";
            this.амбулаторноеЛечениеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.амбулаторноеЛечениеToolStripMenuItem.Text = "Столбец \"Амбулаторное лечение\"";
            this.амбулаторноеЛечениеToolStripMenuItem.Click += new System.EventHandler(this.амбулаторноеЛечениеToolStripMenuItem_Click);
            // 
            // должностьВрачаToolStripMenuItem
            // 
            this.должностьВрачаToolStripMenuItem.Name = "должностьВрачаToolStripMenuItem";
            this.должностьВрачаToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.должностьВрачаToolStripMenuItem.Text = "Столбец \"Должность врача\"";
            this.должностьВрачаToolStripMenuItem.Click += new System.EventHandler(this.должностьВрачаToolStripMenuItem_Click);
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 712);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График функции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSaveGraph_DSN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецДиагнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem амбулаторноеЛечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьВрачаToolStripMenuItem;
    }
}