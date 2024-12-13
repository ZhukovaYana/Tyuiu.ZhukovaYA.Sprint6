using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZhukovaYA.Sprint6.Task2.V23.Lib.WorkingVersion;

namespace Tyuiu.ZhukovaYA.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDoneYZA_MouseEnter(object sender, EventArgs e)
        {
            buttonDoneYZA.BackColor = Color.Green;
        }

        private void buttonDoneYZA_MouseLeave(object sender, EventArgs e)
        {
            buttonDoneYZA.BackColor = Color.Yellow;
        }

        private void buttonDoneYZA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoneYZA.BackColor = Color.Blue;
        }

        private void buttonMessageYZA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonMessageYZA.BackColor = Color.Green;
        }

        private void buttonMessageYZA_MouseEnter(object sender, EventArgs e)
        {
            buttonMessageYZA.BackColor = Color.Yellow;
        }

        private void buttonMessageYZA_MouseLeave(object sender, EventArgs e)
        {
            buttonMessageYZA.BackColor = Color.Blue;
        }

        private void buttonMessageYZA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneYZA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValueYZA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValueYZA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResultYZA.Titles.Add("График функции F(X)");

                this.chartResultYZA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResultYZA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResultYZA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResultYZA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
