using Timer = System.Windows.Forms.Timer;

namespace _06_Child_Controls
{
    public partial class Form1 : Form
    {
        private Timer timer = new();
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private int count = 1;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Text = (++count).ToString();
        }

        private void StartBtnClick(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Text = counter++.ToString();
            } 
        }
    }
}