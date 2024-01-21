namespace _01_message_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Some information...",                  // text
                    "Hello", MessageBoxButtons.YesNoCancel, // title
                    MessageBoxIcon.Question,                // buttons [Yes] [No] [Cancel]
                    MessageBoxDefaultButton.Button2);       // select [No} by default

            if (result == DialogResult.Yes)
                MessageBox.Show("Great!");
            else
                this.BackColor = Color.IndianRed;
        }

        private void MainBtn_MouseEnter(object sender, EventArgs e)
        {
            mainBtn.BackColor = Color.DarkSalmon;
        }

        private void MainBtn_MouseLeave(object sender, EventArgs e)
        {
            mainBtn.BackColor = SystemColors.Control;
        }
    }
}
