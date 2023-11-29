
namespace Tyuiu.BorodulinMS.Sprint6.Task0.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxInputData_BMS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_BMS = new System.Windows.Forms.GroupBox();
            this.buttonPushMe_BMS = new System.Windows.Forms.Button();
            this.labelResult_BMS = new System.Windows.Forms.Label();
            this.textBoxResult_BMS = new System.Windows.Forms.TextBox();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.labelTask_BMS = new System.Windows.Forms.Label();
            this.pictureBoxFormula_BMS = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_BMS.SuspendLayout();
            this.groupBoxResult_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputData_BMS
            // 
            this.groupBoxInputData_BMS.Controls.Add(this.labelTask_BMS);
            this.groupBoxInputData_BMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputData_BMS.Name = "groupBoxInputData_BMS";
            this.groupBoxInputData_BMS.Size = new System.Drawing.Size(382, 176);
            this.groupBoxInputData_BMS.TabIndex = 0;
            this.groupBoxInputData_BMS.TabStop = false;
            this.groupBoxInputData_BMS.Text = "Условие:";
            this.groupBoxInputData_BMS.Enter += new System.EventHandler(this.groupBoxInputData_Enter);
            // 
            // groupBoxResult_BMS
            // 
            this.groupBoxResult_BMS.Controls.Add(this.textBoxResult_BMS);
            this.groupBoxResult_BMS.Controls.Add(this.labelResult_BMS);
            this.groupBoxResult_BMS.Location = new System.Drawing.Point(12, 194);
            this.groupBoxResult_BMS.Name = "groupBoxResult_BMS";
            this.groupBoxResult_BMS.Size = new System.Drawing.Size(386, 141);
            this.groupBoxResult_BMS.TabIndex = 1;
            this.groupBoxResult_BMS.TabStop = false;
            this.groupBoxResult_BMS.Text = "Вывод:";
            // 
            // buttonPushMe_BMS
            // 
            this.buttonPushMe_BMS.Location = new System.Drawing.Point(599, 328);
            this.buttonPushMe_BMS.Name = "buttonPushMe_BMS";
            this.buttonPushMe_BMS.Size = new System.Drawing.Size(165, 92);
            this.buttonPushMe_BMS.TabIndex = 0;
            this.buttonPushMe_BMS.Text = "Нажми на меня и увидишь результат!";
            this.buttonPushMe_BMS.UseVisualStyleBackColor = true;
            this.buttonPushMe_BMS.Click += new System.EventHandler(this.buttonPushMe_BMS_Click);
            // 
            // labelResult_BMS
            // 
            this.labelResult_BMS.AutoSize = true;
            this.labelResult_BMS.Location = new System.Drawing.Point(6, 35);
            this.labelResult_BMS.Name = "labelResult_BMS";
            this.labelResult_BMS.Size = new System.Drawing.Size(93, 20);
            this.labelResult_BMS.TabIndex = 1;
            this.labelResult_BMS.Text = "Результат:";
            // 
            // textBoxResult_BMS
            // 
            this.textBoxResult_BMS.Location = new System.Drawing.Point(6, 58);
            this.textBoxResult_BMS.Name = "textBoxResult_BMS";
            this.textBoxResult_BMS.ReadOnly = true;
            this.textBoxResult_BMS.Size = new System.Drawing.Size(112, 26);
            this.textBoxResult_BMS.TabIndex = 2;
            // 
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BMS.Location = new System.Drawing.Point(492, 328);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(101, 92);
            this.buttonHelp_BMS.TabIndex = 3;
            this.buttonHelp_BMS.Text = "?";
            this.buttonHelp_BMS.UseVisualStyleBackColor = true;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            // 
            // labelTask_BMS
            // 
            this.labelTask_BMS.Location = new System.Drawing.Point(33, 38);
            this.labelTask_BMS.Name = "labelTask_BMS";
            this.labelTask_BMS.Size = new System.Drawing.Size(353, 94);
            this.labelTask_BMS.TabIndex = 2;
            this.labelTask_BMS.Text = "Дано выражение. Вычислить его значение при x = 3, результат вывести в TextBox. Ок" +
    "руглить до трех знаков после запятой";
            // 
            // pictureBoxFormula_BMS
            // 
            this.pictureBoxFormula_BMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BMS.Image")));
            this.pictureBoxFormula_BMS.Location = new System.Drawing.Point(427, 50);
            this.pictureBoxFormula_BMS.Name = "pictureBoxFormula_BMS";
            this.pictureBoxFormula_BMS.Size = new System.Drawing.Size(226, 45);
            this.pictureBoxFormula_BMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_BMS.TabIndex = 4;
            this.pictureBoxFormula_BMS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFormula_BMS);
            this.Controls.Add(this.buttonHelp_BMS);
            this.Controls.Add(this.groupBoxResult_BMS);
            this.Controls.Add(this.groupBoxInputData_BMS);
            this.Controls.Add(this.buttonPushMe_BMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 30 | Бородулин М.С";
            this.groupBoxInputData_BMS.ResumeLayout(false);
            this.groupBoxResult_BMS.ResumeLayout(false);
            this.groupBoxResult_BMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData_BMS;
        private System.Windows.Forms.GroupBox groupBoxResult_BMS;
        private System.Windows.Forms.TextBox textBoxResult_BMS;
        private System.Windows.Forms.Label labelResult_BMS;
        private System.Windows.Forms.Button buttonPushMe_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Label labelTask_BMS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BMS;
    }
}

