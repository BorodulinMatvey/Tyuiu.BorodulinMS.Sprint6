using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BorodulinMS.Sprint6.Task0.V30.Lib;

namespace Tyuiu.BorodulinMS.Sprint6.Task0.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxInputData_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPushMe_BMS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_BMS.Text = Convert.ToString(ds.Calculate(3));
        }

        private void textBoxTask_BMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-1 Бородулин Матвей Сергеевич", "Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
