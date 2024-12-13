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
using Tyuiu.ZhukovaYA.Sprint6.Task4.V6.Lib.WorkingVersion;

namespace Tyuiu.ZhukovaYA.Sprint6.Task4.V6
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
            MessageBox.Show("Таск 4 выполнила студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxTaskStartValue_ZYA.Text);
                int stopStep = Convert.ToInt32(textBoxTaskStopValue_ZYA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_ZYA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_ZYA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ZYA.Text = "";

                chartResult_ZYA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_ZYA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ZYA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V6.txt";
                File.WriteAllText(path, textBoxResult_ZYA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
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
    }
}
