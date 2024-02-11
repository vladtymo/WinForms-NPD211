namespace _05_Controls_Indicators
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
            mainTextBox = new TextBox();
            maxLenNumeric = new NumericUpDown();
            label1 = new Label();
            fontSizeSlider = new TrackBar();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lenLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            linesLabel = new ToolStripStatusLabel();
            label2 = new Label();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            menuItem1ToolStripMenuItem = new ToolStripMenuItem();
            menuItem2ToolStripMenuItem = new ToolStripMenuItem();
            item1ToolStripMenuItem = new ToolStripMenuItem();
            item2ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)maxLenNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeSlider).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mainTextBox.Location = new Point(12, 188);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(1435, 578);
            mainTextBox.TabIndex = 0;
            mainTextBox.TextChanged += MainTextChanged;
            // 
            // maxLenNumeric
            // 
            maxLenNumeric.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            maxLenNumeric.Location = new Point(17, 38);
            maxLenNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            maxLenNumeric.Name = "maxLenNumeric";
            maxLenNumeric.Size = new Size(278, 39);
            maxLenNumeric.TabIndex = 1;
            maxLenNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            maxLenNumeric.ValueChanged += MaxLenNumericChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 2;
            // 
            // fontSizeSlider
            // 
            fontSizeSlider.Location = new Point(6, 51);
            fontSizeSlider.Maximum = 120;
            fontSizeSlider.Minimum = 1;
            fontSizeSlider.Name = "fontSizeSlider";
            fontSizeSlider.Size = new Size(388, 90);
            fontSizeSlider.TabIndex = 3;
            fontSizeSlider.TickFrequency = 10;
            fontSizeSlider.TickStyle = TickStyle.TopLeft;
            fontSizeSlider.Value = 11;
            fontSizeSlider.ValueChanged += FontSizeSliderChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(17, 88);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(370, 46);
            progressBar1.TabIndex = 4;
            progressBar1.Value = 35;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fontSizeSlider);
            groupBox1.Location = new Point(16, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 149);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maxLenNumeric);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(1047, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 149);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lenght";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lenLabel, toolStripStatusLabel2, linesLabel, toolStripProgressBar1, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 764);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1459, 42);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(108, 32);
            toolStripStatusLabel1.Text = "Symbols:";
            // 
            // lenLabel
            // 
            lenLabel.Name = "lenLabel";
            lenLabel.Size = new Size(27, 32);
            lenLabel.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(86, 32);
            toolStripStatusLabel2.Text = "| Lines:";
            // 
            // linesLabel
            // 
            linesLabel.Name = "linesLabel";
            linesLabel.Size = new Size(27, 32);
            linesLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(602, 57);
            label2.Name = "label2";
            label2.Size = new Size(280, 72);
            label2.TabIndex = 9;
            label2.Text = "Text Editor";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 30);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItem2ToolStripMenuItem, menuItem1ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(54, 38);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { item2ToolStripMenuItem, item1ToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(59, 38);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // menuItem1ToolStripMenuItem
            // 
            menuItem1ToolStripMenuItem.Name = "menuItem1ToolStripMenuItem";
            menuItem1ToolStripMenuItem.Size = new Size(359, 44);
            menuItem1ToolStripMenuItem.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem
            // 
            menuItem2ToolStripMenuItem.Name = "menuItem2ToolStripMenuItem";
            menuItem2ToolStripMenuItem.Size = new Size(359, 44);
            menuItem2ToolStripMenuItem.Text = "Menu Item 2";
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.Size = new Size(359, 44);
            item1ToolStripMenuItem.Text = "Item 1";
            // 
            // item2ToolStripMenuItem
            // 
            item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            item2ToolStripMenuItem.Size = new Size(359, 44);
            item2ToolStripMenuItem.Text = "Item 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 806);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(mainTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)maxLenNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeSlider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainTextBox;
        private NumericUpDown maxLenNumeric;
        private Label label1;
        private TrackBar fontSizeSlider;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lenLabel;
        private Label label2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel linesLabel;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItem2ToolStripMenuItem;
        private ToolStripMenuItem menuItem1ToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem item2ToolStripMenuItem;
        private ToolStripMenuItem item1ToolStripMenuItem;
    }
}