namespace Tyuiu.ZhukovaYA.Sprint6.Task4.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTask_ZYA = new System.Windows.Forms.Panel();
            this.groupBoxInputOutput_ZYA = new System.Windows.Forms.GroupBox();
            this.buttonSave_ZYA = new System.Windows.Forms.Button();
            this.buttonMessage_ZYA = new System.Windows.Forms.Button();
            this.buttonDone_ZYA = new System.Windows.Forms.Button();
            this.textBoxTaskStopValue_ZYA = new System.Windows.Forms.TextBox();
            this.textBoxTaskStartValue_ZYA = new System.Windows.Forms.TextBox();
            this.labelTaskStopValue_ZYA = new System.Windows.Forms.Label();
            this.labelTaskStartValue_ZYA = new System.Windows.Forms.Label();
            this.groupBoxTask_ZYA = new System.Windows.Forms.GroupBox();
            this.pictureBox_ZYA = new System.Windows.Forms.PictureBox();
            this.panelResult_ZYA = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZYA = new System.Windows.Forms.TextBox();
            this.splitterResult_ZYA = new System.Windows.Forms.Splitter();
            this.panelResultGraph_ZYA = new System.Windows.Forms.Panel();
            this.chartResult_ZYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_ZYA.SuspendLayout();
            this.groupBoxInputOutput_ZYA.SuspendLayout();
            this.groupBoxTask_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZYA)).BeginInit();
            this.panelResult_ZYA.SuspendLayout();
            this.groupBoxResult_ZYA.SuspendLayout();
            this.panelResultGraph_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZYA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_ZYA
            // 
            this.panelTask_ZYA.AutoSize = true;
            this.panelTask_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_ZYA.Controls.Add(this.groupBoxInputOutput_ZYA);
            this.panelTask_ZYA.Controls.Add(this.groupBoxTask_ZYA);
            this.panelTask_ZYA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ZYA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_ZYA.Name = "panelTask_ZYA";
            this.panelTask_ZYA.Size = new System.Drawing.Size(859, 132);
            this.panelTask_ZYA.TabIndex = 0;
            // 
            // groupBoxInputOutput_ZYA
            // 
            this.groupBoxInputOutput_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInputOutput_ZYA.Controls.Add(this.buttonSave_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.buttonMessage_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.buttonDone_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.textBoxTaskStopValue_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.textBoxTaskStartValue_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.labelTaskStopValue_ZYA);
            this.groupBoxInputOutput_ZYA.Controls.Add(this.labelTaskStartValue_ZYA);
            this.groupBoxInputOutput_ZYA.Location = new System.Drawing.Point(435, 4);
            this.groupBoxInputOutput_ZYA.Name = "groupBoxInputOutput_ZYA";
            this.groupBoxInputOutput_ZYA.Size = new System.Drawing.Size(421, 122);
            this.groupBoxInputOutput_ZYA.TabIndex = 1;
            this.groupBoxInputOutput_ZYA.TabStop = false;
            this.groupBoxInputOutput_ZYA.Text = "Ввод данных";
            // 
            // buttonSave_ZYA
            // 
            this.buttonSave_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave_ZYA.Location = new System.Drawing.Point(230, 80);
            this.buttonSave_ZYA.Name = "buttonSave_ZYA";
            this.buttonSave_ZYA.Size = new System.Drawing.Size(182, 36);
            this.buttonSave_ZYA.TabIndex = 6;
            this.buttonSave_ZYA.Text = "Сохранить";
            this.buttonSave_ZYA.UseVisualStyleBackColor = false;
            this.buttonSave_ZYA.Click += new System.EventHandler(this.buttonSave_ZYA_Click);
            this.buttonSave_ZYA.MouseEnter += new System.EventHandler(this.buttonSave_ZYA_MouseEnter);
            this.buttonSave_ZYA.MouseLeave += new System.EventHandler(this.buttonSave_ZYA_MouseLeave);
            // 
            // buttonMessage_ZYA
            // 
            this.buttonMessage_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMessage_ZYA.Location = new System.Drawing.Point(10, 79);
            this.buttonMessage_ZYA.Name = "buttonMessage_ZYA";
            this.buttonMessage_ZYA.Size = new System.Drawing.Size(41, 37);
            this.buttonMessage_ZYA.TabIndex = 5;
            this.buttonMessage_ZYA.Text = "?";
            this.buttonMessage_ZYA.UseVisualStyleBackColor = false;
            this.buttonMessage_ZYA.Click += new System.EventHandler(this.buttonMessage_ZYA_Click);
            this.buttonMessage_ZYA.MouseEnter += new System.EventHandler(this.buttonMessage_ZYA_MouseEnter);
            this.buttonMessage_ZYA.MouseLeave += new System.EventHandler(this.buttonMessage_ZYA_MouseLeave);
            // 
            // buttonDone_ZYA
            // 
            this.buttonDone_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_ZYA.Location = new System.Drawing.Point(57, 80);
            this.buttonDone_ZYA.Name = "buttonDone_ZYA";
            this.buttonDone_ZYA.Size = new System.Drawing.Size(167, 36);
            this.buttonDone_ZYA.TabIndex = 4;
            this.buttonDone_ZYA.Text = "Выполнить";
            this.buttonDone_ZYA.UseVisualStyleBackColor = false;
            this.buttonDone_ZYA.Click += new System.EventHandler(this.buttonDone_ZYA_Click);
            this.buttonDone_ZYA.MouseEnter += new System.EventHandler(this.buttonDone_ZYA_MouseEnter);
            this.buttonDone_ZYA.MouseLeave += new System.EventHandler(this.buttonDone_ZYA_MouseLeave);
            // 
            // textBoxTaskStopValue_ZYA
            // 
            this.textBoxTaskStopValue_ZYA.Location = new System.Drawing.Point(114, 38);
            this.textBoxTaskStopValue_ZYA.Name = "textBoxTaskStopValue_ZYA";
            this.textBoxTaskStopValue_ZYA.Size = new System.Drawing.Size(96, 20);
            this.textBoxTaskStopValue_ZYA.TabIndex = 3;
            // 
            // textBoxTaskStartValue_ZYA
            // 
            this.textBoxTaskStartValue_ZYA.Location = new System.Drawing.Point(10, 37);
            this.textBoxTaskStartValue_ZYA.Name = "textBoxTaskStartValue_ZYA";
            this.textBoxTaskStartValue_ZYA.Size = new System.Drawing.Size(93, 20);
            this.textBoxTaskStartValue_ZYA.TabIndex = 2;
            // 
            // labelTaskStopValue_ZYA
            // 
            this.labelTaskStopValue_ZYA.AutoSize = true;
            this.labelTaskStopValue_ZYA.Location = new System.Drawing.Point(111, 20);
            this.labelTaskStopValue_ZYA.Name = "labelTaskStopValue_ZYA";
            this.labelTaskStopValue_ZYA.Size = new System.Drawing.Size(69, 13);
            this.labelTaskStopValue_ZYA.TabIndex = 1;
            this.labelTaskStopValue_ZYA.Text = "Конец шага:";
            // 
            // labelTaskStartValue_ZYA
            // 
            this.labelTaskStartValue_ZYA.AutoSize = true;
            this.labelTaskStartValue_ZYA.Location = new System.Drawing.Point(7, 20);
            this.labelTaskStartValue_ZYA.Name = "labelTaskStartValue_ZYA";
            this.labelTaskStartValue_ZYA.Size = new System.Drawing.Size(67, 13);
            this.labelTaskStartValue_ZYA.TabIndex = 0;
            this.labelTaskStartValue_ZYA.Text = "Старт шага:";
            // 
            // groupBoxTask_ZYA
            // 
            this.groupBoxTask_ZYA.Controls.Add(this.pictureBox_ZYA);
            this.groupBoxTask_ZYA.Location = new System.Drawing.Point(6, 3);
            this.groupBoxTask_ZYA.Name = "groupBoxTask_ZYA";
            this.groupBoxTask_ZYA.Size = new System.Drawing.Size(423, 126);
            this.groupBoxTask_ZYA.TabIndex = 0;
            this.groupBoxTask_ZYA.TabStop = false;
            this.groupBoxTask_ZYA.Text = "Условие:";
            // 
            // pictureBox_ZYA
            // 
            this.pictureBox_ZYA.Image = global::Tyuiu.ZhukovaYA.Sprint6.Task4.V6.Properties.Resources.Без_названия__2_;
            this.pictureBox_ZYA.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_ZYA.Name = "pictureBox_ZYA";
            this.pictureBox_ZYA.Size = new System.Drawing.Size(411, 98);
            this.pictureBox_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ZYA.TabIndex = 0;
            this.pictureBox_ZYA.TabStop = false;
            // 
            // panelResult_ZYA
            // 
            this.panelResult_ZYA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResult_ZYA.Controls.Add(this.groupBoxResult_ZYA);
            this.panelResult_ZYA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_ZYA.Location = new System.Drawing.Point(0, 132);
            this.panelResult_ZYA.Name = "panelResult_ZYA";
            this.panelResult_ZYA.Size = new System.Drawing.Size(177, 393);
            this.panelResult_ZYA.TabIndex = 1;
            // 
            // groupBoxResult_ZYA
            // 
            this.groupBoxResult_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResult_ZYA.Controls.Add(this.textBoxResult_ZYA);
            this.groupBoxResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_ZYA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_ZYA.Name = "groupBoxResult_ZYA";
            this.groupBoxResult_ZYA.Size = new System.Drawing.Size(177, 393);
            this.groupBoxResult_ZYA.TabIndex = 0;
            this.groupBoxResult_ZYA.TabStop = false;
            this.groupBoxResult_ZYA.Text = "Вывод:";
            // 
            // textBoxResult_ZYA
            // 
            this.textBoxResult_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_ZYA.Multiline = true;
            this.textBoxResult_ZYA.Name = "textBoxResult_ZYA";
            this.textBoxResult_ZYA.ReadOnly = true;
            this.textBoxResult_ZYA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZYA.Size = new System.Drawing.Size(171, 374);
            this.textBoxResult_ZYA.TabIndex = 0;
            // 
            // splitterResult_ZYA
            // 
            this.splitterResult_ZYA.Location = new System.Drawing.Point(0, 0);
            this.splitterResult_ZYA.Name = "splitterResult_ZYA";
            this.splitterResult_ZYA.Size = new System.Drawing.Size(3, 393);
            this.splitterResult_ZYA.TabIndex = 0;
            this.splitterResult_ZYA.TabStop = false;
            // 
            // panelResultGraph_ZYA
            // 
            this.panelResultGraph_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.panelResultGraph_ZYA.Controls.Add(this.chartResult_ZYA);
            this.panelResultGraph_ZYA.Controls.Add(this.splitterResult_ZYA);
            this.panelResultGraph_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultGraph_ZYA.Location = new System.Drawing.Point(177, 132);
            this.panelResultGraph_ZYA.Name = "panelResultGraph_ZYA";
            this.panelResultGraph_ZYA.Size = new System.Drawing.Size(682, 393);
            this.panelResultGraph_ZYA.TabIndex = 1;
            // 
            // chartResult_ZYA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_ZYA.ChartAreas.Add(chartArea1);
            this.chartResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_ZYA.Legends.Add(legend1);
            this.chartResult_ZYA.Location = new System.Drawing.Point(3, 0);
            this.chartResult_ZYA.Name = "chartResult_ZYA";
            this.chartResult_ZYA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_ZYA.Series.Add(series1);
            this.chartResult_ZYA.Size = new System.Drawing.Size(679, 393);
            this.chartResult_ZYA.TabIndex = 1;
            this.chartResult_ZYA.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.DarkOrchid;
            title1.Name = "TitleFunc";
            title1.Text = "График функции f(x)";
            this.chartResult_ZYA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 525);
            this.Controls.Add(this.panelResultGraph_ZYA);
            this.Controls.Add(this.panelResult_ZYA);
            this.Controls.Add(this.panelTask_ZYA);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 6 | Жукова Я.А.";
            this.panelTask_ZYA.ResumeLayout(false);
            this.groupBoxInputOutput_ZYA.ResumeLayout(false);
            this.groupBoxInputOutput_ZYA.PerformLayout();
            this.groupBoxTask_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZYA)).EndInit();
            this.panelResult_ZYA.ResumeLayout(false);
            this.groupBoxResult_ZYA.ResumeLayout(false);
            this.groupBoxResult_ZYA.PerformLayout();
            this.panelResultGraph_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZYA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_ZYA;
        private System.Windows.Forms.Panel panelResult_ZYA;
        private System.Windows.Forms.GroupBox groupBoxInputOutput_ZYA;
        private System.Windows.Forms.Button buttonSave_ZYA;
        private System.Windows.Forms.Button buttonMessage_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.TextBox textBoxTaskStopValue_ZYA;
        private System.Windows.Forms.TextBox textBoxTaskStartValue_ZYA;
        private System.Windows.Forms.Label labelTaskStopValue_ZYA;
        private System.Windows.Forms.Label labelTaskStartValue_ZYA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZYA;
        private System.Windows.Forms.GroupBox groupBoxResult_ZYA;
        private System.Windows.Forms.TextBox textBoxResult_ZYA;
        private System.Windows.Forms.Splitter splitterResult_ZYA;
        private System.Windows.Forms.Panel panelResultGraph_ZYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_ZYA;
        private System.Windows.Forms.PictureBox pictureBox_ZYA;
    }
}

