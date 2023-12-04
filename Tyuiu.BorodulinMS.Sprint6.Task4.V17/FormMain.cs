using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BorodulinMS.Sprint6.Task4.V17.Lib;

namespace Tyuiu.BorodulinMS.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService(); 
        private void buttonSave_BMS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_BMS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_BMS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BMS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BMS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BMS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BMS.Text = "";

                chartFunction_BMS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_BMS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_BMS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void textBoxResult_BMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Бородулин Матвей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
