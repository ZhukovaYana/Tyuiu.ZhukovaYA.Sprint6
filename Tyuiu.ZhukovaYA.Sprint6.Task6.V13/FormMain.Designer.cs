namespace Tyuiu.ZhukovaYA.Sprint6.Task6.V13
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
            panelUp_ZYA = new Panel();
            buttonHelp_ZYA = new Button();
            buttonStart_ZYA = new Button();
            buttonOpen_ZYA = new Button();
            groupBoxCondition_ZYA = new GroupBox();
            labelConditionText_ZYA = new Label();
            panelLeft_ZYA = new Panel();
            groupInput_ZYA = new GroupBox();
            textBoxInput_ZYA = new TextBox();
            panelRight_ZYA = new Panel();
            groupBoxOutput_ZYA = new GroupBox();
            textBoxOutput_ZYA = new TextBox();
            openFileDialogTask_ZYA = new OpenFileDialog();
            toolTipHelp_ZYA = new ToolTip(components);
            label1 = new Label();
            panelUp_ZYA.SuspendLayout();
            groupBoxCondition_ZYA.SuspendLayout();
            panelLeft_ZYA.SuspendLayout();
            groupInput_ZYA.SuspendLayout();
            panelRight_ZYA.SuspendLayout();
            groupBoxOutput_ZYA.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_ZYA
            // 
            panelUp_ZYA.Controls.Add(buttonHelp_ZYA);
            panelUp_ZYA.Controls.Add(buttonStart_ZYA);
            panelUp_ZYA.Controls.Add(buttonOpen_ZYA);
            panelUp_ZYA.Controls.Add(groupBoxCondition_ZYA);
            panelUp_ZYA.Dock = DockStyle.Top;
            panelUp_ZYA.Location = new Point(0, 0);
            panelUp_ZYA.Name = "panelUp_ZYA";
            panelUp_ZYA.Size = new Size(800, 149);
            panelUp_ZYA.TabIndex = 0;
            // 
            // buttonHelp_ZYA
            // 
            buttonHelp_ZYA.Image = (Image)resources.GetObject("buttonHelp_ZYA.Image");
            buttonHelp_ZYA.Location = new Point(740, 3);
            buttonHelp_ZYA.Name = "buttonHelp_ZYA";
            buttonHelp_ZYA.Size = new Size(57, 57);
            buttonHelp_ZYA.TabIndex = 3;
            toolTipHelp_ZYA.SetToolTip(buttonHelp_ZYA, "Открывает окно разработчика");
            buttonHelp_ZYA.UseVisualStyleBackColor = true;
            buttonHelp_ZYA.Click += buttonHelp_ZYA_Click;
            // 
            // buttonStart_ZYA
            // 
            buttonStart_ZYA.Enabled = false;
            buttonStart_ZYA.Image = (Image)resources.GetObject("buttonStart_ZYA.Image");
            buttonStart_ZYA.Location = new Point(66, 3);
            buttonStart_ZYA.Name = "buttonStart_ZYA";
            buttonStart_ZYA.Size = new Size(57, 57);
            buttonStart_ZYA.TabIndex = 2;
            toolTipHelp_ZYA.SetToolTip(buttonStart_ZYA, "Выводит предпоследнее слово каждой строки");
            buttonStart_ZYA.UseVisualStyleBackColor = true;
            buttonStart_ZYA.Click += buttonStart_ZYA_Click;
            // 
            // buttonOpen_ZYA
            // 
            buttonOpen_ZYA.Image = (Image)resources.GetObject("buttonOpen_ZYA.Image");
            buttonOpen_ZYA.Location = new Point(3, 3);
            buttonOpen_ZYA.Name = "buttonOpen_ZYA";
            buttonOpen_ZYA.Size = new Size(57, 57);
            buttonOpen_ZYA.TabIndex = 1;
            toolTipHelp_ZYA.SetToolTip(buttonOpen_ZYA, "Открыть файл");
            buttonOpen_ZYA.UseVisualStyleBackColor = true;
            buttonOpen_ZYA.Click += buttonOpen_ZYA_Click;
            // 
            // groupBoxCondition_ZYA
            // 
            groupBoxCondition_ZYA.Controls.Add(label1);
            groupBoxCondition_ZYA.Controls.Add(labelConditionText_ZYA);
            groupBoxCondition_ZYA.Location = new Point(3, 65);
            groupBoxCondition_ZYA.Name = "groupBoxCondition_ZYA";
            groupBoxCondition_ZYA.Size = new Size(794, 81);
            groupBoxCondition_ZYA.TabIndex = 0;
            groupBoxCondition_ZYA.TabStop = false;
            groupBoxCondition_ZYA.Text = "Условие:";
            // 
            // labelConditionText_ZYA
            // 
            labelConditionText_ZYA.AutoSize = true;
            labelConditionText_ZYA.Location = new Point(6, 19);
            labelConditionText_ZYA.Name = "labelConditionText_ZYA";
            labelConditionText_ZYA.Size = new Size(0, 15);
            labelConditionText_ZYA.TabIndex = 0;
            // 
            // panelLeft_ZYA
            // 
            panelLeft_ZYA.Controls.Add(groupInput_ZYA);
            panelLeft_ZYA.Dock = DockStyle.Left;
            panelLeft_ZYA.Location = new Point(0, 149);
            panelLeft_ZYA.Name = "panelLeft_ZYA";
            panelLeft_ZYA.Size = new Size(394, 346);
            panelLeft_ZYA.TabIndex = 1;
            // 
            // groupInput_ZYA
            // 
            groupInput_ZYA.Controls.Add(textBoxInput_ZYA);
            groupInput_ZYA.Dock = DockStyle.Fill;
            groupInput_ZYA.Location = new Point(0, 0);
            groupInput_ZYA.Name = "groupInput_ZYA";
            groupInput_ZYA.Size = new Size(394, 346);
            groupInput_ZYA.TabIndex = 0;
            groupInput_ZYA.TabStop = false;
            groupInput_ZYA.Text = "Ввод:";
            // 
            // textBoxInput_ZYA
            // 
            textBoxInput_ZYA.Dock = DockStyle.Fill;
            textBoxInput_ZYA.Location = new Point(3, 19);
            textBoxInput_ZYA.Multiline = true;
            textBoxInput_ZYA.Name = "textBoxInput_ZYA";
            textBoxInput_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_ZYA.Size = new Size(388, 324);
            textBoxInput_ZYA.TabIndex = 0;
            // 
            // panelRight_ZYA
            // 
            panelRight_ZYA.Controls.Add(groupBoxOutput_ZYA);
            panelRight_ZYA.Dock = DockStyle.Fill;
            panelRight_ZYA.Location = new Point(394, 149);
            panelRight_ZYA.Name = "panelRight_ZYA";
            panelRight_ZYA.Size = new Size(406, 346);
            panelRight_ZYA.TabIndex = 2;
            // 
            // groupBoxOutput_ZYA
            // 
            groupBoxOutput_ZYA.Controls.Add(textBoxOutput_ZYA);
            groupBoxOutput_ZYA.Dock = DockStyle.Fill;
            groupBoxOutput_ZYA.Location = new Point(0, 0);
            groupBoxOutput_ZYA.Name = "groupBoxOutput_ZYA";
            groupBoxOutput_ZYA.Size = new Size(406, 346);
            groupBoxOutput_ZYA.TabIndex = 0;
            groupBoxOutput_ZYA.TabStop = false;
            groupBoxOutput_ZYA.Text = "Вывод:";
            // 
            // textBoxOutput_ZYA
            // 
            textBoxOutput_ZYA.Dock = DockStyle.Fill;
            textBoxOutput_ZYA.Location = new Point(3, 19);
            textBoxOutput_ZYA.Multiline = true;
            textBoxOutput_ZYA.Name = "textBoxOutput_ZYA";
            textBoxOutput_ZYA.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_ZYA.Size = new Size(400, 324);
            textBoxOutput_ZYA.TabIndex = 0;
            // 
            // openFileDialogTask_ZYA
            // 
            openFileDialogTask_ZYA.FileName = "openFileDialog1";
            // 
            // toolTipHelp_ZYA
            // 
            toolTipHelp_ZYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_ZYA.ToolTipTitle = "Подсказка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(650, 30);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(panelRight_ZYA);
            Controls.Add(panelLeft_ZYA);
            Controls.Add(panelUp_ZYA);
            MinimumSize = new Size(816, 534);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Жукова Я.А.";
            panelUp_ZYA.ResumeLayout(false);
            groupBoxCondition_ZYA.ResumeLayout(false);
            groupBoxCondition_ZYA.PerformLayout();
            panelLeft_ZYA.ResumeLayout(false);
            groupInput_ZYA.ResumeLayout(false);
            groupInput_ZYA.PerformLayout();
            panelRight_ZYA.ResumeLayout(false);
            groupBoxOutput_ZYA.ResumeLayout(false);
            groupBoxOutput_ZYA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_ZYA;
        private GroupBox groupBoxCondition_ZYA;
        private Panel panelLeft_ZYA;
        private Panel panelRight_ZYA;
        private Label labelConditionText_ZYA;
        private GroupBox groupInput_ZYA;
        private TextBox textBoxInput_ZYA;
        private GroupBox groupBoxOutput_ZYA;
        private TextBox textBoxOutput_ZYA;
        private Button buttonHelp_ZYA;
        private Button buttonStart_ZYA;
        private Button buttonOpen_ZYA;
        private OpenFileDialog openFileDialogTask_ZYA;
        private ToolTip toolTipHelp_ZYA;
        private Label label1;
    }
}
