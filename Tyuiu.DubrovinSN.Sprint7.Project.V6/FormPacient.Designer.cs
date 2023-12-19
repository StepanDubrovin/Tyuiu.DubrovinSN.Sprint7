
namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    partial class FormPacient
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
            this.panelUp_DSN = new System.Windows.Forms.Panel();
            this.groupBoxViltr_DSN = new System.Windows.Forms.GroupBox();
            this.labelFun_DSN = new System.Windows.Forms.Label();
            this.groupBoxSort_DSN = new System.Windows.Forms.GroupBox();
            this.labelSor_DSN = new System.Windows.Forms.Label();
            this.groupBoxSearch_DSN = new System.Windows.Forms.GroupBox();
            this.label_Ser_DSN = new System.Windows.Forms.Label();
            this.panelLeft_DSN = new System.Windows.Forms.Panel();
            this.groupBoxButtons_DSN = new System.Windows.Forms.GroupBox();
            this.buttonDelete_DSN = new System.Windows.Forms.Button();
            this.buttonFunction_DSN = new System.Windows.Forms.Button();
            this.buttonSaveFile_DSN = new System.Windows.Forms.Button();
            this.buttonOpenFile_DSN = new System.Windows.Forms.Button();
            this.panelFuncIn_DSN = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_DSN = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelUp_DSN.SuspendLayout();
            this.groupBoxViltr_DSN.SuspendLayout();
            this.groupBoxSort_DSN.SuspendLayout();
            this.groupBoxSearch_DSN.SuspendLayout();
            this.panelLeft_DSN.SuspendLayout();
            this.groupBoxButtons_DSN.SuspendLayout();
            this.panelFuncIn_DSN.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_DSN
            // 
            this.panelUp_DSN.BackColor = System.Drawing.SystemColors.Control;
            this.panelUp_DSN.Controls.Add(this.groupBoxViltr_DSN);
            this.panelUp_DSN.Controls.Add(this.groupBoxSort_DSN);
            this.panelUp_DSN.Controls.Add(this.groupBoxSearch_DSN);
            this.panelUp_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelUp_DSN.Name = "panelUp_DSN";
            this.panelUp_DSN.Size = new System.Drawing.Size(1379, 153);
            this.panelUp_DSN.TabIndex = 0;
            // 
            // groupBoxViltr_DSN
            // 
            this.groupBoxViltr_DSN.Controls.Add(this.labelFun_DSN);
            this.groupBoxViltr_DSN.Location = new System.Drawing.Point(447, 27);
            this.groupBoxViltr_DSN.Name = "groupBoxViltr_DSN";
            this.groupBoxViltr_DSN.Size = new System.Drawing.Size(200, 100);
            this.groupBoxViltr_DSN.TabIndex = 2;
            this.groupBoxViltr_DSN.TabStop = false;
            this.groupBoxViltr_DSN.Text = "Фильтрация";
            // 
            // labelFun_DSN
            // 
            this.labelFun_DSN.AutoSize = true;
            this.labelFun_DSN.Location = new System.Drawing.Point(7, 41);
            this.labelFun_DSN.Name = "labelFun_DSN";
            this.labelFun_DSN.Size = new System.Drawing.Size(168, 13);
            this.labelFun_DSN.TabIndex = 0;
            this.labelFun_DSN.Text = "Укажите параметр фильтрации";
            // 
            // groupBoxSort_DSN
            // 
            this.groupBoxSort_DSN.Controls.Add(this.labelSor_DSN);
            this.groupBoxSort_DSN.Location = new System.Drawing.Point(229, 26);
            this.groupBoxSort_DSN.Name = "groupBoxSort_DSN";
            this.groupBoxSort_DSN.Size = new System.Drawing.Size(189, 101);
            this.groupBoxSort_DSN.TabIndex = 1;
            this.groupBoxSort_DSN.TabStop = false;
            this.groupBoxSort_DSN.Text = "Сортировка";
            // 
            // labelSor_DSN
            // 
            this.labelSor_DSN.AutoSize = true;
            this.labelSor_DSN.Location = new System.Drawing.Point(6, 43);
            this.labelSor_DSN.Name = "labelSor_DSN";
            this.labelSor_DSN.Size = new System.Drawing.Size(154, 13);
            this.labelSor_DSN.TabIndex = 0;
            this.labelSor_DSN.Text = "Укажите нужную сортировку";
            // 
            // groupBoxSearch_DSN
            // 
            this.groupBoxSearch_DSN.Controls.Add(this.label_Ser_DSN);
            this.groupBoxSearch_DSN.Location = new System.Drawing.Point(12, 26);
            this.groupBoxSearch_DSN.Name = "groupBoxSearch_DSN";
            this.groupBoxSearch_DSN.Size = new System.Drawing.Size(189, 101);
            this.groupBoxSearch_DSN.TabIndex = 0;
            this.groupBoxSearch_DSN.TabStop = false;
            this.groupBoxSearch_DSN.Text = "Поиск";
            // 
            // label_Ser_DSN
            // 
            this.label_Ser_DSN.AutoSize = true;
            this.label_Ser_DSN.Location = new System.Drawing.Point(3, 43);
            this.label_Ser_DSN.Name = "label_Ser_DSN";
            this.label_Ser_DSN.Size = new System.Drawing.Size(158, 13);
            this.label_Ser_DSN.TabIndex = 1;
            this.label_Ser_DSN.Text = "Укажите элемент для поиска";
            // 
            // panelLeft_DSN
            // 
            this.panelLeft_DSN.Controls.Add(this.groupBoxButtons_DSN);
            this.panelLeft_DSN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DSN.Location = new System.Drawing.Point(0, 153);
            this.panelLeft_DSN.Name = "panelLeft_DSN";
            this.panelLeft_DSN.Size = new System.Drawing.Size(100, 516);
            this.panelLeft_DSN.TabIndex = 1;
            // 
            // groupBoxButtons_DSN
            // 
            this.groupBoxButtons_DSN.Controls.Add(this.buttonDelete_DSN);
            this.groupBoxButtons_DSN.Controls.Add(this.buttonFunction_DSN);
            this.groupBoxButtons_DSN.Controls.Add(this.buttonSaveFile_DSN);
            this.groupBoxButtons_DSN.Controls.Add(this.buttonOpenFile_DSN);
            this.groupBoxButtons_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtons_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_DSN.Name = "groupBoxButtons_DSN";
            this.groupBoxButtons_DSN.Size = new System.Drawing.Size(100, 516);
            this.groupBoxButtons_DSN.TabIndex = 0;
            this.groupBoxButtons_DSN.TabStop = false;
            this.groupBoxButtons_DSN.Text = "Инструменты";
            // 
            // buttonDelete_DSN
            // 
            this.buttonDelete_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_clear_3602045;
            this.buttonDelete_DSN.Location = new System.Drawing.Point(12, 233);
            this.buttonDelete_DSN.Name = "buttonDelete_DSN";
            this.buttonDelete_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonDelete_DSN.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonDelete_DSN, "Очищает таблицу с данными");
            this.buttonDelete_DSN.UseVisualStyleBackColor = true;
            // 
            // buttonFunction_DSN
            // 
            this.buttonFunction_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_graph_8780403;
            this.buttonFunction_DSN.Location = new System.Drawing.Point(12, 166);
            this.buttonFunction_DSN.Name = "buttonFunction_DSN";
            this.buttonFunction_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonFunction_DSN.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonFunction_DSN, "Строит график функции");
            this.buttonFunction_DSN.UseVisualStyleBackColor = true;
            this.buttonFunction_DSN.Click += new System.EventHandler(this.buttonFunction_DSN_Click);
            // 
            // buttonSaveFile_DSN
            // 
            this.buttonSaveFile_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_photo_11918718;
            this.buttonSaveFile_DSN.Location = new System.Drawing.Point(12, 99);
            this.buttonSaveFile_DSN.Name = "buttonSaveFile_DSN";
            this.buttonSaveFile_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonSaveFile_DSN.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonSaveFile_DSN, "Сохраняет файл");
            this.buttonSaveFile_DSN.UseVisualStyleBackColor = true;
            this.buttonSaveFile_DSN.Click += new System.EventHandler(this.buttonSaveFile_DSN_Click);
            // 
            // buttonOpenFile_DSN
            // 
            this.buttonOpenFile_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_open_folder_8406407;
            this.buttonOpenFile_DSN.Location = new System.Drawing.Point(12, 32);
            this.buttonOpenFile_DSN.Name = "buttonOpenFile_DSN";
            this.buttonOpenFile_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonOpenFile_DSN.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile_DSN, "Открывает файл");
            this.buttonOpenFile_DSN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DSN.Click += new System.EventHandler(this.buttonOpenFile_DSN_Click);
            // 
            // panelFuncIn_DSN
            // 
            this.panelFuncIn_DSN.Controls.Add(this.groupBox1);
            this.panelFuncIn_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuncIn_DSN.Location = new System.Drawing.Point(100, 153);
            this.panelFuncIn_DSN.Name = "panelFuncIn_DSN";
            this.panelFuncIn_DSN.Size = new System.Drawing.Size(1279, 516);
            this.panelFuncIn_DSN.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewInMatrix_DSN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходная таблица";
            // 
            // dataGridViewInMatrix_DSN
            // 
            this.dataGridViewInMatrix_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_DSN.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_DSN.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix_DSN.Name = "dataGridViewInMatrix_DSN";
            this.dataGridViewInMatrix_DSN.RowHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Size = new System.Drawing.Size(1273, 497);
            this.dataGridViewInMatrix_DSN.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 669);
            this.Controls.Add(this.panelFuncIn_DSN);
            this.Controls.Add(this.panelLeft_DSN);
            this.Controls.Add(this.panelUp_DSN);
            this.Name = "FormPacient";
            this.Text = "Пациенты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUp_DSN.ResumeLayout(false);
            this.groupBoxViltr_DSN.ResumeLayout(false);
            this.groupBoxViltr_DSN.PerformLayout();
            this.groupBoxSort_DSN.ResumeLayout(false);
            this.groupBoxSort_DSN.PerformLayout();
            this.groupBoxSearch_DSN.ResumeLayout(false);
            this.groupBoxSearch_DSN.PerformLayout();
            this.panelLeft_DSN.ResumeLayout(false);
            this.groupBoxButtons_DSN.ResumeLayout(false);
            this.panelFuncIn_DSN.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_DSN;
        private System.Windows.Forms.Panel panelLeft_DSN;
        private System.Windows.Forms.Panel panelFuncIn_DSN;
        private System.Windows.Forms.GroupBox groupBoxButtons_DSN;
        private System.Windows.Forms.Button buttonFunction_DSN;
        private System.Windows.Forms.Button buttonSaveFile_DSN;
        private System.Windows.Forms.Button buttonOpenFile_DSN;
        private System.Windows.Forms.Button buttonDelete_DSN;
        private System.Windows.Forms.GroupBox groupBoxSearch_DSN;
        private System.Windows.Forms.Label label_Ser_DSN;
        private System.Windows.Forms.GroupBox groupBoxSort_DSN;
        private System.Windows.Forms.Label labelSor_DSN;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxViltr_DSN;
        private System.Windows.Forms.Label labelFun_DSN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_DSN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}