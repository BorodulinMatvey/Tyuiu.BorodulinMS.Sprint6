using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BorodulinMS.Sprint6.Task1.V16.Lib;
namespace Tyuiu.BorodulinMS.Sprint6.Task1.V16
{
    public partial class FormMain_BMS : Form
    {
        public FormMain_BMS()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Бородулин Матвей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void buttonPushMe_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_BMS.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_BMS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BMS.Text = "";
                textBoxResult_BMS.AppendText("+---------+-----------+" + Environment.NewLine);
                textBoxResult_BMS.AppendText("|    X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_BMS.AppendText("+---------+-----------+" + Environment.NewLine);

                for(int i=0;i<=len-1;i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 7:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_BMS.AppendText(strLine + Environment.NewLine);
                    startStep++;


                }
                textBoxResult_BMS.AppendText("+---------+-----------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_BMS_Load(object sender, EventArgs e)
        {

        }
    }
}
