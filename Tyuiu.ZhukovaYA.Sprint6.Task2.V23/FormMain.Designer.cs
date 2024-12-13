namespace Tyuiu.ZhukovaYA.Sprint6.Task2.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTaskYZA = new System.Windows.Forms.GroupBox();
            this.groupBoxIntYZA = new System.Windows.Forms.GroupBox();
            this.textBoxStopValueYZA = new System.Windows.Forms.TextBox();
            this.textBoxStartValueYZA = new System.Windows.Forms.TextBox();
            this.labelStopValueYZA = new System.Windows.Forms.Label();
            this.labelStartValueYZA = new System.Windows.Forms.Label();
            this.groupBoxResultYZA = new System.Windows.Forms.GroupBox();
            this.chartResultYZA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResultYZA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDoneYZA = new System.Windows.Forms.Button();
            this.buttonMessageYZA = new System.Windows.Forms.Button();
            this.pictureBox_ZYA = new System.Windows.Forms.PictureBox();
            this.groupBoxTaskYZA.SuspendLayout();
            this.groupBoxIntYZA.SuspendLayout();
            this.groupBoxResultYZA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultYZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultYZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZYA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTaskYZA
            // 
            this.groupBoxTaskYZA.Controls.Add(this.pictureBox_ZYA);
            this.groupBoxTaskYZA.Location = new System.Drawing.Point(13, 25);
            this.groupBoxTaskYZA.Name = "groupBoxTaskYZA";
            this.groupBoxTaskYZA.Size = new System.Drawing.Size(393, 228);
            this.groupBoxTaskYZA.TabIndex = 0;
            this.groupBoxTaskYZA.TabStop = false;
            this.groupBoxTaskYZA.Text = "Условие";
            // 
            // groupBoxIntYZA
            // 
            this.groupBoxIntYZA.Controls.Add(this.textBoxStopValueYZA);
            this.groupBoxIntYZA.Controls.Add(this.textBoxStartValueYZA);
            this.groupBoxIntYZA.Controls.Add(this.labelStopValueYZA);
            this.groupBoxIntYZA.Controls.Add(this.labelStartValueYZA);
            this.groupBoxIntYZA.Location = new System.Drawing.Point(13, 361);
            this.groupBoxIntYZA.Name = "groupBoxIntYZA";
            this.groupBoxIntYZA.Size = new System.Drawing.Size(240, 77);
            this.groupBoxIntYZA.TabIndex = 1;
            this.groupBoxIntYZA.TabStop = false;
            this.groupBoxIntYZA.Text = "Ввод данных";
            // 
            // textBoxStopValueYZA
            // 
            this.textBoxStopValueYZA.Location = new System.Drawing.Point(118, 51);
            this.textBoxStopValueYZA.Name = "textBoxStopValueYZA";
            this.textBoxStopValueYZA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValueYZA.TabIndex = 3;
            // 
            // textBoxStartValueYZA
            // 
            this.textBoxStartValueYZA.Location = new System.Drawing.Point(7, 50);
            this.textBoxStartValueYZA.Name = "textBoxStartValueYZA";
            this.textBoxStartValueYZA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStartValueYZA.TabIndex = 2;
            // 
            // labelStopValueYZA
            // 
            this.labelStopValueYZA.AutoSize = true;
            this.labelStopValueYZA.Location = new System.Drawing.Point(115, 20);
            this.labelStopValueYZA.Name = "labelStopValueYZA";
            this.labelStopValueYZA.Size = new System.Drawing.Size(69, 13);
            this.labelStopValueYZA.TabIndex = 1;
            this.labelStopValueYZA.Text = "Конец шага:";
            // 
            // labelStartValueYZA
            // 
            this.labelStartValueYZA.AutoSize = true;
            this.labelStartValueYZA.Location = new System.Drawing.Point(7, 20);
            this.labelStartValueYZA.Name = "labelStartValueYZA";
            this.labelStartValueYZA.Size = new System.Drawing.Size(67, 13);
            this.labelStartValueYZA.TabIndex = 0;
            this.labelStartValueYZA.Text = "Старт шага:";
            // 
            // groupBoxResultYZA
            // 
            this.groupBoxResultYZA.Controls.Add(this.chartResultYZA);
            this.groupBoxResultYZA.Controls.Add(this.dataGridViewResultYZA);
            this.groupBoxResultYZA.Location = new System.Drawing.Point(421, 25);
            this.groupBoxResultYZA.Name = "groupBoxResultYZA";
            this.groupBoxResultYZA.Size = new System.Drawing.Size(367, 413);
            this.groupBoxResultYZA.TabIndex = 2;
            this.groupBoxResultYZA.TabStop = false;
            this.groupBoxResultYZA.Text = "Вывод данных";
            // 
            // chartResultYZA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResultYZA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartResultYZA.Legends.Add(legend3);
            this.chartResultYZA.Location = new System.Drawing.Point(134, 19);
            this.chartResultYZA.Name = "chartResultYZA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResultYZA.Series.Add(series3);
            this.chartResultYZA.Size = new System.Drawing.Size(233, 388);
            this.chartResultYZA.TabIndex = 1;
            this.chartResultYZA.Text = "chart1";
            // 
            // dataGridViewResultYZA
            // 
            this.dataGridViewResultYZA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultYZA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResultYZA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResultYZA.Name = "dataGridViewResultYZA";
            this.dataGridViewResultYZA.ReadOnly = true;
            this.dataGridViewResultYZA.RowHeadersVisible = false;
            this.dataGridViewResultYZA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResultYZA.Size = new System.Drawing.Size(122, 388);
            this.dataGridViewResultYZA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // buttonDoneYZA
            // 
            this.buttonDoneYZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDoneYZA.Location = new System.Drawing.Point(344, 375);
            this.buttonDoneYZA.Name = "buttonDoneYZA";
            this.buttonDoneYZA.Size = new System.Drawing.Size(71, 57);
            this.buttonDoneYZA.TabIndex = 3;
            this.buttonDoneYZA.Text = "Выполнить";
            this.buttonDoneYZA.UseVisualStyleBackColor = false;
            this.buttonDoneYZA.Click += new System.EventHandler(this.buttonDoneYZA_Click);
            this.buttonDoneYZA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDoneYZA_MouseDown);
            this.buttonDoneYZA.MouseEnter += new System.EventHandler(this.buttonDoneYZA_MouseEnter);
            this.buttonDoneYZA.MouseLeave += new System.EventHandler(this.buttonDoneYZA_MouseLeave);
            // 
            // buttonMessageYZA
            // 
            this.buttonMessageYZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMessageYZA.Location = new System.Drawing.Point(263, 375);
            this.buttonMessageYZA.Name = "buttonMessageYZA";
            this.buttonMessageYZA.Size = new System.Drawing.Size(75, 56);
            this.buttonMessageYZA.TabIndex = 4;
            this.buttonMessageYZA.Text = "?";
            this.buttonMessageYZA.UseVisualStyleBackColor = false;
            this.buttonMessageYZA.Click += new System.EventHandler(this.buttonMessageYZA_Click);
            this.buttonMessageYZA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMessageYZA_MouseDown);
            this.buttonMessageYZA.MouseEnter += new System.EventHandler(this.buttonMessageYZA_MouseEnter);
            this.buttonMessageYZA.MouseLeave += new System.EventHandler(this.buttonMessageYZA_MouseLeave);
            // 
            // pictureBox_ZYA
            // 
            this.pictureBox_ZYA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_ZYA.Image = global::Tyuiu.ZhukovaYA.Sprint6.Task2.V23.Properties.Resources.Без_названия__1_;
            this.pictureBox_ZYA.Location = new System.Drawing.Point(10, 19);
            this.pictureBox_ZYA.Name = "pictureBox_ZYA";
            this.pictureBox_ZYA.Size = new System.Drawing.Size(377, 203);
            this.pictureBox_ZYA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ZYA.TabIndex = 0;
            this.pictureBox_ZYA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMessageYZA);
            this.Controls.Add(this.buttonDoneYZA);
            this.Controls.Add(this.groupBoxResultYZA);
            this.Controls.Add(this.groupBoxIntYZA);
            this.Controls.Add(this.groupBoxTaskYZA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Жукова Я.А.";
            this.groupBoxTaskYZA.ResumeLayout(false);
            this.groupBoxIntYZA.ResumeLayout(false);
            this.groupBoxIntYZA.PerformLayout();
            this.groupBoxResultYZA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultYZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultYZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ZYA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskYZA;
        private System.Windows.Forms.GroupBox groupBoxIntYZA;
        private System.Windows.Forms.GroupBox groupBoxResultYZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultYZA;
        private System.Windows.Forms.DataGridView dataGridViewResultYZA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button buttonDoneYZA;
        private System.Windows.Forms.TextBox textBoxStopValueYZA;
        private System.Windows.Forms.TextBox textBoxStartValueYZA;
        private System.Windows.Forms.Label labelStopValueYZA;
        private System.Windows.Forms.Label labelStartValueYZA;
        private System.Windows.Forms.Button buttonMessageYZA;
        private System.Windows.Forms.PictureBox pictureBox_ZYA;
    }
}

