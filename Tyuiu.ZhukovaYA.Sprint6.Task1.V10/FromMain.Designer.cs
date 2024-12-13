namespace Tyuiu.ZhukovaYA.Sprint6.Task1.V10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxTaskZYA = new GroupBox();
            pictureBoxTaskZYA = new PictureBox();
            groupBoxResultZYA = new GroupBox();
            textBoxResultZYA = new TextBox();
            labelResultZYA = new Label();
            buttonResultZYA = new Button();
            groupBoxIntDataZYA = new GroupBox();
            textBoxStopValueZYA = new TextBox();
            textBoxStartValueZYA = new TextBox();
            labelStopValueZYA = new Label();
            labelStartValueZYA = new Label();
            buttonMessageZYA = new Button();
            groupBoxTaskZYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskZYA).BeginInit();
            groupBoxResultZYA.SuspendLayout();
            groupBoxIntDataZYA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTaskZYA
            // 
            groupBoxTaskZYA.Controls.Add(pictureBoxTaskZYA);
            groupBoxTaskZYA.Location = new Point(14, 14);
            groupBoxTaskZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxTaskZYA.Name = "groupBoxTaskZYA";
            groupBoxTaskZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxTaskZYA.Size = new Size(664, 248);
            groupBoxTaskZYA.TabIndex = 0;
            groupBoxTaskZYA.TabStop = false;
            groupBoxTaskZYA.Text = "Условие";
            // 
            // pictureBoxTaskZYA
            // 
            pictureBoxTaskZYA.ErrorImage = (Image)resources.GetObject("pictureBoxTaskZYA.ErrorImage");
            pictureBoxTaskZYA.Image = Properties.Resources.Без_названия;
            pictureBoxTaskZYA.Location = new Point(7, 18);
            pictureBoxTaskZYA.Name = "pictureBoxTaskZYA";
            pictureBoxTaskZYA.Size = new Size(645, 214);
            pictureBoxTaskZYA.TabIndex = 0;
            pictureBoxTaskZYA.TabStop = false;
            // 
            // groupBoxResultZYA
            // 
            groupBoxResultZYA.Controls.Add(textBoxResultZYA);
            groupBoxResultZYA.Controls.Add(labelResultZYA);
            groupBoxResultZYA.Location = new Point(686, 14);
            groupBoxResultZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxResultZYA.Name = "groupBoxResultZYA";
            groupBoxResultZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxResultZYA.Size = new Size(233, 473);
            groupBoxResultZYA.TabIndex = 1;
            groupBoxResultZYA.TabStop = false;
            groupBoxResultZYA.Text = "Вывод данных";
            groupBoxResultZYA.Enter += groupBoxResultZYA_Enter;
            // 
            // textBoxResultZYA
            // 
            textBoxResultZYA.BackColor = SystemColors.Control;
            textBoxResultZYA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResultZYA.Location = new Point(7, 53);
            textBoxResultZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxResultZYA.Multiline = true;
            textBoxResultZYA.Name = "textBoxResultZYA";
            textBoxResultZYA.ReadOnly = true;
            textBoxResultZYA.ScrollBars = ScrollBars.Vertical;
            textBoxResultZYA.Size = new Size(219, 412);
            textBoxResultZYA.TabIndex = 1;
            // 
            // labelResultZYA
            // 
            labelResultZYA.AutoSize = true;
            labelResultZYA.Location = new Point(4, 18);
            labelResultZYA.Margin = new Padding(4, 0, 4, 0);
            labelResultZYA.Name = "labelResultZYA";
            labelResultZYA.Size = new Size(63, 15);
            labelResultZYA.TabIndex = 0;
            labelResultZYA.Text = "Результат:";
            // 
            // buttonResultZYA
            // 
            buttonResultZYA.BackColor = Color.FromArgb(192, 255, 192);
            buttonResultZYA.Location = new Point(581, 456);
            buttonResultZYA.Margin = new Padding(4, 3, 4, 3);
            buttonResultZYA.Name = "buttonResultZYA";
            buttonResultZYA.Size = new Size(85, 31);
            buttonResultZYA.TabIndex = 2;
            buttonResultZYA.Text = "Выполнить";
            buttonResultZYA.UseVisualStyleBackColor = false;
            buttonResultZYA.Click += buttonResultZYA_Click;
            // 
            // groupBoxIntDataZYA
            // 
            groupBoxIntDataZYA.Controls.Add(textBoxStopValueZYA);
            groupBoxIntDataZYA.Controls.Add(textBoxStartValueZYA);
            groupBoxIntDataZYA.Controls.Add(labelStopValueZYA);
            groupBoxIntDataZYA.Controls.Add(labelStartValueZYA);
            groupBoxIntDataZYA.Location = new Point(21, 268);
            groupBoxIntDataZYA.Margin = new Padding(4, 3, 4, 3);
            groupBoxIntDataZYA.Name = "groupBoxIntDataZYA";
            groupBoxIntDataZYA.Padding = new Padding(4, 3, 4, 3);
            groupBoxIntDataZYA.Size = new Size(314, 75);
            groupBoxIntDataZYA.TabIndex = 3;
            groupBoxIntDataZYA.TabStop = false;
            groupBoxIntDataZYA.Text = "Ввод данных";
            // 
            // textBoxStopValueZYA
            // 
            textBoxStopValueZYA.Location = new Point(175, 44);
            textBoxStopValueZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStopValueZYA.Name = "textBoxStopValueZYA";
            textBoxStopValueZYA.Size = new Size(100, 23);
            textBoxStopValueZYA.TabIndex = 3;
            // 
            // textBoxStartValueZYA
            // 
            textBoxStartValueZYA.Location = new Point(10, 44);
            textBoxStartValueZYA.Margin = new Padding(4, 3, 4, 3);
            textBoxStartValueZYA.Name = "textBoxStartValueZYA";
            textBoxStartValueZYA.Size = new Size(96, 23);
            textBoxStartValueZYA.TabIndex = 2;
            // 
            // labelStopValueZYA
            // 
            labelStopValueZYA.AutoSize = true;
            labelStopValueZYA.Location = new Point(172, 18);
            labelStopValueZYA.Margin = new Padding(4, 0, 4, 0);
            labelStopValueZYA.Name = "labelStopValueZYA";
            labelStopValueZYA.Size = new Size(75, 15);
            labelStopValueZYA.TabIndex = 1;
            labelStopValueZYA.Text = "Конец шага:";
            // 
            // labelStartValueZYA
            // 
            labelStartValueZYA.AutoSize = true;
            labelStartValueZYA.Location = new Point(7, 18);
            labelStartValueZYA.Margin = new Padding(4, 0, 4, 0);
            labelStartValueZYA.Name = "labelStartValueZYA";
            labelStartValueZYA.Size = new Size(72, 15);
            labelStartValueZYA.TabIndex = 0;
            labelStartValueZYA.Text = "Старт шага:";
            // 
            // buttonMessageZYA
            // 
            buttonMessageZYA.BackColor = Color.FromArgb(192, 255, 255);
            buttonMessageZYA.Location = new Point(539, 456);
            buttonMessageZYA.Margin = new Padding(4, 3, 4, 3);
            buttonMessageZYA.Name = "buttonMessageZYA";
            buttonMessageZYA.Size = new Size(34, 31);
            buttonMessageZYA.TabIndex = 4;
            buttonMessageZYA.Text = "?";
            buttonMessageZYA.UseVisualStyleBackColor = false;
            buttonMessageZYA.Click += buttonMessageZYA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 502);
            Controls.Add(buttonMessageZYA);
            Controls.Add(groupBoxIntDataZYA);
            Controls.Add(buttonResultZYA);
            Controls.Add(groupBoxResultZYA);
            Controls.Add(groupBoxTaskZYA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 10 | Жукова Я.А.";
            groupBoxTaskZYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskZYA).EndInit();
            groupBoxResultZYA.ResumeLayout(false);
            groupBoxResultZYA.PerformLayout();
            groupBoxIntDataZYA.ResumeLayout(false);
            groupBoxIntDataZYA.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTaskZYA;
        private System.Windows.Forms.GroupBox groupBoxResultZYA;
        private System.Windows.Forms.TextBox textBoxResultZYA;
        private System.Windows.Forms.Label labelResultZYA;
        private System.Windows.Forms.Button buttonResultZYA;
        private System.Windows.Forms.GroupBox groupBoxIntDataZYA;
        private System.Windows.Forms.Label labelStopValueZYA;
        private System.Windows.Forms.Label labelStartValueZYA;
        private System.Windows.Forms.TextBox textBoxStopValueZYA;
        private System.Windows.Forms.TextBox textBoxStartValueZYA;
        private System.Windows.Forms.Button buttonMessageZYA;
        #endregion

        private PictureBox pictureBoxTaskZYA;
    }
}
