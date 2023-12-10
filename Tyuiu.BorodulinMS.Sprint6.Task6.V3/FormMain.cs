using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BorodulinMS.Sprint6.Task6.V3.Lib;
using System.IO;
namespace Tyuiu.BorodulinMS.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();




        private void buttonOpenFile_BMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BMS.ShowDialog();
            openFilePath = openFileDialogTask_BMS.FileName;
            textBoxLoadFromFile_BMS.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_BMS.Text = groupBoxInPutData_BMS.Text + "" + openFileDialogTask_BMS.FileName;
            buttonDone_BMS.Enabled = true;
        }

        private void buttonDone_BMS_Click(object sender, EventArgs e)
        {

            string str = "r";
            textBoxResult_BMS.Text = ds.CollectTextFromFile(str, openFilePath);

        }



        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
