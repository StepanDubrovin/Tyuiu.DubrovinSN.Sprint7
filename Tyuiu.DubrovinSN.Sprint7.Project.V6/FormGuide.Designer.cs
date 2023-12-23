
namespace Tyuiu.DubrovinSN.Sprint7.Project.V6
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.buttonOk_DSN = new System.Windows.Forms.Button();
            this.labelRuc_DSN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk_DSN
            // 
            this.buttonOk_DSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk_DSN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_DSN.Location = new System.Drawing.Point(1404, 679);
            this.buttonOk_DSN.Name = "buttonOk_DSN";
            this.buttonOk_DSN.Size = new System.Drawing.Size(53, 47);
            this.buttonOk_DSN.TabIndex = 0;
            this.buttonOk_DSN.Text = "Ок";
            this.buttonOk_DSN.UseVisualStyleBackColor = true;
            this.buttonOk_DSN.Click += new System.EventHandler(this.buttonOk_DSN_Click);
            // 
            // labelRuc_DSN
            // 
            this.labelRuc_DSN.AutoSize = true;
            this.labelRuc_DSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRuc_DSN.Location = new System.Drawing.Point(2, 9);
            this.labelRuc_DSN.Name = "labelRuc_DSN";
            this.labelRuc_DSN.Size = new System.Drawing.Size(1438, 580);
            this.labelRuc_DSN.TabIndex = 1;
            this.labelRuc_DSN.Text = resources.GetString("labelRuc_DSN.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 738);
            this.Controls.Add(this.labelRuc_DSN);
            this.Controls.Add(this.buttonOk_DSN);
            this.Name = "FormGuide";
            this.Text = "Руководство по использованию приложения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_DSN;
        private System.Windows.Forms.Label labelRuc_DSN;
    }
}