using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BorodulinMS.Sprint6.Task2.V14.Lib;

namespace Tyuiu.BorodulinMS.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_BMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Бородулин Матвей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BMS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BMS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BMS.Titles.Add("График функции sin(x)");

                this.chartFunction_BMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BMS.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i = 0; i<=len-1;i++)
                {
                    this.dataGridViewFunction_BMS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_BMS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
