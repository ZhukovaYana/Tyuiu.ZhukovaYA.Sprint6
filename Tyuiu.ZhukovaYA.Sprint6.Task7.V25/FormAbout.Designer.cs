namespace Tyuiu.ZhukovaYA.Sprint6.Task7.V25
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxZero_ZYA = new PictureBox();
            buttonOk_ZYA = new Button();
            labelText_ZYA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero_ZYA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxZero_ZYA
            // 
            pictureBoxZero_ZYA.Image = Properties.Resources._123;
            pictureBoxZero_ZYA.Location = new Point(22, 67);
            pictureBoxZero_ZYA.Name = "pictureBoxZero_ZYA";
            pictureBoxZero_ZYA.Size = new Size(150, 113);
            pictureBoxZero_ZYA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxZero_ZYA.TabIndex = 0;
            pictureBoxZero_ZYA.TabStop = false;
            // 
            // buttonOk_ZYA
            // 
            buttonOk_ZYA.Location = new Point(416, 212);
            buttonOk_ZYA.Name = "buttonOk_ZYA";
            buttonOk_ZYA.Size = new Size(75, 23);
            buttonOk_ZYA.TabIndex = 2;
            buttonOk_ZYA.Text = "Ok";
            buttonOk_ZYA.UseVisualStyleBackColor = true;
            buttonOk_ZYA.Click += buttonOk_ZYA_Click;
            // 
            // labelText_ZYA
            // 
            labelText_ZYA.AutoSize = true;
            labelText_ZYA.Location = new Point(188, 45);
            labelText_ZYA.Name = "labelText_ZYA";
            labelText_ZYA.Size = new Size(303, 135);
            labelText_ZYA.TabIndex = 3;
            labelText_ZYA.Text = resources.GetString("labelText_ZYA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 247);
            Controls.Add(labelText_ZYA);
            Controls.Add(buttonOk_ZYA);
            Controls.Add(pictureBoxZero_ZYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero_ZYA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxZero_ZYA;
        private Button buttonOk_ZYA;
        private Label labelText_ZYA;
    }
}