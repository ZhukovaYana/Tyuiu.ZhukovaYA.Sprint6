using Tyuiu.ZhukovaYA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_ZYA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                textBoxDataOutput_ZYA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxDataInput_ZYA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDataInput_ZYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonhelp_ZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
