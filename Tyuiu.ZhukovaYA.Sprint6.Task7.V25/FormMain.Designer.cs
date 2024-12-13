namespace Tyuiu.ZhukovaYA.Sprint6.Task7.V25
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ZYA = new Panel();
            buttonQuestion_ZYA = new Button();
            buttonSave_ZYA = new Button();
            buttonDown_ZYA = new Button();
            buttonOpen_ZYA = new Button();
            panelCond_ZYA = new Panel();
            groupBoxCond_ZYA = new GroupBox();
            textBoxCond_ZYA = new TextBox();
            panelIn_ZYA = new Panel();
            groupBoxIn_ZYA = new GroupBox();
            dataGridViewIn_ZYA = new DataGridView();
            splitter_ZYA = new Splitter();
            panelOut_ZYA = new Panel();
            groupBoxOut_ZYA = new GroupBox();
            dataGridViewOut_ZYA = new DataGridView();
            openFileDialog_ZYA = new OpenFileDialog();
            toolTip_ZYA = new ToolTip(components);
            saveFileDialog_ZYA = new SaveFileDialog();
            toolTipDown_ZYA = new ToolTip(components);
            toolTipSave_ZYA = new ToolTip(components);
            toolTipQuestion_ZYA = new ToolTip(components);
            labelText_ZYA = new Label();
            panelButtons_ZYA.SuspendLayout();
            panelCond_ZYA.SuspendLayout();
            groupBoxCond_ZYA.SuspendLayout();
            panelIn_ZYA.SuspendLayout();
            groupBoxIn_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ZYA).BeginInit();
            panelOut_ZYA.SuspendLayout();
            groupBoxOut_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ZYA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_ZYA
            // 
            panelButtons_ZYA.Controls.Add(buttonQuestion_ZYA);
            panelButtons_ZYA.Controls.Add(buttonSave_ZYA);
            panelButtons_ZYA.Controls.Add(buttonDown_ZYA);
            panelButtons_ZYA.Controls.Add(buttonOpen_ZYA);
            panelButtons_ZYA.Dock = DockStyle.Top;
            panelButtons_ZYA.Location = new Point(0, 0);
            panelButtons_ZYA.Margin = new Padding(3, 2, 3, 2);
            panelButtons_ZYA.Name = "panelButtons_ZYA";
            panelButtons_ZYA.Size = new Size(774, 70);
            panelButtons_ZYA.TabIndex = 0;
            // 
            // buttonQuestion_ZYA
            // 
            buttonQuestion_ZYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_ZYA.Image = (Image)resources.GetObject("buttonQuestion_ZYA.Image");
            buttonQuestion_ZYA.Location = new Point(710, 9);
            buttonQuestion_ZYA.Margin = new Padding(3, 2, 3, 2);
            buttonQuestion_ZYA.Name = "buttonQuestion_ZYA";
            buttonQuestion_ZYA.Size = new Size(52, 46);
            buttonQuestion_ZYA.TabIndex = 3;
            toolTipQuestion_ZYA.SetToolTip(buttonQuestion_ZYA, "Сведения о программе\r\n");
            buttonQuestion_ZYA.UseVisualStyleBackColor = true;
            buttonQuestion_ZYA.Click += buttonQuestion_ZYA_Click;
            // 
            // buttonSave_ZYA
            // 
            buttonSave_ZYA.Enabled = false;
            buttonSave_ZYA.Image = (Image)resources.GetObject("buttonSave_ZYA.Image");
            buttonSave_ZYA.Location = new Point(128, 9);
            buttonSave_ZYA.Margin = new Padding(3, 2, 3, 2);
            buttonSave_ZYA.Name = "buttonSave_ZYA";
            buttonSave_ZYA.Size = new Size(53, 46);
            buttonSave_ZYA.TabIndex = 2;
            toolTipSave_ZYA.SetToolTip(buttonSave_ZYA, "Сохранить обработанные данные в файл в формате CSV\r\n");
            buttonSave_ZYA.UseVisualStyleBackColor = true;
            buttonSave_ZYA.Click += buttonSave_ZYA_Click;
            // 
            // buttonDown_ZYA
            // 
            buttonDown_ZYA.Enabled = false;
            buttonDown_ZYA.Image = (Image)resources.GetObject("buttonDown_ZYA.Image");
            buttonDown_ZYA.Location = new Point(70, 9);
            buttonDown_ZYA.Margin = new Padding(3, 2, 3, 2);
            buttonDown_ZYA.Name = "buttonDown_ZYA";
            buttonDown_ZYA.Size = new Size(52, 46);
            buttonDown_ZYA.TabIndex = 1;
            toolTipDown_ZYA.SetToolTip(buttonDown_ZYA, "Выполнить обработку данных\r\n");
            buttonDown_ZYA.UseVisualStyleBackColor = true;
            buttonDown_ZYA.Click += buttonDown_ZYA_Click;
            // 
            // buttonOpen_ZYA
            // 
            buttonOpen_ZYA.Image = (Image)resources.GetObject("buttonOpen_ZYA.Image");
            buttonOpen_ZYA.Location = new Point(10, 9);
            buttonOpen_ZYA.Margin = new Padding(3, 2, 3, 2);
            buttonOpen_ZYA.Name = "buttonOpen_ZYA";
            buttonOpen_ZYA.Size = new Size(54, 46);
            buttonOpen_ZYA.TabIndex = 0;
            toolTip_ZYA.SetToolTip(buttonOpen_ZYA, "Открыть файл для обработки в формате данных CSV");
            buttonOpen_ZYA.UseVisualStyleBackColor = true;
            buttonOpen_ZYA.Click += buttonOpen_ZYA_Click;
            // 
            // panelCond_ZYA
            // 
            panelCond_ZYA.Controls.Add(groupBoxCond_ZYA);
            panelCond_ZYA.Dock = DockStyle.Top;
            panelCond_ZYA.Location = new Point(0, 70);
            panelCond_ZYA.Margin = new Padding(3, 2, 3, 2);
            panelCond_ZYA.Name = "panelCond_ZYA";
            panelCond_ZYA.Size = new Size(774, 70);
            panelCond_ZYA.TabIndex = 1;
            // 
            // groupBoxCond_ZYA
            // 
            groupBoxCond_ZYA.Controls.Add(labelText_ZYA);
            groupBoxCond_ZYA.Controls.Add(textBoxCond_ZYA);
            groupBoxCond_ZYA.Dock = DockStyle.Fill;
            groupBoxCond_ZYA.Location = new Point(0, 0);
            groupBoxCond_ZYA.Margin = new Padding(3, 2, 3, 2);
            groupBoxCond_ZYA.Name = "groupBoxCond_ZYA";
            groupBoxCond_ZYA.Padding = new Padding(3, 2, 3, 2);
            groupBoxCond_ZYA.Size = new Size(774, 70);
            groupBoxCond_ZYA.TabIndex = 0;
            groupBoxCond_ZYA.TabStop = false;
            groupBoxCond_ZYA.Text = "Условие";
            // 
            // textBoxCond_ZYA
            // 
            textBoxCond_ZYA.Dock = DockStyle.Fill;
            textBoxCond_ZYA.Location = new Point(3, 18);
            textBoxCond_ZYA.Margin = new Padding(3, 2, 3, 2);
            textBoxCond_ZYA.Multiline = true;
            textBoxCond_ZYA.Name = "textBoxCond_ZYA";
            textBoxCond_ZYA.ReadOnly = true;
            textBoxCond_ZYA.Size = new Size(768, 50);
            textBoxCond_ZYA.TabIndex = 0;
            textBoxCond_ZYA.TextChanged += textBoxCond_ZYA_TextChanged;
            // 
            // panelIn_ZYA
            // 
            panelIn_ZYA.Controls.Add(groupBoxIn_ZYA);
            panelIn_ZYA.Dock = DockStyle.Left;
            panelIn_ZYA.Location = new Point(0, 140);
            panelIn_ZYA.Margin = new Padding(3, 2, 3, 2);
            panelIn_ZYA.Name = "panelIn_ZYA";
            panelIn_ZYA.Size = new Size(355, 289);
            panelIn_ZYA.TabIndex = 2;
            // 
            // groupBoxIn_ZYA
            // 
            groupBoxIn_ZYA.Controls.Add(dataGridViewIn_ZYA);
            groupBoxIn_ZYA.Dock = DockStyle.Fill;
            groupBoxIn_ZYA.Location = new Point(0, 0);
            groupBoxIn_ZYA.Margin = new Padding(3, 2, 3, 2);
            groupBoxIn_ZYA.Name = "groupBoxIn_ZYA";
            groupBoxIn_ZYA.Padding = new Padding(3, 2, 3, 2);
            groupBoxIn_ZYA.Size = new Size(355, 289);
            groupBoxIn_ZYA.TabIndex = 0;
            groupBoxIn_ZYA.TabStop = false;
            groupBoxIn_ZYA.Text = "Ввод";
            // 
            // dataGridViewIn_ZYA
            // 
            dataGridViewIn_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_ZYA.ColumnHeadersVisible = false;
            dataGridViewIn_ZYA.Dock = DockStyle.Fill;
            dataGridViewIn_ZYA.Location = new Point(3, 18);
            dataGridViewIn_ZYA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewIn_ZYA.Name = "dataGridViewIn_ZYA";
            dataGridViewIn_ZYA.ReadOnly = true;
            dataGridViewIn_ZYA.RowHeadersVisible = false;
            dataGridViewIn_ZYA.RowHeadersWidth = 51;
            dataGridViewIn_ZYA.Size = new Size(349, 269);
            dataGridViewIn_ZYA.TabIndex = 0;
            // 
            // splitter_ZYA
            // 
            splitter_ZYA.Location = new Point(355, 140);
            splitter_ZYA.Margin = new Padding(3, 2, 3, 2);
            splitter_ZYA.Name = "splitter_ZYA";
            splitter_ZYA.Size = new Size(10, 289);
            splitter_ZYA.TabIndex = 3;
            splitter_ZYA.TabStop = false;
            // 
            // panelOut_ZYA
            // 
            panelOut_ZYA.Controls.Add(groupBoxOut_ZYA);
            panelOut_ZYA.Dock = DockStyle.Fill;
            panelOut_ZYA.Location = new Point(365, 140);
            panelOut_ZYA.Margin = new Padding(3, 2, 3, 2);
            panelOut_ZYA.Name = "panelOut_ZYA";
            panelOut_ZYA.Size = new Size(409, 289);
            panelOut_ZYA.TabIndex = 4;
            // 
            // groupBoxOut_ZYA
            // 
            groupBoxOut_ZYA.Controls.Add(dataGridViewOut_ZYA);
            groupBoxOut_ZYA.Dock = DockStyle.Fill;
            groupBoxOut_ZYA.Location = new Point(0, 0);
            groupBoxOut_ZYA.Margin = new Padding(3, 2, 3, 2);
            groupBoxOut_ZYA.Name = "groupBoxOut_ZYA";
            groupBoxOut_ZYA.Padding = new Padding(3, 2, 3, 2);
            groupBoxOut_ZYA.Size = new Size(409, 289);
            groupBoxOut_ZYA.TabIndex = 0;
            groupBoxOut_ZYA.TabStop = false;
            groupBoxOut_ZYA.Text = "Вывод";
            // 
            // dataGridViewOut_ZYA
            // 
            dataGridViewOut_ZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_ZYA.ColumnHeadersVisible = false;
            dataGridViewOut_ZYA.Dock = DockStyle.Fill;
            dataGridViewOut_ZYA.Location = new Point(3, 18);
            dataGridViewOut_ZYA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewOut_ZYA.Name = "dataGridViewOut_ZYA";
            dataGridViewOut_ZYA.ReadOnly = true;
            dataGridViewOut_ZYA.RowHeadersVisible = false;
            dataGridViewOut_ZYA.RowHeadersWidth = 51;
            dataGridViewOut_ZYA.Size = new Size(403, 269);
            dataGridViewOut_ZYA.TabIndex = 0;
            // 
            // openFileDialog_ZYA
            // 
            openFileDialog_ZYA.FileName = "openFileDialog1";
            // 
            // toolTip_ZYA
            // 
            toolTip_ZYA.AutomaticDelay = 300;
            toolTip_ZYA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_ZYA.ToolTipTitle = "Открыть файл";
            // 
            // toolTipDown_ZYA
            // 
            toolTipDown_ZYA.AutomaticDelay = 300;
            toolTipDown_ZYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipDown_ZYA.ToolTipTitle = "Выполнить";
            // 
            // toolTipSave_ZYA
            // 
            toolTipSave_ZYA.AutomaticDelay = 300;
            toolTipSave_ZYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave_ZYA.ToolTipTitle = "Сохранить";
            // 
            // toolTipQuestion_ZYA
            // 
            toolTipQuestion_ZYA.AutomaticDelay = 300;
            toolTipQuestion_ZYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipQuestion_ZYA.ToolTipTitle = "Справка";
            // 
            // labelText_ZYA
            // 
            labelText_ZYA.AutoSize = true;
            labelText_ZYA.Location = new Point(12, 21);
            labelText_ZYA.Name = "labelText_ZYA";
            labelText_ZYA.Size = new Size(706, 45);
            labelText_ZYA.TabIndex = 1;
            labelText_ZYA.Text = resources.GetString("labelText_ZYA.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 429);
            Controls.Add(panelOut_ZYA);
            Controls.Add(splitter_ZYA);
            Controls.Add(panelIn_ZYA);
            Controls.Add(panelCond_ZYA);
            Controls.Add(panelButtons_ZYA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Жукова Я.А.";
            panelButtons_ZYA.ResumeLayout(false);
            panelCond_ZYA.ResumeLayout(false);
            groupBoxCond_ZYA.ResumeLayout(false);
            groupBoxCond_ZYA.PerformLayout();
            panelIn_ZYA.ResumeLayout(false);
            groupBoxIn_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ZYA).EndInit();
            panelOut_ZYA.ResumeLayout(false);
            groupBoxOut_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ZYA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_ZYA;
        private Panel panelCond_ZYA;
        private GroupBox groupBoxCond_ZYA;
        private Panel panelIn_ZYA;
        private GroupBox groupBoxIn_ZYA;
        private DataGridView dataGridViewIn_ZYA;
        private Splitter splitter_ZYA;
        private Panel panelOut_ZYA;
        private GroupBox groupBoxOut_ZYA;
        private DataGridView dataGridViewOut_ZYA;
        private Button buttonQuestion_ZYA;
        private Button buttonSave_ZYA;
        private Button buttonDown_ZYA;
        private Button buttonOpen_ZYA;
        private TextBox textBoxCond_ZYA;
        private OpenFileDialog openFileDialog_ZYA;
        private ToolTip toolTip_ZYA;
        private SaveFileDialog saveFileDialog_ZYA;
        private ToolTip toolTipDown_ZYA;
        private ToolTip toolTipSave_ZYA;
        private ToolTip toolTipQuestion_ZYA;
        private Label labelText_ZYA;
    }
}
