
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
            this.buttonViltr_DSN = new System.Windows.Forms.Button();
            this.labelVibor_DSN = new System.Windows.Forms.Label();
            this.textBoxVibor_DSN = new System.Windows.Forms.TextBox();
            this.groupBoxSearch_DSN = new System.Windows.Forms.GroupBox();
            this.textBoxReserch_DSN = new System.Windows.Forms.TextBox();
            this.label_Ser_DSN = new System.Windows.Forms.Label();
            this.panelLeft_DSN = new System.Windows.Forms.Panel();
            this.groupBoxButtons_DSN = new System.Windows.Forms.GroupBox();
            this.buttonDelete_DSN = new System.Windows.Forms.Button();
            this.buttonFunction_DSN = new System.Windows.Forms.Button();
            this.buttonSaveFile_DSN = new System.Windows.Forms.Button();
            this.buttonOpenFile_DSN = new System.Windows.Forms.Button();
            this.panelFuncIn_DSN = new System.Windows.Forms.Panel();
            this.groupBox_Input_DSN = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_DSN = new System.Windows.Forms.DataGridView();
            this.menuStripSort_DSN = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецИмяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецОтчесвтоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецВозрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецВремяЛеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецКабинетДоктораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSerch_DSN = new System.Windows.Forms.Button();
            this.panelUp_DSN.SuspendLayout();
            this.groupBoxViltr_DSN.SuspendLayout();
            this.groupBoxSearch_DSN.SuspendLayout();
            this.panelLeft_DSN.SuspendLayout();
            this.groupBoxButtons_DSN.SuspendLayout();
            this.panelFuncIn_DSN.SuspendLayout();
            this.groupBox_Input_DSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).BeginInit();
            this.menuStripSort_DSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_DSN
            // 
            this.panelUp_DSN.BackColor = System.Drawing.SystemColors.Control;
            this.panelUp_DSN.Controls.Add(this.groupBoxViltr_DSN);
            this.panelUp_DSN.Controls.Add(this.groupBoxSearch_DSN);
            this.panelUp_DSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_DSN.Location = new System.Drawing.Point(0, 0);
            this.panelUp_DSN.Name = "panelUp_DSN";
            this.panelUp_DSN.Size = new System.Drawing.Size(1379, 153);
            this.panelUp_DSN.TabIndex = 0;
            // 
            // groupBoxViltr_DSN
            // 
            this.groupBoxViltr_DSN.Controls.Add(this.buttonViltr_DSN);
            this.groupBoxViltr_DSN.Controls.Add(this.labelVibor_DSN);
            this.groupBoxViltr_DSN.Controls.Add(this.textBoxVibor_DSN);
            this.groupBoxViltr_DSN.Location = new System.Drawing.Point(328, 12);
            this.groupBoxViltr_DSN.Name = "groupBoxViltr_DSN";
            this.groupBoxViltr_DSN.Size = new System.Drawing.Size(312, 135);
            this.groupBoxViltr_DSN.TabIndex = 2;
            this.groupBoxViltr_DSN.TabStop = false;
            this.groupBoxViltr_DSN.Text = "Фильтрация";
            // 
            // buttonViltr_DSN
            // 
            this.buttonViltr_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_filtering_6303429;
            this.buttonViltr_DSN.Location = new System.Drawing.Point(234, 68);
            this.buttonViltr_DSN.Name = "buttonViltr_DSN";
            this.buttonViltr_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonViltr_DSN.TabIndex = 4;
            this.buttonViltr_DSN.UseVisualStyleBackColor = true;
            this.buttonViltr_DSN.Click += new System.EventHandler(this.buttonViltr_DSN_Click);
            // 
            // labelVibor_DSN
            // 
            this.labelVibor_DSN.AutoSize = true;
            this.labelVibor_DSN.Location = new System.Drawing.Point(6, 31);
            this.labelVibor_DSN.Name = "labelVibor_DSN";
            this.labelVibor_DSN.Size = new System.Drawing.Size(204, 13);
            this.labelVibor_DSN.TabIndex = 3;
            this.labelVibor_DSN.Text = "Укажите нужный парметр фильтрации";
            // 
            // textBoxVibor_DSN
            // 
            this.textBoxVibor_DSN.Location = new System.Drawing.Point(6, 61);
            this.textBoxVibor_DSN.Multiline = true;
            this.textBoxVibor_DSN.Name = "textBoxVibor_DSN";
            this.textBoxVibor_DSN.Size = new System.Drawing.Size(178, 20);
            this.textBoxVibor_DSN.TabIndex = 2;
            // 
            // groupBoxSearch_DSN
            // 
            this.groupBoxSearch_DSN.Controls.Add(this.buttonSerch_DSN);
            this.groupBoxSearch_DSN.Controls.Add(this.textBoxReserch_DSN);
            this.groupBoxSearch_DSN.Controls.Add(this.label_Ser_DSN);
            this.groupBoxSearch_DSN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch_DSN.Name = "groupBoxSearch_DSN";
            this.groupBoxSearch_DSN.Size = new System.Drawing.Size(312, 135);
            this.groupBoxSearch_DSN.TabIndex = 0;
            this.groupBoxSearch_DSN.TabStop = false;
            this.groupBoxSearch_DSN.Text = "Поиск";
            // 
            // textBoxReserch_DSN
            // 
            this.textBoxReserch_DSN.Location = new System.Drawing.Point(9, 61);
            this.textBoxReserch_DSN.Name = "textBoxReserch_DSN";
            this.textBoxReserch_DSN.Size = new System.Drawing.Size(178, 20);
            this.textBoxReserch_DSN.TabIndex = 2;
            // 
            // label_Ser_DSN
            // 
            this.label_Ser_DSN.AutoSize = true;
            this.label_Ser_DSN.Location = new System.Drawing.Point(6, 31);
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
            this.buttonDelete_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_clear_3602045;
            this.buttonDelete_DSN.Location = new System.Drawing.Point(12, 443);
            this.buttonDelete_DSN.Name = "buttonDelete_DSN";
            this.buttonDelete_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonDelete_DSN.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonDelete_DSN, "Очищает таблицу с данными");
            this.buttonDelete_DSN.UseVisualStyleBackColor = true;
            this.buttonDelete_DSN.Click += new System.EventHandler(this.buttonDelete_DSN_Click);
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
            this.panelFuncIn_DSN.Controls.Add(this.groupBox_Input_DSN);
            this.panelFuncIn_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuncIn_DSN.Location = new System.Drawing.Point(100, 153);
            this.panelFuncIn_DSN.Name = "panelFuncIn_DSN";
            this.panelFuncIn_DSN.Size = new System.Drawing.Size(1279, 516);
            this.panelFuncIn_DSN.TabIndex = 2;
            // 
            // groupBox_Input_DSN
            // 
            this.groupBox_Input_DSN.Controls.Add(this.dataGridViewInMatrix_DSN);
            this.groupBox_Input_DSN.Controls.Add(this.menuStripSort_DSN);
            this.groupBox_Input_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Input_DSN.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Input_DSN.Name = "groupBox_Input_DSN";
            this.groupBox_Input_DSN.Size = new System.Drawing.Size(1279, 516);
            this.groupBox_Input_DSN.TabIndex = 0;
            this.groupBox_Input_DSN.TabStop = false;
            this.groupBox_Input_DSN.Text = "Информация о пациентах";
            // 
            // dataGridViewInMatrix_DSN
            // 
            this.dataGridViewInMatrix_DSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_DSN.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_DSN.Location = new System.Drawing.Point(3, 40);
            this.dataGridViewInMatrix_DSN.Name = "dataGridViewInMatrix_DSN";
            this.dataGridViewInMatrix_DSN.RowHeadersVisible = false;
            this.dataGridViewInMatrix_DSN.Size = new System.Drawing.Size(1273, 473);
            this.dataGridViewInMatrix_DSN.TabIndex = 0;
            // 
            // menuStripSort_DSN
            // 
            this.menuStripSort_DSN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.aToolStripMenuItem});
            this.menuStripSort_DSN.Location = new System.Drawing.Point(3, 16);
            this.menuStripSort_DSN.Name = "menuStripSort_DSN";
            this.menuStripSort_DSN.Size = new System.Drawing.Size(1273, 24);
            this.menuStripSort_DSN.TabIndex = 1;
            this.menuStripSort_DSN.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецФамилияToolStripMenuItem,
            this.столбецИмяToolStripMenuItem,
            this.столбецОтчесвтоToolStripMenuItem});
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.xToolStripMenuItem.Text = "По возрастанию";
            // 
            // столбецФамилияToolStripMenuItem
            // 
            this.столбецФамилияToolStripMenuItem.Name = "столбецФамилияToolStripMenuItem";
            this.столбецФамилияToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецФамилияToolStripMenuItem.Text = "Столбец \"Возраст\"";
            // 
            // столбецИмяToolStripMenuItem
            // 
            this.столбецИмяToolStripMenuItem.Name = "столбецИмяToolStripMenuItem";
            this.столбецИмяToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецИмяToolStripMenuItem.Text = "Столбец \"Время лечения\"";
            // 
            // столбецОтчесвтоToolStripMenuItem
            // 
            this.столбецОтчесвтоToolStripMenuItem.Name = "столбецОтчесвтоToolStripMenuItem";
            this.столбецОтчесвтоToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецОтчесвтоToolStripMenuItem.Text = "Столбец \"Кабинет доктора\"";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецВозрастToolStripMenuItem,
            this.столбецВремяЛеченияToolStripMenuItem,
            this.столбецКабинетДоктораToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aToolStripMenuItem.Text = "По убыванию";
            // 
            // столбецВозрастToolStripMenuItem
            // 
            this.столбецВозрастToolStripMenuItem.Name = "столбецВозрастToolStripMenuItem";
            this.столбецВозрастToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецВозрастToolStripMenuItem.Text = "Столбец \"Возраст\"";
            // 
            // столбецВремяЛеченияToolStripMenuItem
            // 
            this.столбецВремяЛеченияToolStripMenuItem.Name = "столбецВремяЛеченияToolStripMenuItem";
            this.столбецВремяЛеченияToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецВремяЛеченияToolStripMenuItem.Text = "Столбец \"Время лечения\"";
            // 
            // столбецКабинетДоктораToolStripMenuItem
            // 
            this.столбецКабинетДоктораToolStripMenuItem.Name = "столбецКабинетДоктораToolStripMenuItem";
            this.столбецКабинетДоктораToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.столбецКабинетДоктораToolStripMenuItem.Text = "Столбец \"Кабинет доктора\"";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonSerch_DSN
            // 
            this.buttonSerch_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_search_4194705;
            this.buttonSerch_DSN.Location = new System.Drawing.Point(234, 68);
            this.buttonSerch_DSN.Name = "buttonSerch_DSN";
            this.buttonSerch_DSN.Size = new System.Drawing.Size(72, 61);
            this.buttonSerch_DSN.TabIndex = 3;
            this.buttonSerch_DSN.UseVisualStyleBackColor = true;
            this.buttonSerch_DSN.Click += new System.EventHandler(this.buttonSerch_DSN_Click);
            // 
            // FormPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 669);
            this.Controls.Add(this.panelFuncIn_DSN);
            this.Controls.Add(this.panelLeft_DSN);
            this.Controls.Add(this.panelUp_DSN);
            this.MainMenuStrip = this.menuStripSort_DSN;
            this.Name = "FormPacient";
            this.Text = "Пациенты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUp_DSN.ResumeLayout(false);
            this.groupBoxViltr_DSN.ResumeLayout(false);
            this.groupBoxViltr_DSN.PerformLayout();
            this.groupBoxSearch_DSN.ResumeLayout(false);
            this.groupBoxSearch_DSN.PerformLayout();
            this.panelLeft_DSN.ResumeLayout(false);
            this.groupBoxButtons_DSN.ResumeLayout(false);
            this.panelFuncIn_DSN.ResumeLayout(false);
            this.groupBox_Input_DSN.ResumeLayout(false);
            this.groupBox_Input_DSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_DSN)).EndInit();
            this.menuStripSort_DSN.ResumeLayout(false);
            this.menuStripSort_DSN.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxViltr_DSN;
        private System.Windows.Forms.GroupBox groupBox_Input_DSN;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_DSN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelVibor_DSN;
        private System.Windows.Forms.TextBox textBoxVibor_DSN;
        private System.Windows.Forms.Button buttonViltr_DSN;
        private System.Windows.Forms.MenuStrip menuStripSort_DSN;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецФамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецИмяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецОтчесвтоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецВозрастToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецВремяЛеченияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецКабинетДоктораToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxReserch_DSN;
        private System.Windows.Forms.Button buttonSerch_DSN;
    }
}