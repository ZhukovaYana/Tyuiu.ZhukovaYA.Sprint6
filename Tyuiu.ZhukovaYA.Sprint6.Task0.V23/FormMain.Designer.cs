namespace Tyuiu.ZhukovaYA.Sprint6.Task0.V23
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
            labelCondition_ZYA = new Label();
            labelConditionText_ZYA = new Label();
            pictureBoxCondition_ZYA = new PictureBox();
            labelDataInput_ZYA = new Label();
            textBoxDataInput_ZYA = new TextBox();
            textBoxDataOutput_ZYA = new TextBox();
            labelDataOutput_ZYA = new Label();
            buttonResult_ZYA = new Button();
            buttonhelp_ZYA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_ZYA).BeginInit();
            SuspendLayout();
            // 
            // labelCondition_ZYA
            // 
            labelCondition_ZYA.AutoSize = true;
            labelCondition_ZYA.Location = new Point(12, 9);
            labelCondition_ZYA.Name = "labelCondition_ZYA";
            labelCondition_ZYA.Size = new Size(53, 15);
            labelCondition_ZYA.TabIndex = 0;
            labelCondition_ZYA.Text = "Условие";
            // 
            // labelConditionText_ZYA
            // 
            labelConditionText_ZYA.AutoSize = true;
            labelConditionText_ZYA.Location = new Point(12, 24);
            labelConditionText_ZYA.Name = "labelConditionText_ZYA";
            labelConditionText_ZYA.Size = new Size(477, 53);
            labelConditionText_ZYA.TabIndex = 1;
            labelConditionText_ZYA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. \r\nОкруглить до трёх знаков после запятой. \r\nГрафический интерфейс оформить по шаблону из лекции.";
            labelConditionText_ZYA.UseCompatibleTextRendering = true;
            // 
            // pictureBoxCondition_ZYA
            // 
            pictureBoxCondition_ZYA.Image = Properties.Resources.Untitled;
            pictureBoxCondition_ZYA.Location = new Point(346, 51);
            pictureBoxCondition_ZYA.Name = "pictureBoxCondition_ZYA";
            pictureBoxCondition_ZYA.Size = new Size(123, 57);
            pictureBoxCondition_ZYA.TabIndex = 2;
            pictureBoxCondition_ZYA.TabStop = false;
            // 
            // labelDataInput_ZYA
            // 
            labelDataInput_ZYA.Location = new Point(21, 94);
            labelDataInput_ZYA.Name = "labelDataInput_ZYA";
            labelDataInput_ZYA.Size = new Size(100, 33);
            labelDataInput_ZYA.TabIndex = 3;
            labelDataInput_ZYA.Text = "Ввод данных\r\nПеременная X";
            // 
            // textBoxDataInput_ZYA
            // 
            textBoxDataInput_ZYA.Location = new Point(21, 130);
            textBoxDataInput_ZYA.Name = "textBoxDataInput_ZYA";
            textBoxDataInput_ZYA.Size = new Size(100, 23);
            textBoxDataInput_ZYA.TabIndex = 4;
            textBoxDataInput_ZYA.KeyPress += textBoxDataInput_ZYA_KeyPress;
            // 
            // textBoxDataOutput_ZYA
            // 
            textBoxDataOutput_ZYA.Location = new Point(127, 130);
            textBoxDataOutput_ZYA.Name = "textBoxDataOutput_ZYA";
            textBoxDataOutput_ZYA.Size = new Size(100, 23);
            textBoxDataOutput_ZYA.TabIndex = 6;
            // 
            // labelDataOutput_ZYA
            // 
            labelDataOutput_ZYA.Location = new Point(127, 94);
            labelDataOutput_ZYA.Name = "labelDataOutput_ZYA";
            labelDataOutput_ZYA.Size = new Size(100, 33);
            labelDataOutput_ZYA.TabIndex = 5;
            labelDataOutput_ZYA.Text = "Вывод данных\r\nРезультат:";
            // 
            // buttonResult_ZYA
            // 
            buttonResult_ZYA.Location = new Point(336, 130);
            buttonResult_ZYA.Name = "buttonResult_ZYA";
            buttonResult_ZYA.Size = new Size(133, 23);
            buttonResult_ZYA.TabIndex = 7;
            buttonResult_ZYA.Text = "Выполнить";
            buttonResult_ZYA.UseVisualStyleBackColor = true;
            buttonResult_ZYA.Click += buttonResult_ZYA_Click;
            // 
            // buttonhelp_ZYA
            // 
            buttonhelp_ZYA.FlatStyle = FlatStyle.Flat;
            buttonhelp_ZYA.Location = new Point(304, 130);
            buttonhelp_ZYA.Name = "buttonhelp_ZYA";
            buttonhelp_ZYA.Size = new Size(26, 23);
            buttonhelp_ZYA.TabIndex = 8;
            buttonhelp_ZYA.Text = "?";
            buttonhelp_ZYA.UseVisualStyleBackColor = true;
            buttonhelp_ZYA.Click += buttonhelp_ZYA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 169);
            Controls.Add(buttonhelp_ZYA);
            Controls.Add(buttonResult_ZYA);
            Controls.Add(textBoxDataOutput_ZYA);
            Controls.Add(labelDataOutput_ZYA);
            Controls.Add(textBoxDataInput_ZYA);
            Controls.Add(labelDataInput_ZYA);
            Controls.Add(pictureBoxCondition_ZYA);
            Controls.Add(labelConditionText_ZYA);
            Controls.Add(labelCondition_ZYA);
            Name = "FormMain";
            Text = "Task0V23";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_ZYA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_ZYA;
        private Label labelConditionText_ZYA;
        private PictureBox pictureBoxCondition_ZYA;
        private Label labelDataInput_ZYA;
        private TextBox textBoxDataInput_ZYA;
        private TextBox textBoxDataOutput_ZYA;
        private Label labelDataOutput_ZYA;
        private Button buttonResult_ZYA;
        private Button buttonhelp_ZYA;
    }
}
