namespace Tyuiu.ZhukovaYA.Sprint6.Task3.V13
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
            groupBoxTaskZYA = new GroupBox();
            dataGridViewTaskZYA = new DataGridView();
            textBoxTaskZYA = new TextBox();
            groupBoxResultZYA = new GroupBox();
            dataGridViewResultZYA = new DataGridView();
            labelResultZYA = new Label();
            buttonDoneZYA = new Button();
            buttonMessageZYA = new Button();
            groupBoxTaskZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskZYA).BeginInit();
            groupBoxResultZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultZYA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTaskZYA
            // 
            groupBoxTaskZYA.Controls.Add(dataGridViewTaskZYA);
            groupBoxTaskZYA.Controls.Add(textBoxTaskZYA);
            groupBoxTaskZYA.Location = new Point(15, 15);
            groupBoxTaskZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxTaskZYA.Name = "groupBoxTaskZYA";
            groupBoxTaskZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxTaskZYA.Size = new Size(663, 359);
            groupBoxTaskZYA.TabIndex = 0;
            groupBoxTaskZYA.TabStop = false;
            groupBoxTaskZYA.Text = "Условие";
            // 
            // dataGridViewTaskZYA
            // 
            dataGridViewTaskZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaskZYA.ColumnHeadersVisible = false;
            dataGridViewTaskZYA.Location = new Point(376, 23);
            dataGridViewTaskZYA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewTaskZYA.Name = "dataGridViewTaskZYA";
            dataGridViewTaskZYA.ReadOnly = true;
            dataGridViewTaskZYA.RowHeadersVisible = false;
            dataGridViewTaskZYA.Size = new Size(267, 254);
            dataGridViewTaskZYA.TabIndex = 1;
            // 
            // textBoxTaskZYA
            // 
            textBoxTaskZYA.BackColor = SystemColors.Control;
            textBoxTaskZYA.BorderStyle = BorderStyle.None;
            textBoxTaskZYA.Location = new Point(8, 23);
            textBoxTaskZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxTaskZYA.Multiline = true;
            textBoxTaskZYA.Name = "textBoxTaskZYA";
            textBoxTaskZYA.ReadOnly = true;
            textBoxTaskZYA.Size = new Size(360, 254);
            textBoxTaskZYA.TabIndex = 0;
            textBoxTaskZYA.Text = "Дан массив 5 на 5.\r\nВыполнить сортировку по возрастанию во втором столбце.\r\nРезультат вывести в DataGridView.";
            // 
            // groupBoxResultZYA
            // 
            groupBoxResultZYA.Controls.Add(dataGridViewResultZYA);
            groupBoxResultZYA.Controls.Add(labelResultZYA);
            groupBoxResultZYA.Location = new Point(686, 15);
            groupBoxResultZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxResultZYA.Name = "groupBoxResultZYA";
            groupBoxResultZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxResultZYA.Size = new Size(233, 288);
            groupBoxResultZYA.TabIndex = 1;
            groupBoxResultZYA.TabStop = false;
            groupBoxResultZYA.Text = "Вывод данных";
            // 
            // dataGridViewResultZYA
            // 
            dataGridViewResultZYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultZYA.ColumnHeadersVisible = false;
            dataGridViewResultZYA.Location = new Point(12, 42);
            dataGridViewResultZYA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResultZYA.Name = "dataGridViewResultZYA";
            dataGridViewResultZYA.ReadOnly = true;
            dataGridViewResultZYA.RowHeadersVisible = false;
            dataGridViewResultZYA.Size = new Size(215, 235);
            dataGridViewResultZYA.TabIndex = 1;
            // 
            // labelResultZYA
            // 
            labelResultZYA.AutoSize = true;
            labelResultZYA.Location = new Point(8, 23);
            labelResultZYA.Margin = new Padding(4, 0, 4, 0);
            labelResultZYA.Name = "labelResultZYA";
            labelResultZYA.Size = new Size(63, 15);
            labelResultZYA.TabIndex = 0;
            labelResultZYA.Text = "Результат:";
            // 
            // buttonDoneZYA
            // 
            buttonDoneZYA.Location = new Point(807, 338);
            buttonDoneZYA.Margin = new Padding(4, 3, 4, 3);
            buttonDoneZYA.Name = "buttonDoneZYA";
            buttonDoneZYA.Size = new Size(112, 35);
            buttonDoneZYA.TabIndex = 2;
            buttonDoneZYA.Text = "Выполнить";
            buttonDoneZYA.UseVisualStyleBackColor = true;
            buttonDoneZYA.Click += buttonDoneZYA_Click;
            // 
            // buttonMessageZYA
            // 
            buttonMessageZYA.Location = new Point(750, 338);
            buttonMessageZYA.Margin = new Padding(4, 3, 4, 3);
            buttonMessageZYA.Name = "buttonMessageZYA";
            buttonMessageZYA.Size = new Size(36, 36);
            buttonMessageZYA.TabIndex = 3;
            buttonMessageZYA.Text = "?";
            buttonMessageZYA.UseVisualStyleBackColor = true;
            buttonMessageZYA.Click += buttonMessageZYA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 388);
            Controls.Add(buttonMessageZYA);
            Controls.Add(buttonDoneZYA);
            Controls.Add(groupBoxResultZYA);
            Controls.Add(groupBoxTaskZYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Жукова Я.А.";
            Load += FormMain_Load;
            groupBoxTaskZYA.ResumeLayout(false);
            groupBoxTaskZYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskZYA).EndInit();
            groupBoxResultZYA.ResumeLayout(false);
            groupBoxResultZYA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultZYA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskZYA;
        private System.Windows.Forms.DataGridView dataGridViewTaskZYA;
        private System.Windows.Forms.TextBox textBoxTaskZYA;
        private System.Windows.Forms.GroupBox groupBoxResultZYA;
        private System.Windows.Forms.Label labelResultZYA;
        private System.Windows.Forms.Button buttonDoneZYA;
        private System.Windows.Forms.Button buttonMessageZYA;
        private System.Windows.Forms.DataGridView dataGridViewResultZYA;
    }
}
