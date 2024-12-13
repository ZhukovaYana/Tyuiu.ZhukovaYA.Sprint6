using Tyuiu.ZhukovaYA.Sprint6.Task6.V13.Lib;

namespace Tyuiu.ZhukovaYA.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        string str;

        private void buttonOpen_ZYA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZYA.ShowDialog();
            path = openFileDialogTask_ZYA.FileName;
            textBoxInput_ZYA.Text = File.ReadAllText(path);
            groupInput_ZYA.Text = groupInput_ZYA.Text + " " + openFileDialogTask_ZYA.FileName;
            buttonStart_ZYA.Enabled = true;
        }

        private void buttonStart_ZYA_Click(object sender, EventArgs e)
        {
            textBoxOutput_ZYA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_ZYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
