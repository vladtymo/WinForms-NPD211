﻿namespace _01_message_box
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
            label1 = new Label();
            mainBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(244, 148);
            label1.Name = "label1";
            label1.Size = new Size(640, 78);
            label1.TabIndex = 0;
            label1.Text = "Hello Windows Forms";
            // 
            // mainBtn
            // 
            mainBtn.Location = new Point(445, 343);
            mainBtn.Name = "mainBtn";
            mainBtn.Size = new Size(223, 88);
            mainBtn.TabIndex = 1;
            mainBtn.Text = "Push Me";
            mainBtn.UseVisualStyleBackColor = true;
            mainBtn.Click += MainBtn_Click;
            mainBtn.MouseEnter += MainBtn_MouseEnter;
            mainBtn.MouseLeave += MainBtn_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1115, 634);
            Controls.Add(mainBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button mainBtn;
    }
}
