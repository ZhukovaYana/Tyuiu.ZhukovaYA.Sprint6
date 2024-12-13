using Tyuiu.ZhukovaYA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        static string openFilePath;
        static int colums;
        static int rows;
        public FormMain()
        {
            InitializeComponent();
        }

        public static int[,] LoadFromFileData(string filePath)
        {


            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(";").Length;
            int[,] arrayValues = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(";");
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[i, c] = Convert.ToInt32(line_r[c]);
                }

            }
            return arrayValues;
        }

        private void buttonOpen_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialog_ZYA.ShowDialog();
            openFilePath = openFileDialog_ZYA.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_ZYA.ColumnCount = colums;
            dataGridViewIn_ZYA.RowCount = rows;
            dataGridViewOut_ZYA.ColumnCount = colums;
            dataGridViewOut_ZYA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_ZYA.Columns[i].Width = 35;
                dataGridViewOut_ZYA.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewIn_ZYA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDown_ZYA.Enabled = true;

        }

        private void buttonDown_ZYA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOut_ZYA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_ZYA.Enabled = true;
        }

        private void buttonSave_ZYA_Click(object sender, EventArgs e)
        {
            saveFileDialog_ZYA.FileName = saveFileDialog_ZYA.FileName;
            saveFileDialog_ZYA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_ZYA.ShowDialog();

            string path = saveFileDialog_ZYA.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_ZYA.RowCount;
            int column = dataGridViewOut_ZYA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j != column - 1)
                    {
                        str = str + dataGridViewOut_ZYA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_ZYA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonQuestion_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxCond_ZYA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
