namespace _03_lists
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            cNameTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            productsCb = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Italy", "USA", "Spain", "Ukraine", "Poland", "France" });
            comboBox1.Location = new Point(277, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(483, 40);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 159);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 1;
            label1.Text = "Enter your country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(807, 162);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 10;
            label4.Text = "(suggest mode)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 240);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 13;
            label2.Text = "(append mode)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 237);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 12;
            label3.Text = "Enter your country:";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.Append;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Italy", "USA", "Spain", "Ukraine", "Poland", "France" });
            comboBox2.Location = new Point(277, 237);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(483, 40);
            comboBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 320);
            label5.Name = "label5";
            label5.Size = new Size(229, 32);
            label5.TabIndex = 14;
            label5.Text = "Enter country name:";
            // 
            // cNameTb
            // 
            cNameTb.Location = new Point(277, 320);
            cNameTb.Name = "cNameTb";
            cNameTb.Size = new Size(483, 39);
            cNameTb.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(807, 316);
            button1.Name = "button1";
            button1.Size = new Size(180, 46);
            button1.TabIndex = 16;
            button1.Text = "Add to List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddBtnClick;
            // 
            // button2
            // 
            button2.Location = new Point(277, 403);
            button2.Name = "button2";
            button2.Size = new Size(483, 64);
            button2.TabIndex = 17;
            button2.Text = "Show Selected";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShowSelectedClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 603);
            label6.Name = "label6";
            label6.Size = new Size(217, 32);
            label6.TabIndex = 19;
            label6.Text = "Enter your country:";
            // 
            // productsCb
            // 
            productsCb.AutoCompleteMode = AutoCompleteMode.Suggest;
            productsCb.AutoCompleteSource = AutoCompleteSource.ListItems;
            productsCb.DropDownStyle = ComboBoxStyle.DropDownList;
            productsCb.FormattingEnabled = true;
            productsCb.Items.AddRange(new object[] { "Italy", "USA", "Spain", "Ukraine", "Poland", "France" });
            productsCb.Location = new Point(277, 603);
            productsCb.Name = "productsCb";
            productsCb.Size = new Size(483, 40);
            productsCb.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(277, 707);
            button3.Name = "button3";
            button3.Size = new Size(483, 64);
            button3.TabIndex = 20;
            button3.Text = "Show Selected";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(277, 822);
            button4.Name = "button4";
            button4.Size = new Size(483, 64);
            button4.TabIndex = 21;
            button4.Text = "Remove Selected";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F);
            label7.Location = new Point(200, 37);
            label7.Name = "label7";
            label7.Size = new Size(673, 78);
            label7.TabIndex = 22;
            label7.Text = "ComboBox Data Binding";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 1011);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(productsCb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cNameTb);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox cNameTb;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox productsCb;
        private Button button3;
        private Button button4;
        private Label label7;
    }
}
