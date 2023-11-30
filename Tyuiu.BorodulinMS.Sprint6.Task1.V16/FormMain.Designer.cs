
namespace Tyuiu.BorodulinMS.Sprint6.Task1.V16
{
    partial class FormMain_BMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BMS));
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_BMS = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BMS = new System.Windows.Forms.TextBox();
            this.labelResult_BMS = new System.Windows.Forms.Label();
            this.groupBoxInPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_BMS = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_BMS = new System.Windows.Forms.TextBox();
            this.labelStopValue_BMS = new System.Windows.Forms.Label();
            this.labelStartValue_BMS = new System.Windows.Forms.Label();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.buttonPushMe_BMS = new System.Windows.Forms.Button();
            this.groupBoxTask_BMS.SuspendLayout();
            this.groupBoxOutPutData_BMS.SuspendLayout();
            this.groupBoxInPutData_BMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxInPutData_BMS);
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(456, 323);
            this.groupBoxTask_BMS.TabIndex = 0;
            this.groupBoxTask_BMS.TabStop = false;
            this.groupBoxTask_BMS.Text = "Условие:";
            // 
            // textBoxInPutData_BMS
            // 
            this.textBoxInPutData_BMS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInPutData_BMS.Location = new System.Drawing.Point(6, 25);
            this.textBoxInPutData_BMS.Multiline = true;
            this.textBoxInPutData_BMS.Name = "textBoxInPutData_BMS";
            this.textBoxInPutData_BMS.ReadOnly = true;
            this.textBoxInPutData_BMS.Size = new System.Drawing.Size(444, 298);
            this.textBoxInPutData_BMS.TabIndex = 0;
            this.textBoxInPutData_BMS.Text = resources.GetString("textBoxInPutData_BMS.Text");
            // 
            // groupBoxOutPutData_BMS
            // 
            this.groupBoxOutPutData_BMS.Controls.Add(this.textBoxResult_BMS);
            this.groupBoxOutPutData_BMS.Controls.Add(this.labelResult_BMS);
            this.groupBoxOutPutData_BMS.Location = new System.Drawing.Point(474, 12);
            this.groupBoxOutPutData_BMS.Name = "groupBoxOutPutData_BMS";
            this.groupBoxOutPutData_BMS.Size = new System.Drawing.Size(314, 426);
            this.groupBoxOutPutData_BMS.TabIndex = 1;
            this.groupBoxOutPutData_BMS.TabStop = false;
            this.groupBoxOutPutData_BMS.Text = "Вывод данных:";
            // 
            // textBoxResult_BMS
            // 
            this.textBoxResult_BMS.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_BMS.Location = new System.Drawing.Point(13, 49);
            this.textBoxResult_BMS.Multiline = true;
            this.textBoxResult_BMS.Name = "textBoxResult_BMS";
            this.textBoxResult_BMS.ReadOnly = true;
            this.textBoxResult_BMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BMS.Size = new System.Drawing.Size(295, 371);
            this.textBoxResult_BMS.TabIndex = 1;
            // 
            // labelResult_BMS
            // 
            this.labelResult_BMS.AutoSize = true;
            this.labelResult_BMS.Location = new System.Drawing.Point(9, 26);
            this.labelResult_BMS.Name = "labelResult_BMS";
            this.labelResult_BMS.Size = new System.Drawing.Size(93, 20);
            this.labelResult_BMS.TabIndex = 0;
            this.labelResult_BMS.Text = "Результат:";
            // 
            // groupBoxInPutData_BMS
            // 
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStopValue_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStartValue_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStopValue_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStartValue_BMS);
            this.groupBoxInPutData_BMS.Location = new System.Drawing.Point(12, 341);
            this.groupBoxInPutData_BMS.Name = "groupBoxInPutData_BMS";
            this.groupBoxInPutData_BMS.Size = new System.Drawing.Size(242, 97);
            this.groupBoxInPutData_BMS.TabIndex = 2;
            this.groupBoxInPutData_BMS.TabStop = false;
            this.groupBoxInPutData_BMS.Text = "Ввод данных:";
            // 
            // textBoxStopValue_BMS
            // 
            this.textBoxStopValue_BMS.Location = new System.Drawing.Point(133, 49);
            this.textBoxStopValue_BMS.Name = "textBoxStopValue_BMS";
            this.textBoxStopValue_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopValue_BMS.TabIndex = 3;
            this.textBoxStopValue_BMS.Text = "5";
            // 
            // textBoxStartValue_BMS
            // 
            this.textBoxStartValue_BMS.Location = new System.Drawing.Point(11, 50);
            this.textBoxStartValue_BMS.Name = "textBoxStartValue_BMS";
            this.textBoxStartValue_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartValue_BMS.TabIndex = 2;
            this.textBoxStartValue_BMS.Text = "-5";
            // 
            // labelStopValue_BMS
            // 
            this.labelStopValue_BMS.AutoSize = true;
            this.labelStopValue_BMS.Location = new System.Drawing.Point(129, 25);
            this.labelStopValue_BMS.Name = "labelStopValue_BMS";
            this.labelStopValue_BMS.Size = new System.Drawing.Size(101, 20);
            this.labelStopValue_BMS.TabIndex = 1;
            this.labelStopValue_BMS.Text = "Конец шага:";
            // 
            // labelStartValue_BMS
            // 
            this.labelStartValue_BMS.AutoSize = true;
            this.labelStartValue_BMS.Location = new System.Drawing.Point(7, 26);
            this.labelStartValue_BMS.Name = "labelStartValue_BMS";
            this.labelStartValue_BMS.Size = new System.Drawing.Size(102, 20);
            this.labelStartValue_BMS.TabIndex = 0;
            this.labelStartValue_BMS.Text = "Старт шага:";
            // 
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_BMS.Location = new System.Drawing.Point(260, 350);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(92, 88);
            this.buttonHelp_BMS.TabIndex = 3;
            this.buttonHelp_BMS.Text = "Справка";
            this.buttonHelp_BMS.UseVisualStyleBackColor = false;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            // 
            // buttonPushMe_BMS
            // 
            this.buttonPushMe_BMS.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_BMS.Location = new System.Drawing.Point(358, 350);
            this.buttonPushMe_BMS.Name = "buttonPushMe_BMS";
            this.buttonPushMe_BMS.Size = new System.Drawing.Size(110, 88);
            this.buttonPushMe_BMS.TabIndex = 4;
            this.buttonPushMe_BMS.Text = "Выполнить";
            this.buttonPushMe_BMS.UseVisualStyleBackColor = false;
            this.buttonPushMe_BMS.Click += new System.EventHandler(this.buttonPushMe_Click);
            // 
            // FormMain_BMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPushMe_BMS);
            this.Controls.Add(this.buttonHelp_BMS);
            this.Controls.Add(this.groupBoxInPutData_BMS);
            this.Controls.Add(this.groupBoxOutPutData_BMS);
            this.Controls.Add(this.groupBoxTask_BMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_BMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 16 | Бородулин М.С";
            this.Load += new System.EventHandler(this.FormMain_BMS_Load);
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.groupBoxOutPutData_BMS.ResumeLayout(false);
            this.groupBoxOutPutData_BMS.PerformLayout();
            this.groupBoxInPutData_BMS.ResumeLayout(false);
            this.groupBoxInPutData_BMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxInPutData_BMS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BMS;
        private System.Windows.Forms.TextBox textBoxResult_BMS;
        private System.Windows.Forms.Label labelResult_BMS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_BMS;
        private System.Windows.Forms.TextBox textBoxStopValue_BMS;
        private System.Windows.Forms.TextBox textBoxStartValue_BMS;
        private System.Windows.Forms.Label labelStopValue_BMS;
        private System.Windows.Forms.Label labelStartValue_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Button buttonPushMe_BMS;
    }
}

