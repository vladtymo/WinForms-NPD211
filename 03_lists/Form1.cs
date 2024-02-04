using System.Collections.ObjectModel;

namespace _03_lists
{
    public partial class Form1 : Form
    {
        List<string> countries;
        List<Product> products;

        public Form1()
        {
            InitializeComponent();

            countries = new(new string[]
            {
                "Italy",
                "USA",
                "Spain",
                "Ukraine",
                "Poland",
                "France"
            });

            products = new()
            {
                new Product("iPhone X", 599, 5),
                new Product("Nike Trainee", 120, 10),
                new Product("Adidad Ball", 79, 0)
            };

            // initialize comboboxes with data
            // 1 - add manually
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(countries.ToArray());

            // 2 - using bindings
            UpdateComboBoxSource();
            productsCb.DataSource = products;
        }

        private void UpdateComboBoxSource()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = countries;
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            // add to combobox
            comboBox1.Items.Add(cNameTb.Text);

            // add to data list
            countries.Add(cNameTb.Text);

            cNameTb.Clear();

            // update binding source
            UpdateComboBoxSource();
        }

        private void ShowSelectedClick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (productsCb.SelectedIndex != -1)
            {
                var item = productsCb.SelectedItem as Product;
                MessageBox.Show($"{item.Price}$ - {item.Discount}%");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (productsCb.SelectedIndex != -1)
            {
                productsCb.Items.RemoveAt(productsCb.SelectedIndex);
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public Product(string n, decimal p, int d)
        {
            this.Name = n;
            this.Price = p;
            this.Discount = d;
        }

        public override string ToString()
        {
            return $"Product: {Name} - {Price}$";
        }
    }
}
