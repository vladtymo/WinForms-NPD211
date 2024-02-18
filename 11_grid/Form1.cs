namespace _11_grid
{
    public partial class Form1 : Form
    {
        List<Order> orders;
        public Form1()
        {
            InitializeComponent();

            orders = new List<Order>()
            {
                new("Vlad"),
                new("Oleg"),
                new("Viktoria"),
                new("Andrii")
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orders;
        }
    }

    internal class Order
    {
        static int count = 1000;
        static Random random = new Random();

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Client { get; set; }

        
        public Order(string client)
        {
            this.Number = count++;
            Date = DateTime.Now;
            Total = random.Next(100, 100000);
            this.Client = client;
        }
    }
}
