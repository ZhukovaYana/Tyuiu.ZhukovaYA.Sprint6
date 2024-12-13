using Tyuiu.ZhukovaYA.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task1.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxResultZYA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResultZYA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValueZYA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValueZYA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResultZYA.Text = "";
                textBoxResultZYA.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResultZYA.AppendText("|   X     |   f(x)  |" + Environment.NewLine);
                textBoxResultZYA.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,6:d}   | {1, 7:f2} |", startStep, valueArray[i]);
                    textBoxResultZYA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResultZYA.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMessageZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
