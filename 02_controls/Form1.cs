namespace _02_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmBtnClick(object sender, EventArgs e)
        {
            var order = new Order()
            {
                ClientName = nameTb.Text,
                Phone = phoneTb.Text,
                IsSauce = sauceCb.Checked,
                Pizza = pizzaCb.SelectedItem?.ToString() ?? "not selected",
                PreferredTime = datePk.Value
            };

            if (smallRb.Checked ) order.Size = PizzaSize.Small;
            else if (midRb.Checked) order.Size = PizzaSize.Medium;
            else if (largeRb.Checked) order.Size = PizzaSize.Large;

            MessageBox.Show(order.ToString());
        }
    }

    public enum PizzaSize { Small, Medium, Large }
    public class Order
    {
        public int Number { get; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public bool IsSauce { get; set; }
        public PizzaSize Size { get; set; }
        public string Pizza { get; set; }
        public DateTime PreferredTime { get; set; }

        private static int count = 1000;
        public Order()
        {
            this.Number = count++;
        }

        public override string ToString()
        {
            return $"Order #{Number}: {Pizza} {Size}";
        }
    }
}
