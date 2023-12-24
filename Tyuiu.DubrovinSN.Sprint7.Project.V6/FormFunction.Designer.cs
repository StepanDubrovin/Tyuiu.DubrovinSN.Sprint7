
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_DSN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelNiz_DSN = new System.Windows.Forms.Panel();
            this.buttonBack_DSN = new System.Windows.Forms.Button();
            this.buttonSaveGraph_DSN = new System.Windows.Forms.Button();
            this.panelMiddle_DSN = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецДиагнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.амбулаторноеЛечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipGraph_DSN = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).BeginInit();
            this.panelNiz_DSN.SuspendLayout();
            this.panelMiddle_DSN.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_DSN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DSN.ChartAreas.Add(chartArea1);
            this.chartFunction_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            this.chartFunction_DSN.Legends.Add(legend1);
            this.chartFunction_DSN.Location = new System.Drawing.Point(0, 24);
            this.chartFunction_DSN.Name = "chartFunction_DSN";
            this.chartFunction_DSN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkSlateGray;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DSN.Series.Add(series1);
            this.chartFunction_DSN.Size = new System.Drawing.Size(1364, 605);
            this.chartFunction_DSN.TabIndex = 0;
            // 
            // panelNiz_DSN
            // 
            this.panelNiz_DSN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNiz_DSN.Controls.Add(this.buttonBack_DSN);
            this.panelNiz_DSN.Controls.Add(this.buttonSaveGraph_DSN);
            this.panelNiz_DSN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNiz_DSN.Location = new System.Drawing.Point(0, 629);
            this.panelNiz_DSN.Name = "panelNiz_DSN";
            this.panelNiz_DSN.Size = new System.Drawing.Size(1364, 83);
            this.panelNiz_DSN.TabIndex = 1;
            // 
            // buttonBack_DSN
            // 
            this.buttonBack_DSN.Location = new System.Drawing.Point(12, 12);
            this.buttonBack_DSN.Name = "buttonBack_DSN";
            this.buttonBack_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonBack_DSN.TabIndex = 2;
            this.buttonBack_DSN.Text = "Ок";
            this.buttonBack_DSN.UseVisualStyleBackColor = true;
            this.buttonBack_DSN.Click += new System.EventHandler(this.buttonBack_DSN_Click);
            // 
            // buttonSaveGraph_DSN
            // 
            this.buttonSaveGraph_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveGraph_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_save_2550350;
            this.buttonSaveGraph_DSN.Location = new System.Drawing.Point(1280, 12);
            this.buttonSaveGraph_DSN.Name = "buttonSaveGraph_DSN";
            this.buttonSaveGraph_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonSaveGraph_DSN.TabIndex = 1;
            this.toolTipGraph_DSN.SetToolTip(this.buttonSaveGraph_DSN, "Сохраняет диаграмму");
            this.buttonSaveGraph_DSN.UseVisualStyleBackColor = true;
            this.buttonSaveGraph_DSN.Click += new System.EventHandler(this.buttonSaveGraph_DSN_Click);
            // 
            // panelMiddle_DSN
            // 
            this.panelMiddle_DSN.Controls.Add(this.chartFunction_DSN);
            this.panelMiddle_DSN.Controls.Add(this.menuStrip1);
            this.panelMiddle_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelMiddle_DSN.Name = "panelMiddle_DSN";
            this.panelMiddle_DSN.Size = new System.Drawing.Size(1364, 629);
            this.panelMiddle_DSN.TabIndex = 4;
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
            this.выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            // toolTipGraph_DSN
            // 
            this.toolTipGraph_DSN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGraph_DSN.ToolTipTitle = "Подсказка";
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 712);
            this.Controls.Add(this.panelMiddle_DSN);
            this.Controls.Add(this.panelNiz_DSN);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График функции";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DSN)).EndInit();
            this.panelNiz_DSN.ResumeLayout(false);
            this.panelMiddle_DSN.ResumeLayout(false);
            this.panelMiddle_DSN.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DSN;
        private System.Windows.Forms.Panel panelNiz_DSN;
        private System.Windows.Forms.Panel panelMiddle_DSN;
        private System.Windows.Forms.Button buttonSaveGraph_DSN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбиритеСтолбецДляПостроенияДиаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецДиагнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem амбулаторноеЛечениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьВрачаToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack_DSN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTipGraph_DSN;
    }
}