using Tyuiu.ZhukovaYA.Sprint6.Task3.V13.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {  { -7, 34, -2, 25, 5 },
                                            { -16, -12, 30, -3, 17 },
                                            { 3, -15, 12, 5, -5 },
                                            { 17, 22, -3, 32, -11 },
                                            { 9, 28, 1, -9, -2 } };

        private void buttonMessageZYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИППБ-24-1 Жукова Яна Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneZYA_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResultZYA.RowCount = rows;
            dataGridViewResultZYA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultZYA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewResultZYA.Rows[i].Cells[j].Value = Convert.ToString(ds.Calculate(mtrx)[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewTaskZYA.RowCount = rows;
            dataGridViewTaskZYA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewTaskZYA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewTaskZYA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
