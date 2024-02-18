namespace _10_rich_text
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            leftToolStripMenuItem1 = new ToolStripMenuItem();
            centerToolStripMenuItem1 = new ToolStripMenuItem();
            rightToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusTimer = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            element2ToolStripMenuItem = new ToolStripMenuItem();
            element1ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            element2ToolStripMenuItem1 = new ToolStripMenuItem();
            element1ToolStripMenuItem1 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            setDarkToolStripMenuItem = new ToolStripMenuItem();
            setWhiteToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new Point(12, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1798, 829);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripDropDownButton1, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1822, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(177, 36);
            toolStripButton1.Text = "Background";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(107, 36);
            toolStripButton2.Text = "Color";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(111, 36);
            toolStripButton3.Text = "Bullet";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { leftToolStripMenuItem1, centerToolStripMenuItem1, rightToolStripMenuItem1 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(179, 36);
            toolStripDropDownButton1.Text = "Alignment";
            // 
            // leftToolStripMenuItem1
            // 
            leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            leftToolStripMenuItem1.Size = new Size(218, 44);
            leftToolStripMenuItem1.Text = "Left";
            leftToolStripMenuItem1.Click += leftToolStripMenuItem_Click;
            // 
            // centerToolStripMenuItem1
            // 
            centerToolStripMenuItem1.Name = "centerToolStripMenuItem1";
            centerToolStripMenuItem1.Size = new Size(218, 44);
            centerToolStripMenuItem1.Text = "Center";
            centerToolStripMenuItem1.Click += centerToolStripMenuItem_Click;
            // 
            // rightToolStripMenuItem1
            // 
            rightToolStripMenuItem1.Name = "rightToolStripMenuItem1";
            rightToolStripMenuItem1.Size = new Size(218, 44);
            rightToolStripMenuItem1.Text = "Right";
            rightToolStripMenuItem1.Click += rightToolStripMenuItem_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(98, 36);
            toolStripButton4.Text = "Font";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(46, 36);
            toolStripButton5.Text = "Save";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(46, 36);
            toolStripButton6.Text = "Open";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusTimer, toolStripProgressBar1, toolStripDropDownButton2, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 930);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1822, 42);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(80, 32);
            toolStripStatusLabel1.Text = "Timer:";
            // 
            // statusTimer
            // 
            statusTimer.Name = "statusTimer";
            statusTimer.Size = new Size(71, 32);
            statusTimer.Text = "00:00";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.MarqueeAnimationSpeed = 10;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(300, 30);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { element2ToolStripMenuItem, element1ToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(54, 38);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // element2ToolStripMenuItem
            // 
            element2ToolStripMenuItem.Name = "element2ToolStripMenuItem";
            element2ToolStripMenuItem.Size = new Size(254, 44);
            element2ToolStripMenuItem.Text = "Element 2";
            // 
            // element1ToolStripMenuItem
            // 
            element1ToolStripMenuItem.Name = "element1ToolStripMenuItem";
            element1ToolStripMenuItem.Size = new Size(254, 44);
            element1ToolStripMenuItem.Text = "Element 1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { element2ToolStripMenuItem1, element1ToolStripMenuItem1 });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(59, 38);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // element2ToolStripMenuItem1
            // 
            element2ToolStripMenuItem1.Name = "element2ToolStripMenuItem1";
            element2ToolStripMenuItem1.Size = new Size(254, 44);
            element2ToolStripMenuItem1.Text = "Element 2";
            // 
            // element1ToolStripMenuItem1
            // 
            element1ToolStripMenuItem1.Name = "element1ToolStripMenuItem1";
            element1ToolStripMenuItem1.Size = new Size(254, 44);
            element1ToolStripMenuItem1.Text = "Element 1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { setDarkToolStripMenuItem, setWhiteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(193, 80);
            // 
            // setDarkToolStripMenuItem
            // 
            setDarkToolStripMenuItem.Name = "setDarkToolStripMenuItem";
            setDarkToolStripMenuItem.Size = new Size(192, 38);
            setDarkToolStripMenuItem.Text = "Set Dark";
            setDarkToolStripMenuItem.Click += setDarkToolStripMenuItem_Click;
            // 
            // setWhiteToolStripMenuItem
            // 
            setWhiteToolStripMenuItem.Name = "setWhiteToolStripMenuItem";
            setWhiteToolStripMenuItem.Size = new Size(192, 38);
            setWhiteToolStripMenuItem.Text = "Set White";
            setWhiteToolStripMenuItem.Click += setWhiteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1822, 972);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Rich Text Editor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem leftToolStripMenuItem1;
        private ToolStripMenuItem centerToolStripMenuItem1;
        private ToolStripMenuItem rightToolStripMenuItem1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusTimer;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem element2ToolStripMenuItem;
        private ToolStripMenuItem element1ToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem element2ToolStripMenuItem1;
        private ToolStripMenuItem element1ToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem setDarkToolStripMenuItem;
        private ToolStripMenuItem setWhiteToolStripMenuItem;
    }
}