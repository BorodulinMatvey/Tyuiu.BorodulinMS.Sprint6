
namespace Tyuiu.BorodulinMS.Sprint6.Task4.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BMS = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_BMS = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BMS = new System.Windows.Forms.TextBox();
            this.labelStopStep_BMS = new System.Windows.Forms.Label();
            this.labelStartStep_BMS = new System.Windows.Forms.Label();
            this.buttonDone_BMS = new System.Windows.Forms.Button();
            this.buttonSave_BMS = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BMS = new System.Windows.Forms.TextBox();
            this.chartFunction_BMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.panelnPutData_BMS = new System.Windows.Forms.Panel();
            this.panelOutPutData_BMS = new System.Windows.Forms.Panel();
            this.splitterOutPutData_BMS = new System.Windows.Forms.Splitter();
            this.panelResult_BMS = new System.Windows.Forms.Panel();
            this.groupBoxTask_BMS.SuspendLayout();
            this.groupBoxInPutData_BMS.SuspendLayout();
            this.groupBoxOutPutData_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).BeginInit();
            this.panelnPutData_BMS.SuspendLayout();
            this.panelOutPutData_BMS.SuspendLayout();
            this.panelResult_BMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxTask_BMS);
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(519, 122);
            this.groupBoxTask_BMS.TabIndex = 0;
            this.groupBoxTask_BMS.TabStop = false;
            this.groupBoxTask_BMS.Text = "Условие";
            // 
            // textBoxTask_BMS
            // 
            this.textBoxTask_BMS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_BMS.Multiline = true;
            this.textBoxTask_BMS.Name = "textBoxTask_BMS";
            this.textBoxTask_BMS.ReadOnly = true;
            this.textBoxTask_BMS.Size = new System.Drawing.Size(507, 91);
            this.textBoxTask_BMS.TabIndex = 0;
            this.textBoxTask_BMS.Text = "Протабулировать функцию F(x) = sin(x) / x + 1.7 - cos(x) * 4 * x - 6 на заданном " +
    "диапазоне от -5 до 5. Результат вывести в textBox, построить график функциии сох" +
    "ранить в файле OutPutFileTask4.txt";
            // 
            // groupBoxInPutData_BMS
            // 
            this.groupBoxInPutData_BMS.BackColor = System.Drawing.Color.White;
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStopStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStartStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStopStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStartStep_BMS);
            this.groupBoxInPutData_BMS.Location = new System.Drawing.Point(554, 12);
            this.groupBoxInPutData_BMS.Name = "groupBoxInPutData_BMS";
            this.groupBoxInPutData_BMS.Size = new System.Drawing.Size(344, 122);
            this.groupBoxInPutData_BMS.TabIndex = 1;
            this.groupBoxInPutData_BMS.TabStop = false;
            this.groupBoxInPutData_BMS.Text = "Ввод данных";
            // 
            // textBoxStopStep_BMS
            // 
            this.textBoxStopStep_BMS.Location = new System.Drawing.Point(191, 50);
            this.textBoxStopStep_BMS.Name = "textBoxStopStep_BMS";
            this.textBoxStopStep_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopStep_BMS.TabIndex = 1;
            this.textBoxStopStep_BMS.Text = "5";
            // 
            // textBoxStartStep_BMS
            // 
            this.textBoxStartStep_BMS.Location = new System.Drawing.Point(11, 50);
            this.textBoxStartStep_BMS.Name = "textBoxStartStep_BMS";
            this.textBoxStartStep_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep_BMS.TabIndex = 1;
            this.textBoxStartStep_BMS.Text = "-5";
            // 
            // labelStopStep_BMS
            // 
            this.labelStopStep_BMS.AutoSize = true;
            this.labelStopStep_BMS.Location = new System.Drawing.Point(187, 26);
            this.labelStopStep_BMS.Name = "labelStopStep_BMS";
            this.labelStopStep_BMS.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_BMS.TabIndex = 0;
            this.labelStopStep_BMS.Text = "Конец шага:";
            // 
            // labelStartStep_BMS
            // 
            this.labelStartStep_BMS.AutoSize = true;
            this.labelStartStep_BMS.Location = new System.Drawing.Point(7, 26);
            this.labelStartStep_BMS.Name = "labelStartStep_BMS";
            this.labelStartStep_BMS.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_BMS.TabIndex = 0;
            this.labelStartStep_BMS.Text = "Старт шага:";
            // 
            // buttonDone_BMS
            // 
            this.buttonDone_BMS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BMS.Location = new System.Drawing.Point(904, 46);
            this.buttonDone_BMS.Name = "buttonDone_BMS";
            this.buttonDone_BMS.Size = new System.Drawing.Size(106, 58);
            this.buttonDone_BMS.TabIndex = 2;
            this.buttonDone_BMS.Text = "Выполнить";
            this.buttonDone_BMS.UseVisualStyleBackColor = false;
            this.buttonDone_BMS.Click += new System.EventHandler(this.buttonDone_BMS_Click);
            // 
            // buttonSave_BMS
            // 
            this.buttonSave_BMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave_BMS.Location = new System.Drawing.Point(1016, 46);
            this.buttonSave_BMS.Name = "buttonSave_BMS";
            this.buttonSave_BMS.Size = new System.Drawing.Size(117, 58);
            this.buttonSave_BMS.TabIndex = 3;
            this.buttonSave_BMS.Text = "Сохранить";
            this.buttonSave_BMS.UseVisualStyleBackColor = false;
            this.buttonSave_BMS.Click += new System.EventHandler(this.buttonSave_BMS_Click);
            // 
            // groupBoxOutPutData_BMS
            // 
            this.groupBoxOutPutData_BMS.Controls.Add(this.textBoxResult_BMS);
            this.groupBoxOutPutData_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_BMS.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPutData_BMS.Name = "groupBoxOutPutData_BMS";
            this.groupBoxOutPutData_BMS.Size = new System.Drawing.Size(365, 584);
            this.groupBoxOutPutData_BMS.TabIndex = 4;
            this.groupBoxOutPutData_BMS.TabStop = false;
            this.groupBoxOutPutData_BMS.Text = "Вывод:";
            // 
            // textBoxResult_BMS
            // 
            this.textBoxResult_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_BMS.Location = new System.Drawing.Point(3, 22);
            this.textBoxResult_BMS.Multiline = true;
            this.textBoxResult_BMS.Name = "textBoxResult_BMS";
            this.textBoxResult_BMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BMS.Size = new System.Drawing.Size(359, 559);
            this.textBoxResult_BMS.TabIndex = 0;
            this.textBoxResult_BMS.TextChanged += new System.EventHandler(this.textBoxResult_BMS_TextChanged);
            // 
            // chartFunction_BMS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_BMS.ChartAreas.Add(chartArea1);
            this.chartFunction_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_BMS.Legends.Add(legend1);
            this.chartFunction_BMS.Location = new System.Drawing.Point(5, 5);
            this.chartFunction_BMS.Name = "chartFunction_BMS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_BMS.Series.Add(series1);
            this.chartFunction_BMS.Size = new System.Drawing.Size(890, 584);
            this.chartFunction_BMS.TabIndex = 5;
            this.chartFunction_BMS.Text = "chart1";
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)/x+1,7-cos(x)*4*x-6";
            this.chartFunction_BMS.Titles.Add(title1);
            // 
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BMS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_BMS.Location = new System.Drawing.Point(1139, 46);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(112, 58);
            this.buttonHelp_BMS.TabIndex = 6;
            this.buttonHelp_BMS.Text = "Справка";
            this.buttonHelp_BMS.UseVisualStyleBackColor = false;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            // 
            // panelnPutData_BMS
            // 
            this.panelnPutData_BMS.BackColor = System.Drawing.Color.White;
            this.panelnPutData_BMS.Controls.Add(this.groupBoxTask_BMS);
            this.panelnPutData_BMS.Controls.Add(this.buttonHelp_BMS);
            this.panelnPutData_BMS.Controls.Add(this.groupBoxInPutData_BMS);
            this.panelnPutData_BMS.Controls.Add(this.buttonDone_BMS);
            this.panelnPutData_BMS.Controls.Add(this.buttonSave_BMS);
            this.panelnPutData_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelnPutData_BMS.Location = new System.Drawing.Point(0, 0);
            this.panelnPutData_BMS.Name = "panelnPutData_BMS";
            this.panelnPutData_BMS.Padding = new System.Windows.Forms.Padding(5);
            this.panelnPutData_BMS.Size = new System.Drawing.Size(1278, 150);
            this.panelnPutData_BMS.TabIndex = 7;
            // 
            // panelOutPutData_BMS
            // 
            this.panelOutPutData_BMS.BackColor = System.Drawing.Color.White;
            this.panelOutPutData_BMS.Controls.Add(this.groupBoxOutPutData_BMS);
            this.panelOutPutData_BMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPutData_BMS.Location = new System.Drawing.Point(0, 150);
            this.panelOutPutData_BMS.Name = "panelOutPutData_BMS";
            this.panelOutPutData_BMS.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPutData_BMS.Size = new System.Drawing.Size(375, 594);
            this.panelOutPutData_BMS.TabIndex = 8;
            // 
            // splitterOutPutData_BMS
            // 
            this.splitterOutPutData_BMS.Location = new System.Drawing.Point(375, 150);
            this.splitterOutPutData_BMS.Name = "splitterOutPutData_BMS";
            this.splitterOutPutData_BMS.Size = new System.Drawing.Size(3, 594);
            this.splitterOutPutData_BMS.TabIndex = 9;
            this.splitterOutPutData_BMS.TabStop = false;
            // 
            // panelResult_BMS
            // 
            this.panelResult_BMS.BackColor = System.Drawing.Color.White;
            this.panelResult_BMS.Controls.Add(this.chartFunction_BMS);
            this.panelResult_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_BMS.Location = new System.Drawing.Point(378, 150);
            this.panelResult_BMS.Name = "panelResult_BMS";
            this.panelResult_BMS.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_BMS.Size = new System.Drawing.Size(900, 594);
            this.panelResult_BMS.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panelResult_BMS);
            this.Controls.Add(this.splitterOutPutData_BMS);
            this.Controls.Add(this.panelOutPutData_BMS);
            this.Controls.Add(this.panelnPutData_BMS);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 17 | Бородулин М. С.";
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.groupBoxInPutData_BMS.ResumeLayout(false);
            this.groupBoxInPutData_BMS.PerformLayout();
            this.groupBoxOutPutData_BMS.ResumeLayout(false);
            this.groupBoxOutPutData_BMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).EndInit();
            this.panelnPutData_BMS.ResumeLayout(false);
            this.panelOutPutData_BMS.ResumeLayout(false);
            this.panelResult_BMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxTask_BMS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_BMS;
        private System.Windows.Forms.Label labelStopStep_BMS;
        private System.Windows.Forms.Label labelStartStep_BMS;
        private System.Windows.Forms.TextBox textBoxStopStep_BMS;
        private System.Windows.Forms.TextBox textBoxStartStep_BMS;
        private System.Windows.Forms.Button buttonDone_BMS;
        private System.Windows.Forms.Button buttonSave_BMS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BMS;
        private System.Windows.Forms.TextBox textBoxResult_BMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Panel panelnPutData_BMS;
        private System.Windows.Forms.Panel panelOutPutData_BMS;
        private System.Windows.Forms.Splitter splitterOutPutData_BMS;
        private System.Windows.Forms.Panel panelResult_BMS;
    }
}

