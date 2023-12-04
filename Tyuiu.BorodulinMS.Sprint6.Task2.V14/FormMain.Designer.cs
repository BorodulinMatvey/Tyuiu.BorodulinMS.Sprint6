
namespace Tyuiu.BorodulinMS.Sprint6.Task2.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BMS = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_BMS = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BMS = new System.Windows.Forms.TextBox();
            this.labelStopStep_BMS = new System.Windows.Forms.Label();
            this.labelStartStep_BMS = new System.Windows.Forms.Label();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_BMS = new System.Windows.Forms.GroupBox();
            this.labelResult_BMS = new System.Windows.Forms.Label();
            this.chartFunction_BMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_BMS = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_BMS.SuspendLayout();
            this.groupBoxInPutData_BMS.SuspendLayout();
            this.groupBoxOutPutData_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxTask_BMS);
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(577, 380);
            this.groupBoxTask_BMS.TabIndex = 0;
            this.groupBoxTask_BMS.TabStop = false;
            this.groupBoxTask_BMS.Text = "Условие:";
            // 
            // textBoxTask_BMS
            // 
            this.textBoxTask_BMS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_BMS.Multiline = true;
            this.textBoxTask_BMS.Name = "textBoxTask_BMS";
            this.textBoxTask_BMS.ReadOnly = true;
            this.textBoxTask_BMS.Size = new System.Drawing.Size(439, 338);
            this.textBoxTask_BMS.TabIndex = 0;
            this.textBoxTask_BMS.Text = resources.GetString("textBoxTask_BMS.Text");
            // 
            // groupBoxInPutData_BMS
            // 
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStopStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxStartStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStopStep_BMS);
            this.groupBoxInPutData_BMS.Controls.Add(this.labelStartStep_BMS);
            this.groupBoxInPutData_BMS.Location = new System.Drawing.Point(18, 412);
            this.groupBoxInPutData_BMS.Name = "groupBoxInPutData_BMS";
            this.groupBoxInPutData_BMS.Size = new System.Drawing.Size(351, 92);
            this.groupBoxInPutData_BMS.TabIndex = 1;
            this.groupBoxInPutData_BMS.TabStop = false;
            this.groupBoxInPutData_BMS.Text = "Ввод данных";
            this.groupBoxInPutData_BMS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxStopStep_BMS
            // 
            this.textBoxStopStep_BMS.Location = new System.Drawing.Point(172, 49);
            this.textBoxStopStep_BMS.Name = "textBoxStopStep_BMS";
            this.textBoxStopStep_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStopStep_BMS.TabIndex = 1;
            this.textBoxStopStep_BMS.Text = "5";
            this.textBoxStopStep_BMS.TextChanged += new System.EventHandler(this.textBoxStopStep_BMS_TextChanged);
            // 
            // textBoxStartStep_BMS
            // 
            this.textBoxStartStep_BMS.Location = new System.Drawing.Point(11, 49);
            this.textBoxStartStep_BMS.Name = "textBoxStartStep_BMS";
            this.textBoxStartStep_BMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep_BMS.TabIndex = 1;
            this.textBoxStartStep_BMS.Text = "-5";
            // 
            // labelStopStep_BMS
            // 
            this.labelStopStep_BMS.AutoSize = true;
            this.labelStopStep_BMS.Location = new System.Drawing.Point(171, 26);
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
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_BMS.Location = new System.Drawing.Point(375, 412);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(89, 92);
            this.buttonHelp_BMS.TabIndex = 2;
            this.buttonHelp_BMS.Text = "Справка";
            this.buttonHelp_BMS.UseVisualStyleBackColor = false;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(470, 412);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(119, 92);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // groupBoxOutPutData_BMS
            // 
            this.groupBoxOutPutData_BMS.Controls.Add(this.labelResult_BMS);
            this.groupBoxOutPutData_BMS.Controls.Add(this.chartFunction_BMS);
            this.groupBoxOutPutData_BMS.Controls.Add(this.dataGridViewFunction_BMS);
            this.groupBoxOutPutData_BMS.Location = new System.Drawing.Point(605, 12);
            this.groupBoxOutPutData_BMS.Name = "groupBoxOutPutData_BMS";
            this.groupBoxOutPutData_BMS.Size = new System.Drawing.Size(699, 450);
            this.groupBoxOutPutData_BMS.TabIndex = 3;
            this.groupBoxOutPutData_BMS.TabStop = false;
            this.groupBoxOutPutData_BMS.Text = "Вывод данных";
            // 
            // labelResult_BMS
            // 
            this.labelResult_BMS.AutoSize = true;
            this.labelResult_BMS.Location = new System.Drawing.Point(15, 25);
            this.labelResult_BMS.Name = "labelResult_BMS";
            this.labelResult_BMS.Size = new System.Drawing.Size(93, 20);
            this.labelResult_BMS.TabIndex = 2;
            this.labelResult_BMS.Text = "Результат:";
            // 
            // chartFunction_BMS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_BMS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_BMS.Legends.Add(legend2);
            this.chartFunction_BMS.Location = new System.Drawing.Point(199, 25);
            this.chartFunction_BMS.Name = "chartFunction_BMS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_BMS.Series.Add(series2);
            this.chartFunction_BMS.Size = new System.Drawing.Size(476, 419);
            this.chartFunction_BMS.TabIndex = 1;
            this.chartFunction_BMS.Text = "chart1";
            // 
            // dataGridViewFunction_BMS
            // 
            this.dataGridViewFunction_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_BMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column2});
            this.dataGridViewFunction_BMS.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewFunction_BMS.Name = "dataGridViewFunction_BMS";
            this.dataGridViewFunction_BMS.RowHeadersVisible = false;
            this.dataGridViewFunction_BMS.RowHeadersWidth = 62;
            this.dataGridViewFunction_BMS.RowTemplate.Height = 28;
            this.dataGridViewFunction_BMS.Size = new System.Drawing.Size(187, 396);
            this.dataGridViewFunction_BMS.TabIndex = 0;
            this.dataGridViewFunction_BMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 516);
            this.Controls.Add(this.groupBoxOutPutData_BMS);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp_BMS);
            this.Controls.Add(this.groupBoxInPutData_BMS);
            this.Controls.Add(this.groupBoxTask_BMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 0 | Бородулин М.С";
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.groupBoxInPutData_BMS.ResumeLayout(false);
            this.groupBoxInPutData_BMS.PerformLayout();
            this.groupBoxOutPutData_BMS.ResumeLayout(false);
            this.groupBoxOutPutData_BMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxTask_BMS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_BMS;
        private System.Windows.Forms.TextBox textBoxStopStep_BMS;
        private System.Windows.Forms.TextBox textBoxStartStep_BMS;
        private System.Windows.Forms.Label labelStopStep_BMS;
        private System.Windows.Forms.Label labelStartStep_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BMS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_BMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BMS;
        private System.Windows.Forms.Label labelResult_BMS;
    }
}

