
namespace Tyuiu.BorodulinMS.Sprint6.Task7.V16
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_BMS = new System.Windows.Forms.PictureBox();
            this.labelInfo_BMS = new System.Windows.Forms.Label();
            this.buttonOk_BMS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_BMS
            // 
            this.pictureBoxAvatar_BMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_BMS.Image")));
            this.pictureBoxAvatar_BMS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_BMS.Name = "pictureBoxAvatar_BMS";
            this.pictureBoxAvatar_BMS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pictureBoxAvatar_BMS.Size = new System.Drawing.Size(323, 426);
            this.pictureBoxAvatar_BMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_BMS.TabIndex = 0;
            this.pictureBoxAvatar_BMS.TabStop = false;
            // 
            // labelInfo_BMS
            // 
            this.labelInfo_BMS.AutoSize = true;
            this.labelInfo_BMS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelInfo_BMS.Location = new System.Drawing.Point(357, 34);
            this.labelInfo_BMS.Name = "labelInfo_BMS";
            this.labelInfo_BMS.Size = new System.Drawing.Size(413, 180);
            this.labelInfo_BMS.TabIndex = 1;
            this.labelInfo_BMS.Text = resources.GetString("labelInfo_BMS.Text");
            // 
            // buttonOk_BMS
            // 
            this.buttonOk_BMS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOk_BMS.Location = new System.Drawing.Point(648, 355);
            this.buttonOk_BMS.Name = "buttonOk_BMS";
            this.buttonOk_BMS.Size = new System.Drawing.Size(107, 39);
            this.buttonOk_BMS.TabIndex = 2;
            this.buttonOk_BMS.Text = "Ok";
            this.buttonOk_BMS.UseVisualStyleBackColor = false;
            this.buttonOk_BMS.Click += new System.EventHandler(this.buttonOk_BMS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk_BMS);
            this.Controls.Add(this.labelInfo_BMS);
            this.Controls.Add(this.pictureBoxAvatar_BMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_BMS;
        private System.Windows.Forms.Label labelInfo_BMS;
        private System.Windows.Forms.Button buttonOk_BMS;
    }
}