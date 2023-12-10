
namespace Tyuiu.BorodulinMS.Sprint6.Task6.V3
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
            this.buttonOpenFile_BMS = new System.Windows.Forms.Button();
            this.openFileDialogTask_BMS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpenFile_BMS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_BMS = new System.Windows.Forms.Button();
            this.panelTask_BMS = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BMS = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_BMS = new System.Windows.Forms.TextBox();
            this.groupBoxTask_BMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BMS = new System.Windows.Forms.TextBox();
            this.panelTask_BMS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxOutPutData_BMS.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxInPutData_BMS.SuspendLayout();
            this.groupBoxTask_BMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_BMS
            // 
            this.buttonOpenFile_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BMS.Image")));
            this.buttonOpenFile_BMS.Location = new System.Drawing.Point(12, 3);
            this.buttonOpenFile_BMS.Name = "buttonOpenFile_BMS";
            this.buttonOpenFile_BMS.Size = new System.Drawing.Size(114, 83);
            this.buttonOpenFile_BMS.TabIndex = 0;
            this.toolTipOpenFile_BMS.SetToolTip(this.buttonOpenFile_BMS, "Открыть файл \r\nВыберите нужный файл для обработки \r\n");
            this.buttonOpenFile_BMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BMS.Click += new System.EventHandler(this.buttonOpenFile_BMS_Click);
            // 
            // openFileDialogTask_BMS
            // 
            this.openFileDialogTask_BMS.FileName = "openFileDialog1";
            this.openFileDialogTask_BMS.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolTipOpenFile_BMS
            // 
            this.toolTipOpenFile_BMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_BMS.ToolTipTitle = "Подсказка";
            // 
            // buttonDone_BMS
            // 
            this.buttonDone_BMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BMS.Image")));
            this.buttonDone_BMS.Location = new System.Drawing.Point(132, 3);
            this.buttonDone_BMS.Name = "buttonDone_BMS";
            this.buttonDone_BMS.Size = new System.Drawing.Size(110, 83);
            this.buttonDone_BMS.TabIndex = 1;
            this.toolTipOpenFile_BMS.SetToolTip(this.buttonDone_BMS, "Выводит слова в которых встречается r в результуриующую строку");
            this.buttonDone_BMS.UseVisualStyleBackColor = true;
            this.buttonDone_BMS.Click += new System.EventHandler(this.buttonDone_BMS_Click);
            // 
            // panelTask_BMS
            // 
            this.panelTask_BMS.Controls.Add(this.buttonHelp);
            this.panelTask_BMS.Controls.Add(this.buttonOpenFile_BMS);
            this.panelTask_BMS.Controls.Add(this.buttonDone_BMS);
            this.panelTask_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BMS.Location = new System.Drawing.Point(0, 0);
            this.panelTask_BMS.Name = "panelTask_BMS";
            this.panelTask_BMS.Size = new System.Drawing.Size(978, 86);
            this.panelTask_BMS.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 538);
            this.panel2.TabIndex = 4;
            // 
            // groupBoxOutPutData_BMS
            // 
            this.groupBoxOutPutData_BMS.Controls.Add(this.textBoxResult_BMS);
            this.groupBoxOutPutData_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_BMS.Name = "groupBoxOutPutData_BMS";
            this.groupBoxOutPutData_BMS.Size = new System.Drawing.Size(590, 459);
            this.groupBoxOutPutData_BMS.TabIndex = 1;
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
            this.textBoxResult_BMS.Size = new System.Drawing.Size(584, 434);
            this.textBoxResult_BMS.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(888, 0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(90, 86);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxTask_BMS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 79);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxInPutData_BMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 459);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutPutData_BMS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(388, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 459);
            this.panel4.TabIndex = 4;
            // 
            // groupBoxInPutData_BMS
            // 
            this.groupBoxInPutData_BMS.Controls.Add(this.textBoxLoadFromFile_BMS);
            this.groupBoxInPutData_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_BMS.Name = "groupBoxInPutData_BMS";
            this.groupBoxInPutData_BMS.Size = new System.Drawing.Size(388, 459);
            this.groupBoxInPutData_BMS.TabIndex = 0;
            this.groupBoxInPutData_BMS.TabStop = false;
            this.groupBoxInPutData_BMS.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_BMS
            // 
            this.textBoxLoadFromFile_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_BMS.Location = new System.Drawing.Point(3, 22);
            this.textBoxLoadFromFile_BMS.Multiline = true;
            this.textBoxLoadFromFile_BMS.Name = "textBoxLoadFromFile_BMS";
            this.textBoxLoadFromFile_BMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_BMS.Size = new System.Drawing.Size(382, 434);
            this.textBoxLoadFromFile_BMS.TabIndex = 0;
            // 
            // groupBoxTask_BMS
            // 
            this.groupBoxTask_BMS.Controls.Add(this.textBoxTask_BMS);
            this.groupBoxTask_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BMS.Name = "groupBoxTask_BMS";
            this.groupBoxTask_BMS.Size = new System.Drawing.Size(978, 79);
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
            this.textBoxTask_BMS.Size = new System.Drawing.Size(972, 54);
            this.textBoxTask_BMS.TabIndex = 0;
            this.textBoxTask_BMS.Text = "Дан файл InPutFileTask6V3.txt, который может находиться в любом месте на диске. З" +
    "агрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречае" +
    "тся r в результирующую строку.\r\n ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTask_BMS);
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 3 | Бородулин М.С";
            this.panelTask_BMS.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxOutPutData_BMS.ResumeLayout(false);
            this.groupBoxOutPutData_BMS.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxInPutData_BMS.ResumeLayout(false);
            this.groupBoxInPutData_BMS.PerformLayout();
            this.groupBoxTask_BMS.ResumeLayout(false);
            this.groupBoxTask_BMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_BMS;
        private System.Windows.Forms.ToolTip toolTipOpenFile_BMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BMS;
        private System.Windows.Forms.Button buttonDone_BMS;
        private System.Windows.Forms.Panel panelTask_BMS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_BMS;
        private System.Windows.Forms.TextBox textBoxResult_BMS;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxInPutData_BMS;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_BMS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxTask_BMS;
        private System.Windows.Forms.TextBox textBoxTask_BMS;
    }
}

