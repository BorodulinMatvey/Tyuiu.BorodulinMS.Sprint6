
namespace Tyuiu.BorodulinMS.Sprint6.Task5.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_BMS = new System.Windows.Forms.Panel();
            this.panelOutPutData_BMS = new System.Windows.Forms.Panel();
            this.panelResult_BMS = new System.Windows.Forms.Panel();
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BMS = new System.Windows.Forms.TextBox();
            this.buttonDone_BMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_BMS = new System.Windows.Forms.Button();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_BMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_BMS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_BMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOutPutData_BMS = new System.Windows.Forms.Splitter();
            this.panelTask_BMS.SuspendLayout();
            this.panelOutPutData_BMS.SuspendLayout();
            this.panelResult_BMS.SuspendLayout();
            this.groupBoxTask_BMS.SuspendLayout();
            this.groupBoxOutPutData_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_BMS
            // 
            this.panelTask_BMS.Controls.Add(this.buttonHelp_BMS);
            this.panelTask_BMS.Controls.Add(this.buttonOpenFile_BMS);
            this.panelTask_BMS.Controls.Add(this.buttonDone_BMS);
            this.panelTask_BMS.Controls.Add(this.groupBoxTask_BMS);
            this.panelTask_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BMS.Location = new System.Drawing.Point(0, 0);
            this.panelTask_BMS.Name = "panelTask_BMS";
            this.panelTask_BMS.Size = new System.Drawing.Size(978, 100);
            this.panelTask_BMS.TabIndex = 0;
            // 
            // panelOutPutData_BMS
            // 
            this.panelOutPutData_BMS.Controls.Add(this.groupBoxOutPutData_BMS);
            this.panelOutPutData_BMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPutData_BMS.Location = new System.Drawing.Point(0, 100);
            this.panelOutPutData_BMS.Name = "panelOutPutData_BMS";
            this.panelOutPutData_BMS.Size = new System.Drawing.Size(200, 594);
            this.panelOutPutData_BMS.TabIndex = 1;
            // 
            // panelResult_BMS
            // 
            this.panelResult_BMS.Controls.Add(this.splitterOutPutData_BMS);
            this.panelResult_BMS.Controls.Add(this.chartFunction_BMS);
            this.panelResult_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_BMS.Location = new System.Drawing.Point(200, 100);
            this.panelResult_BMS.Name = "panelResult_BMS";
            this.panelResult_BMS.Size = new System.Drawing.Size(778, 594);
            this.panelResult_BMS.TabIndex = 2;
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxTask_BMS);
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(584, 97);
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
            this.textBoxTask_BMS.Size = new System.Drawing.Size(572, 66);
            this.textBoxTask_BMS.TabIndex = 0;
            this.textBoxTask_BMS.Text = "Прочитать данные из файла InPutTask5V16.txt. Вывести в dataGridView положительные" +
    " значения и построить диаграмму по этим значениям.";
            // 
            // buttonDone_BMS
            // 
            this.buttonDone_BMS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BMS.Location = new System.Drawing.Point(607, 12);
            this.buttonDone_BMS.Name = "buttonDone_BMS";
            this.buttonDone_BMS.Size = new System.Drawing.Size(118, 71);
            this.buttonDone_BMS.TabIndex = 1;
            this.buttonDone_BMS.Text = "Выполнить";
            this.buttonDone_BMS.UseVisualStyleBackColor = false;
            this.buttonDone_BMS.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile_BMS
            // 
            this.buttonOpenFile_BMS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpenFile_BMS.Location = new System.Drawing.Point(749, 12);
            this.buttonOpenFile_BMS.Name = "buttonOpenFile_BMS";
            this.buttonOpenFile_BMS.Size = new System.Drawing.Size(112, 71);
            this.buttonOpenFile_BMS.TabIndex = 2;
            this.buttonOpenFile_BMS.Text = "Открыть файл";
            this.buttonOpenFile_BMS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BMS.Click += new System.EventHandler(this.buttonOpenFile_BMS_Click);
            // 
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_BMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_BMS.Location = new System.Drawing.Point(888, 0);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(90, 100);
            this.buttonHelp_BMS.TabIndex = 3;
            this.buttonHelp_BMS.Text = "Справка";
            this.buttonHelp_BMS.UseVisualStyleBackColor = false;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            // 
            // groupBoxOutPutData_BMS
            // 
            this.groupBoxOutPutData_BMS.Controls.Add(this.dataGridViewResult_BMS);
            this.groupBoxOutPutData_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_BMS.Name = "groupBoxOutPutData_BMS";
            this.groupBoxOutPutData_BMS.Size = new System.Drawing.Size(200, 594);
            this.groupBoxOutPutData_BMS.TabIndex = 0;
            this.groupBoxOutPutData_BMS.TabStop = false;
            this.groupBoxOutPutData_BMS.Text = "Вывод данных:";
            // 
            // dataGridViewResult_BMS
            // 
            this.dataGridViewResult_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_BMS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewResult_BMS.Name = "dataGridViewResult_BMS";
            this.dataGridViewResult_BMS.RowHeadersVisible = false;
            this.dataGridViewResult_BMS.RowHeadersWidth = 62;
            this.dataGridViewResult_BMS.RowTemplate.Height = 28;
            this.dataGridViewResult_BMS.Size = new System.Drawing.Size(194, 569);
            this.dataGridViewResult_BMS.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // chartFunction_BMS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_BMS.ChartAreas.Add(chartArea2);
            this.chartFunction_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_BMS.Legends.Add(legend2);
            this.chartFunction_BMS.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_BMS.Name = "chartFunction_BMS";
            this.chartFunction_BMS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_BMS.Series.Add(series2);
            this.chartFunction_BMS.Size = new System.Drawing.Size(778, 594);
            this.chartFunction_BMS.TabIndex = 1;
            this.chartFunction_BMS.Text = "chart1";
            // 
            // splitterOutPutData_BMS
            // 
            this.splitterOutPutData_BMS.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPutData_BMS.Name = "splitterOutPutData_BMS";
            this.splitterOutPutData_BMS.Size = new System.Drawing.Size(3, 594);
            this.splitterOutPutData_BMS.TabIndex = 2;
            this.splitterOutPutData_BMS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.panelResult_BMS);
            this.Controls.Add(this.panelOutPutData_BMS);
            this.Controls.Add(this.panelTask_BMS);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Бородулин М. С.";
            this.panelTask_BMS.ResumeLayout(false);
            this.panelOutPutData_BMS.ResumeLayout(false);
            this.panelResult_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.groupBoxOutPutData_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Button buttonOpenFile_BMS;
        private System.Windows.Forms.Button buttonDone_BMS;
        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxTask_BMS;
        private System.Windows.Forms.Panel panelOutPutData_BMS;
        private System.Windows.Forms.Panel panelResult_BMS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BMS;
        private System.Windows.Forms.DataGridView dataGridViewResult_BMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BMS;
        private System.Windows.Forms.Splitter splitterOutPutData_BMS;
    }
}

