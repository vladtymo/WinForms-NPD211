namespace _04_listbox
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
            button2 = new Button();
            colorTxtBox = new TextBox();
            label8 = new Label();
            button3 = new Button();
            label2 = new Label();
            colorList = new ListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(59, 889);
            button2.Name = "button2";
            button2.Size = new Size(803, 61);
            button2.TabIndex = 27;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // colorTxtBox
            // 
            colorTxtBox.Location = new Point(148, 781);
            colorTxtBox.Name = "colorTxtBox";
            colorTxtBox.Size = new Size(440, 39);
            colorTxtBox.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 781);
            label8.Name = "label8";
            label8.Size = new Size(76, 32);
            label8.TabIndex = 25;
            label8.Text = "Color:";
            // 
            // button3
            // 
            button3.Location = new Point(606, 770);
            button3.Name = "button3";
            button3.Size = new Size(246, 61);
            button3.TabIndex = 24;
            button3.Text = "Add New";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(356, 39);
            label2.Name = "label2";
            label2.Size = new Size(232, 78);
            label2.TabIndex = 23;
            label2.Text = "List Box";
            // 
            // colorList
            // 
            colorList.FormattingEnabled = true;
            colorList.Items.AddRange(new object[] { "Brown", "Grey", "Green", "Yellow", "Cyan", "Magenta", "Pink", "Red", "Black" });
            colorList.Location = new Point(59, 148);
            colorList.Name = "colorList";
            colorList.SelectionMode = SelectionMode.MultiExtended;
            colorList.Size = new Size(803, 548);
            colorList.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 1016);
            Controls.Add(button2);
            Controls.Add(colorTxtBox);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(colorList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox colorTxtBox;
        private Label label8;
        private Button button3;
        private Label label2;
        private ListBox colorList;
    }
}
