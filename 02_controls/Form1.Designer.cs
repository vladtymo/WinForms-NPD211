namespace _02_controls
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
            nameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            codeTb = new TextBox();
            phoneTb = new MaskedTextBox();
            addressTb = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            sauceCb = new CheckBox();
            label7 = new Label();
            largeRb = new RadioButton();
            midRb = new RadioButton();
            smallRb = new RadioButton();
            label6 = new Label();
            pizzaCb = new ComboBox();
            label8 = new Label();
            datePk = new DateTimePicker();
            cancelBtn = new Button();
            confirmBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(271, 32);
            label1.Name = "label1";
            label1.Size = new Size(412, 86);
            label1.TabIndex = 1;
            label1.Text = "Order a Pizza";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(58, 185);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(831, 39);
            nameTb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 140);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 3;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 261);
            label3.Name = "label3";
            label3.Size = new Size(177, 32);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 261);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 6;
            label4.Text = "Code";
            // 
            // codeTb
            // 
            codeTb.Location = new Point(574, 306);
            codeTb.Name = "codeTb";
            codeTb.PasswordChar = '●';
            codeTb.Size = new Size(315, 39);
            codeTb.TabIndex = 7;
            // 
            // phoneTb
            // 
            phoneTb.Location = new Point(58, 306);
            phoneTb.Mask = "+380(00)000-00-00";
            phoneTb.Name = "phoneTb";
            phoneTb.Size = new Size(472, 39);
            phoneTb.TabIndex = 8;
            // 
            // addressTb
            // 
            addressTb.Location = new Point(58, 427);
            addressTb.Multiline = true;
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(831, 156);
            addressTb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 383);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(sauceCb);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(largeRb);
            groupBox1.Controls.Add(midRb);
            groupBox1.Controls.Add(smallRb);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pizzaCb);
            groupBox1.Location = new Point(58, 626);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 386);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(546, 310);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 313);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 18;
            label9.Text = "Quantity";
            // 
            // sauceCb
            // 
            sauceCb.AutoSize = true;
            sauceCb.Location = new Point(48, 309);
            sauceCb.Name = "sauceCb";
            sauceCb.Size = new Size(109, 36);
            sauceCb.TabIndex = 17;
            sauceCb.Text = "Sauce";
            sauceCb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 169);
            label7.Name = "label7";
            label7.Size = new Size(57, 32);
            label7.TabIndex = 16;
            label7.Text = "Size";
            // 
            // largeRb
            // 
            largeRb.AutoSize = true;
            largeRb.Location = new Point(683, 218);
            largeRb.Name = "largeRb";
            largeRb.Size = new Size(103, 36);
            largeRb.TabIndex = 15;
            largeRb.TabStop = true;
            largeRb.Text = "Large";
            largeRb.UseVisualStyleBackColor = true;
            // 
            // midRb
            // 
            midRb.AutoSize = true;
            midRb.Location = new Point(355, 218);
            midRb.Name = "midRb";
            midRb.Size = new Size(135, 36);
            midRb.TabIndex = 14;
            midRb.TabStop = true;
            midRb.Text = "Medium";
            midRb.UseVisualStyleBackColor = true;
            // 
            // smallRb
            // 
            smallRb.AutoSize = true;
            smallRb.Location = new Point(48, 218);
            smallRb.Name = "smallRb";
            smallRb.Size = new Size(103, 36);
            smallRb.TabIndex = 13;
            smallRb.TabStop = true;
            smallRb.Text = "Small";
            smallRb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 44);
            label6.Name = "label6";
            label6.Size = new Size(60, 32);
            label6.TabIndex = 12;
            label6.Text = "Title";
            // 
            // pizzaCb
            // 
            pizzaCb.AutoCompleteMode = AutoCompleteMode.Suggest;
            pizzaCb.AutoCompleteSource = AutoCompleteSource.ListItems;
            pizzaCb.DropDownStyle = ComboBoxStyle.DropDownList;
            pizzaCb.FormattingEnabled = true;
            pizzaCb.Items.AddRange(new object[] { "Margarita", "4 Cheeses", "Paperoni", "Salami", "Super Mix", "Ukrainian Pizza" });
            pizzaCb.Location = new Point(48, 93);
            pizzaCb.Name = "pizzaCb";
            pizzaCb.Size = new Size(738, 40);
            pizzaCb.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 1047);
            label8.Name = "label8";
            label8.Size = new Size(266, 32);
            label8.TabIndex = 12;
            label8.Text = "Preferred Delivery Time";
            // 
            // datePk
            // 
            datePk.Location = new Point(359, 1047);
            datePk.MinDate = new DateTime(2024, 1, 28, 0, 0, 0, 0);
            datePk.Name = "datePk";
            datePk.Size = new Size(530, 39);
            datePk.TabIndex = 13;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.RosyBrown;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(58, 1129);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(369, 59);
            cancelBtn.TabIndex = 14;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.MediumSeaGreen;
            confirmBtn.DialogResult = DialogResult.OK;
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(520, 1129);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(369, 59);
            confirmBtn.TabIndex = 15;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += ConfirmBtnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 1230);
            Controls.Add(confirmBtn);
            Controls.Add(cancelBtn);
            Controls.Add(datePk);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(addressTb);
            Controls.Add(phoneTb);
            Controls.Add(codeTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox nameTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox codeTb;
        private MaskedTextBox phoneTb;
        private TextBox addressTb;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox pizzaCb;
        private Label label7;
        private RadioButton largeRb;
        private RadioButton midRb;
        private RadioButton smallRb;
        private Label label6;
        private CheckBox sauceCb;
        private Label label8;
        private DateTimePicker datePk;
        private Button cancelBtn;
        private Button confirmBtn;
        private NumericUpDown numericUpDown1;
        private Label label9;
    }
}
