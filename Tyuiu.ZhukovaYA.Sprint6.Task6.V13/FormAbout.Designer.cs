namespace Tyuiu.ZhukovaYA.Sprint6.Task6.V13
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
            labelText_ZYA = new Label();
            buttonOk_ZYA = new Button();
            label_ZYA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZero_ZYA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxZero_ZYA
            // 
            pictureBoxZero_ZYA.Image = (Image)resources.GetObject("pictureBoxZero_ZYA.Image");
            pictureBoxZero_ZYA.Location = new Point(22, 67);
            pictureBoxZero_ZYA.Name = "pictureBoxZero_ZYA";
            pictureBoxZero_ZYA.Size = new Size(150, 113);
            pictureBoxZero_ZYA.TabIndex = 0;
            pictureBoxZero_ZYA.TabStop = false;
            // 
            // labelText_ZYA
            // 
            labelText_ZYA.AutoSize = true;
            labelText_ZYA.Location = new Point(188, 56);
            labelText_ZYA.Name = "labelText_ZYA";
            labelText_ZYA.Size = new Size(0, 15);
            labelText_ZYA.TabIndex = 1;
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
            // label_ZYA
            // 
            label_ZYA.AutoSize = true;
            label_ZYA.Location = new Point(178, 56);
            label_ZYA.Name = "label_ZYA";
            label_ZYA.Size = new Size(303, 135);
            label_ZYA.TabIndex = 3;
            label_ZYA.Text = resources.GetString("label_ZYA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 247);
            Controls.Add(label_ZYA);
            Controls.Add(buttonOk_ZYA);
            Controls.Add(labelText_ZYA);
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
        private Label labelText_ZYA;
        private Button buttonOk_ZYA;
        private Label label_ZYA;
    }
    }