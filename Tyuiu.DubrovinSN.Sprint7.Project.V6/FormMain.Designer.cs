
namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    partial class FormMain
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfoRazrab_DSN = new System.Windows.Forms.Button();
            this.buttonMedical_DSN = new System.Windows.Forms.Button();
            this.buttonPatients_DSN = new System.Windows.Forms.Button();
            this.buttonInfo_DSN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonInfoRazrab_DSN
            // 
            this.buttonInfoRazrab_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfoRazrab_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_id_card_9386768;
            this.buttonInfoRazrab_DSN.Location = new System.Drawing.Point(12, 587);
            this.buttonInfoRazrab_DSN.Name = "buttonInfoRazrab_DSN";
            this.buttonInfoRazrab_DSN.Size = new System.Drawing.Size(76, 77);
            this.buttonInfoRazrab_DSN.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonInfoRazrab_DSN, "Информация о программе");
            this.buttonInfoRazrab_DSN.UseVisualStyleBackColor = true;
            this.buttonInfoRazrab_DSN.Click += new System.EventHandler(this.buttonInfoRazrab_DSN_Click);
            // 
            // buttonMedical_DSN
            // 
            this.buttonMedical_DSN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMedical_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_nurse_10342190;
            this.buttonMedical_DSN.Location = new System.Drawing.Point(891, 163);
            this.buttonMedical_DSN.Name = "buttonMedical_DSN";
            this.buttonMedical_DSN.Size = new System.Drawing.Size(314, 296);
            this.buttonMedical_DSN.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonMedical_DSN, "Инормация о врачах");
            this.buttonMedical_DSN.UseVisualStyleBackColor = true;
            this.buttonMedical_DSN.Click += new System.EventHandler(this.buttonMedical_DSN_Click);
            // 
            // buttonPatients_DSN
            // 
            this.buttonPatients_DSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPatients_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_patient_4465493__2_;
            this.buttonPatients_DSN.Location = new System.Drawing.Point(12, 163);
            this.buttonPatients_DSN.Name = "buttonPatients_DSN";
            this.buttonPatients_DSN.Size = new System.Drawing.Size(314, 296);
            this.buttonPatients_DSN.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonPatients_DSN, "Информация о пациентах");
            this.buttonPatients_DSN.UseVisualStyleBackColor = true;
            this.buttonPatients_DSN.Click += new System.EventHandler(this.buttonPatients_DSN_Click);
            // 
            // buttonInfo_DSN
            // 
            this.buttonInfo_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_DSN.Image = global::Tyuiu.DubrovinSN.Sprint7.Project.V6.Properties.Resources.free_icon_info_943579;
            this.buttonInfo_DSN.Location = new System.Drawing.Point(1129, 587);
            this.buttonInfo_DSN.Name = "buttonInfo_DSN";
            this.buttonInfo_DSN.Size = new System.Drawing.Size(76, 77);
            this.buttonInfo_DSN.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonInfo_DSN, "Руководство");
            this.buttonInfo_DSN.UseVisualStyleBackColor = true;
            this.buttonInfo_DSN.Click += new System.EventHandler(this.buttonInfo_DSN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 676);
            this.Controls.Add(this.buttonInfoRazrab_DSN);
            this.Controls.Add(this.buttonMedical_DSN);
            this.Controls.Add(this.buttonPatients_DSN);
            this.Controls.Add(this.buttonInfo_DSN);
            this.Name = "FormMain";
            this.Text = "Информация о пациаентах и докторах ГАУЗ ТО Городской поликлиники №1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInfo_DSN;
        private System.Windows.Forms.Button buttonPatients_DSN;
        private System.Windows.Forms.Button buttonMedical_DSN;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonInfoRazrab_DSN;
    }
}

