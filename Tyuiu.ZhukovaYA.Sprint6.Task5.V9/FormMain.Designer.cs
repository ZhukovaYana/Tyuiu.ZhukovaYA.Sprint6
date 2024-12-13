namespace Tyuiu.ZhukovaYA.Sprint6.Task5.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_ZYA = new System.Windows.Forms.Panel();
            this.buttonMessage_ZYA = new System.Windows.Forms.Button();
            this.buttonSave_ZYA = new System.Windows.Forms.Button();
            this.buttonDone_ZYA = new System.Windows.Forms.Button();
            this.groupBoxTask_ZYA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZYA = new System.Windows.Forms.TextBox();
            this.panelResult_ZYA = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZYA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_ZYA = new System.Windows.Forms.DataGridView();
            this.ColumnResult_ZYA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChart_ZYA = new System.Windows.Forms.Panel();
            this.chartResult_ZYA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterResult_ZYA = new System.Windows.Forms.Splitter();
            this.panelTask_ZYA.SuspendLayout();
            this.groupBoxTask_ZYA.SuspendLayout();
            this.panelResult_ZYA.SuspendLayout();
            this.groupBoxResult_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZYA)).BeginInit();
            this.panelChart_ZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZYA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_ZYA
            // 
            this.panelTask_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_ZYA.Controls.Add(this.buttonMessage_ZYA);
            this.panelTask_ZYA.Controls.Add(this.buttonSave_ZYA);
            this.panelTask_ZYA.Controls.Add(this.buttonDone_ZYA);
            this.panelTask_ZYA.Controls.Add(this.groupBoxTask_ZYA);
            this.panelTask_ZYA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ZYA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_ZYA.Name = "panelTask_ZYA";
            this.panelTask_ZYA.Size = new System.Drawing.Size(784, 93);
            this.panelTask_ZYA.TabIndex = 0;
            // 
            // buttonMessage_ZYA
            // 
            this.buttonMessage_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMessage_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMessage_ZYA.Location = new System.Drawing.Point(683, 20);
            this.buttonMessage_ZYA.Name = "buttonMessage_ZYA";
            this.buttonMessage_ZYA.Size = new System.Drawing.Size(86, 46);
            this.buttonMessage_ZYA.TabIndex = 3;
            this.buttonMessage_ZYA.Text = "?";
            this.buttonMessage_ZYA.UseVisualStyleBackColor = false;
            this.buttonMessage_ZYA.Click += new System.EventHandler(this.buttonMessage_ZYA_Click);
            this.buttonMessage_ZYA.MouseEnter += new System.EventHandler(this.buttonMessage_ZYA_MouseEnter);
            this.buttonMessage_ZYA.MouseLeave += new System.EventHandler(this.buttonMessage_ZYA_MouseLeave);
            // 
            // buttonSave_ZYA
            // 
            this.buttonSave_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave_ZYA.Location = new System.Drawing.Point(595, 20);
            this.buttonSave_ZYA.Name = "buttonSave_ZYA";
            this.buttonSave_ZYA.Size = new System.Drawing.Size(82, 46);
            this.buttonSave_ZYA.TabIndex = 2;
            this.buttonSave_ZYA.Text = "Открыть файл";
            this.buttonSave_ZYA.UseVisualStyleBackColor = false;
            this.buttonSave_ZYA.Click += new System.EventHandler(this.buttonSave_ZYA_Click);
            this.buttonSave_ZYA.MouseEnter += new System.EventHandler(this.buttonSave_ZYA_MouseEnter);
            this.buttonSave_ZYA.MouseLeave += new System.EventHandler(this.buttonSave_ZYA_MouseLeave);
            // 
            // buttonDone_ZYA
            // 
            this.buttonDone_ZYA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_ZYA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_ZYA.Location = new System.Drawing.Point(514, 20);
            this.buttonDone_ZYA.Name = "buttonDone_ZYA";
            this.buttonDone_ZYA.Size = new System.Drawing.Size(75, 46);
            this.buttonDone_ZYA.TabIndex = 1;
            this.buttonDone_ZYA.Text = "Выполнить";
            this.buttonDone_ZYA.UseVisualStyleBackColor = false;
            this.buttonDone_ZYA.Click += new System.EventHandler(this.buttonDone_ZYA_Click);
            this.buttonDone_ZYA.MouseEnter += new System.EventHandler(this.buttonDone_ZYA_MouseEnter);
            this.buttonDone_ZYA.MouseLeave += new System.EventHandler(this.buttonDone_ZYA_MouseLeave);
            // 
            // groupBoxTask_ZYA
            // 
            this.groupBoxTask_ZYA.Controls.Add(this.textBoxTask_ZYA);
            this.groupBoxTask_ZYA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_ZYA.Name = "groupBoxTask_ZYA";
            this.groupBoxTask_ZYA.Size = new System.Drawing.Size(504, 83);
            this.groupBoxTask_ZYA.TabIndex = 0;
            this.groupBoxTask_ZYA.TabStop = false;
            this.groupBoxTask_ZYA.Text = "Условие:";
            // 
            // textBoxTask_ZYA
            // 
            this.textBoxTask_ZYA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ZYA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZYA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZYA.Multiline = true;
            this.textBoxTask_ZYA.Name = "textBoxTask_ZYA";
            this.textBoxTask_ZYA.ReadOnly = true;
            this.textBoxTask_ZYA.Size = new System.Drawing.Size(498, 64);
            this.textBoxTask_ZYA.TabIndex = 0;
            this.textBoxTask_ZYA.Text = resources.GetString("textBoxTask_ZYA.Text");
            // 
            // panelResult_ZYA
            // 
            this.panelResult_ZYA.Controls.Add(this.groupBoxResult_ZYA);
            this.panelResult_ZYA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_ZYA.Location = new System.Drawing.Point(0, 93);
            this.panelResult_ZYA.Name = "panelResult_ZYA";
            this.panelResult_ZYA.Size = new System.Drawing.Size(200, 357);
            this.panelResult_ZYA.TabIndex = 1;
            // 
            // groupBoxResult_ZYA
            // 
            this.groupBoxResult_ZYA.Controls.Add(this.dataGridViewResult_ZYA);
            this.groupBoxResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_ZYA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_ZYA.Name = "groupBoxResult_ZYA";
            this.groupBoxResult_ZYA.Size = new System.Drawing.Size(200, 357);
            this.groupBoxResult_ZYA.TabIndex = 0;
            this.groupBoxResult_ZYA.TabStop = false;
            this.groupBoxResult_ZYA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_ZYA
            // 
            this.dataGridViewResult_ZYA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ZYA.ColumnHeadersVisible = false;
            this.dataGridViewResult_ZYA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResult_ZYA});
            this.dataGridViewResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_ZYA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_ZYA.Name = "dataGridViewResult_ZYA";
            this.dataGridViewResult_ZYA.RowHeadersVisible = false;
            this.dataGridViewResult_ZYA.Size = new System.Drawing.Size(194, 338);
            this.dataGridViewResult_ZYA.TabIndex = 0;
            // 
            // ColumnResult_ZYA
            // 
            this.ColumnResult_ZYA.HeaderText = "";
            this.ColumnResult_ZYA.Name = "ColumnResult_ZYA";
            this.ColumnResult_ZYA.ReadOnly = true;
            // 
            // panelChart_ZYA
            // 
            this.panelChart_ZYA.Controls.Add(this.chartResult_ZYA);
            this.panelChart_ZYA.Controls.Add(this.splitterResult_ZYA);
            this.panelChart_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_ZYA.Location = new System.Drawing.Point(200, 93);
            this.panelChart_ZYA.Name = "panelChart_ZYA";
            this.panelChart_ZYA.Size = new System.Drawing.Size(584, 357);
            this.panelChart_ZYA.TabIndex = 2;
            // 
            // chartResult_ZYA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_ZYA.ChartAreas.Add(chartArea2);
            this.chartResult_ZYA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartResult_ZYA.Legends.Add(legend2);
            this.chartResult_ZYA.Location = new System.Drawing.Point(3, 0);
            this.chartResult_ZYA.Name = "chartResult_ZYA";
            this.chartResult_ZYA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_ZYA.Series.Add(series2);
            this.chartResult_ZYA.Size = new System.Drawing.Size(581, 357);
            this.chartResult_ZYA.TabIndex = 1;
            this.chartResult_ZYA.Text = "chart1";
            // 
            // splitterResult_ZYA
            // 
            this.splitterResult_ZYA.Location = new System.Drawing.Point(0, 0);
            this.splitterResult_ZYA.Name = "splitterResult_ZYA";
            this.splitterResult_ZYA.Size = new System.Drawing.Size(3, 357);
            this.splitterResult_ZYA.TabIndex = 0;
            this.splitterResult_ZYA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.panelChart_ZYA);
            this.Controls.Add(this.panelResult_ZYA);
            this.Controls.Add(this.panelTask_ZYA);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 9 | Жукова Я.А.";
            this.panelTask_ZYA.ResumeLayout(false);
            this.groupBoxTask_ZYA.ResumeLayout(false);
            this.groupBoxTask_ZYA.PerformLayout();
            this.panelResult_ZYA.ResumeLayout(false);
            this.groupBoxResult_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZYA)).EndInit();
            this.panelChart_ZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZYA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_ZYA;
        private System.Windows.Forms.Button buttonMessage_ZYA;
        private System.Windows.Forms.Button buttonSave_ZYA;
        private System.Windows.Forms.Button buttonDone_ZYA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZYA;
        private System.Windows.Forms.TextBox textBoxTask_ZYA;
        private System.Windows.Forms.Panel panelResult_ZYA;
        private System.Windows.Forms.GroupBox groupBoxResult_ZYA;
        private System.Windows.Forms.Panel panelChart_ZYA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_ZYA;
        private System.Windows.Forms.Splitter splitterResult_ZYA;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZYA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult_ZYA;
    }
}

