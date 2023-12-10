
namespace Tyuiu.BorodulinMS.Sprint6.Task7.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButton_BMS = new System.Windows.Forms.Panel();
            this.buttonHelp_BMS = new System.Windows.Forms.Button();
            this.buttonSaveFile_BMS = new System.Windows.Forms.Button();
            this.buttonDone_BMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_BMS = new System.Windows.Forms.Button();
            this.panelTask_BMS = new System.Windows.Forms.Panel();
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BMS = new System.Windows.Forms.TextBox();
            this.splitContainerIn_Out_BMS = new System.Windows.Forms.SplitContainer();
            this.groupBoxIn_BMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_BMS = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_BMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_BMS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_BMS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_BMS = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_BMS = new System.Windows.Forms.ToolTip(this.components);
            this.panelButton_BMS.SuspendLayout();
            this.panelTask_BMS.SuspendLayout();
            this.groupBoxTask_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIn_Out_BMS)).BeginInit();
            this.splitContainerIn_Out_BMS.Panel1.SuspendLayout();
            this.splitContainerIn_Out_BMS.Panel2.SuspendLayout();
            this.splitContainerIn_Out_BMS.SuspendLayout();
            this.groupBoxIn_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_BMS)).BeginInit();
            this.groupBoxOut_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton_BMS
            // 
            this.panelButton_BMS.Controls.Add(this.buttonHelp_BMS);
            this.panelButton_BMS.Controls.Add(this.buttonSaveFile_BMS);
            this.panelButton_BMS.Controls.Add(this.buttonDone_BMS);
            this.panelButton_BMS.Controls.Add(this.buttonOpenFile_BMS);
            this.panelButton_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_BMS.Location = new System.Drawing.Point(0, 0);
            this.panelButton_BMS.Name = "panelButton_BMS";
            this.panelButton_BMS.Size = new System.Drawing.Size(861, 110);
            this.panelButton_BMS.TabIndex = 0;
            // 
            // buttonHelp_BMS
            // 
            this.buttonHelp_BMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BMS.Image")));
            this.buttonHelp_BMS.Location = new System.Drawing.Point(752, 6);
            this.buttonHelp_BMS.Name = "buttonHelp_BMS";
            this.buttonHelp_BMS.Size = new System.Drawing.Size(75, 88);
            this.buttonHelp_BMS.TabIndex = 3;
            this.toolTipButton_BMS.SetToolTip(this.buttonHelp_BMS, "Сведение о программе\r\n\r\n\r\n");
            this.buttonHelp_BMS.UseVisualStyleBackColor = true;
            this.buttonHelp_BMS.Click += new System.EventHandler(this.buttonHelp_BMS_Click);
            this.buttonHelp_BMS.MouseEnter += new System.EventHandler(this.buttonHelp_BMS_MouseEnter);
            // 
            // buttonSaveFile_BMS
            // 
            this.buttonSaveFile_BMS.Enabled = false;
            this.buttonSaveFile_BMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_BMS.Image")));
            this.buttonSaveFile_BMS.Location = new System.Drawing.Point(165, 6);
            this.buttonSaveFile_BMS.Name = "buttonSaveFile_BMS";
            this.buttonSaveFile_BMS.Size = new System.Drawing.Size(75, 91);
            this.buttonSaveFile_BMS.TabIndex = 2;
            this.toolTipButton_BMS.SetToolTip(this.buttonSaveFile_BMS, "Сохранить обработанные данные в файл в формате CSV \r\n\r\n");
            this.buttonSaveFile_BMS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_BMS.Click += new System.EventHandler(this.buttonSaveFile_BMS_Click);
            this.buttonSaveFile_BMS.MouseEnter += new System.EventHandler(this.buttonSaveFile_BMS_MouseEnter);
            // 
            // buttonDone_BMS
            // 
            this.buttonDone_BMS.Enabled = false;
            this.buttonDone_BMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BMS.Image")));
            this.buttonDone_BMS.Location = new System.Drawing.Point(84, 6);
            this.buttonDone_BMS.Name = "buttonDone_BMS";
            this.buttonDone_BMS.Size = new System.Drawing.Size(75, 91);
            this.buttonDone_BMS.TabIndex = 1;
            this.toolTipButton_BMS.SetToolTip(this.buttonDone_BMS, "Выполнить обработку данных\r\n\r\n");
            this.buttonDone_BMS.UseVisualStyleBackColor = true;
            this.buttonDone_BMS.Click += new System.EventHandler(this.buttonDone_BMS_Click);
            this.buttonDone_BMS.MouseEnter += new System.EventHandler(this.buttonDone_BMS_MouseEnter);
            // 
            // buttonOpenFile_BMS
            // 
            this.buttonOpenFile_BMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BMS.Image")));
            this.buttonOpenFile_BMS.Location = new System.Drawing.Point(3, 6);
            this.buttonOpenFile_BMS.Name = "buttonOpenFile_BMS";
            this.buttonOpenFile_BMS.Size = new System.Drawing.Size(75, 91);
            this.buttonOpenFile_BMS.TabIndex = 0;
            this.toolTipButton_BMS.SetToolTip(this.buttonOpenFile_BMS, "Открыть файл для обработки данных в формате CSV\r\n\r\n\r\n\r\n");
            this.buttonOpenFile_BMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BMS.Click += new System.EventHandler(this.buttonOpenFile_BMS_Click);
            this.buttonOpenFile_BMS.MouseEnter += new System.EventHandler(this.buttonOpenFile_BMS_MouseEnter);
            // 
            // panelTask_BMS
            // 
            this.panelTask_BMS.Controls.Add(this.groupBoxTask_BMS);
            this.panelTask_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BMS.Location = new System.Drawing.Point(0, 110);
            this.panelTask_BMS.Name = "panelTask_BMS";
            this.panelTask_BMS.Size = new System.Drawing.Size(861, 100);
            this.panelTask_BMS.TabIndex = 1;
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxTask_BMS);
            this.groupBoxTask_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(861, 100);
            this.groupBoxTask_BMS.TabIndex = 0;
            this.groupBoxTask_BMS.TabStop = false;
            this.groupBoxTask_BMS.Text = "Условие:";
            // 
            // textBoxTask_BMS
            // 
            this.textBoxTask_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BMS.Location = new System.Drawing.Point(3, 22);
            this.textBoxTask_BMS.Multiline = true;
            this.textBoxTask_BMS.Name = "textBoxTask_BMS";
            this.textBoxTask_BMS.ReadOnly = true;
            this.textBoxTask_BMS.Size = new System.Drawing.Size(855, 75);
            this.textBoxTask_BMS.TabIndex = 0;
            this.textBoxTask_BMS.Text = resources.GetString("textBoxTask_BMS.Text");
            // 
            // splitContainerIn_Out_BMS
            // 
            this.splitContainerIn_Out_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerIn_Out_BMS.Location = new System.Drawing.Point(0, 210);
            this.splitContainerIn_Out_BMS.Name = "splitContainerIn_Out_BMS";
            // 
            // splitContainerIn_Out_BMS.Panel1
            // 
            this.splitContainerIn_Out_BMS.Panel1.Controls.Add(this.groupBoxIn_BMS);
            // 
            // splitContainerIn_Out_BMS.Panel2
            // 
            this.splitContainerIn_Out_BMS.Panel2.Controls.Add(this.groupBoxOut_BMS);
            this.splitContainerIn_Out_BMS.Size = new System.Drawing.Size(861, 257);
            this.splitContainerIn_Out_BMS.SplitterDistance = 436;
            this.splitContainerIn_Out_BMS.TabIndex = 2;
            // 
            // groupBoxIn_BMS
            // 
            this.groupBoxIn_BMS.Controls.Add(this.dataGridViewInMatrix_BMS);
            this.groupBoxIn_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_BMS.Name = "groupBoxIn_BMS";
            this.groupBoxIn_BMS.Size = new System.Drawing.Size(436, 257);
            this.groupBoxIn_BMS.TabIndex = 0;
            this.groupBoxIn_BMS.TabStop = false;
            this.groupBoxIn_BMS.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_BMS
            // 
            this.dataGridViewInMatrix_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_BMS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewInMatrix_BMS.Name = "dataGridViewInMatrix_BMS";
            this.dataGridViewInMatrix_BMS.RowHeadersWidth = 62;
            this.dataGridViewInMatrix_BMS.RowTemplate.Height = 28;
            this.dataGridViewInMatrix_BMS.Size = new System.Drawing.Size(430, 232);
            this.dataGridViewInMatrix_BMS.TabIndex = 0;
            // 
            // groupBoxOut_BMS
            // 
            this.groupBoxOut_BMS.Controls.Add(this.dataGridViewOutMatrix_BMS);
            this.groupBoxOut_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_BMS.Name = "groupBoxOut_BMS";
            this.groupBoxOut_BMS.Size = new System.Drawing.Size(421, 257);
            this.groupBoxOut_BMS.TabIndex = 0;
            this.groupBoxOut_BMS.TabStop = false;
            this.groupBoxOut_BMS.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_BMS
            // 
            this.dataGridViewOutMatrix_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_BMS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOutMatrix_BMS.Name = "dataGridViewOutMatrix_BMS";
            this.dataGridViewOutMatrix_BMS.RowHeadersWidth = 62;
            this.dataGridViewOutMatrix_BMS.RowTemplate.Height = 28;
            this.dataGridViewOutMatrix_BMS.Size = new System.Drawing.Size(415, 232);
            this.dataGridViewOutMatrix_BMS.TabIndex = 0;
            // 
            // openFileDialogTask_BMS
            // 
            this.openFileDialogTask_BMS.FileName = "openFileDialog1";
            // 
            // toolTipButton_BMS
            // 
            this.toolTipButton_BMS.IsBalloon = true;
            this.toolTipButton_BMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_BMS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 467);
            this.Controls.Add(this.splitContainerIn_Out_BMS);
            this.Controls.Add(this.panelTask_BMS);
            this.Controls.Add(this.panelButton_BMS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 16 | Бородулин М. С";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButton_BMS.ResumeLayout(false);
            this.panelTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.splitContainerIn_Out_BMS.Panel1.ResumeLayout(false);
            this.splitContainerIn_Out_BMS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIn_Out_BMS)).EndInit();
            this.splitContainerIn_Out_BMS.ResumeLayout(false);
            this.groupBoxIn_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_BMS)).EndInit();
            this.groupBoxOut_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_BMS;
        private System.Windows.Forms.Button buttonHelp_BMS;
        private System.Windows.Forms.Button buttonSaveFile_BMS;
        private System.Windows.Forms.Button buttonDone_BMS;
        private System.Windows.Forms.Button buttonOpenFile_BMS;
        private System.Windows.Forms.Panel panelTask_BMS;
        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxTask_BMS;
        private System.Windows.Forms.SplitContainer splitContainerIn_Out_BMS;
        private System.Windows.Forms.GroupBox groupBoxIn_BMS;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_BMS;
        private System.Windows.Forms.GroupBox groupBoxOut_BMS;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_BMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BMS;
        private System.Windows.Forms.ToolTip toolTipButton_BMS;
    }
}

