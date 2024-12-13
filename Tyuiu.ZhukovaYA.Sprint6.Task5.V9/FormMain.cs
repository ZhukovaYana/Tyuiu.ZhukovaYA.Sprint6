using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZhukovaYA.Sprint6.Task5.V9.Lib.WorkingVersion;

namespace Tyuiu.ZhukovaYA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_ZYA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ZYA.BackColor = Color.Green;
        }

        private void buttonDone_ZYA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ZYA.BackColor = Color.Yellow;
        }

        private void buttonSave_ZYA_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_ZYA.BackColor = Color.Blue;
        }

        private void buttonSave_ZYA_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_ZYA.BackColor = Color.Yellow;
        }

        private void buttonMessage_ZYA_MouseEnter(object sender, EventArgs e)
        {
            buttonMessage_ZYA.BackColor = Color.Blue;
        }

        private void buttonMessage_ZYA_MouseLeave(object sender, EventArgs e)
        {
            buttonMessage_ZYA.BackColor = Color.Green;
        }

        private void buttonMessage_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V9.txt";

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ZYA.ColumnCount = 2;
            dataGridViewResult_ZYA.Columns[0].Width = 20;
            dataGridViewResult_ZYA.Columns[1].Width = 50;

            this.chartResult_ZYA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_ZYA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_ZYA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ZYA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_ZYA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_ZYA_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V9.txt";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
