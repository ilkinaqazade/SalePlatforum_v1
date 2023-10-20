using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePlatforum
{
    public partial class Form1 : Form
    {
        public List<Product> productList { get; set; }
        UserControl1 product = new UserControl1();
        AddProduct addProduct = new AddProduct();
        public Form1()
        {
            InitializeComponent();
            colorRGB();
            productList = new List<Product>
            {
                new Product
                {
                    ProductName = "Iphone 15",
                    ProductPrice = 3500,
                    ProductDescirption = "Apple",
                    ProductImage = Properties.Resources.Iphone

                },
                new Product
                {
                    ProductName = "Samsung s20",
                    ProductPrice = 1500,
                    ProductDescirption = "Samsung",
                    ProductImage = Properties.Resources.Samsung
                },
                new Product
                {
                    ProductName = "Nokia 3310",
                    ProductPrice = 15,
                    ProductDescirption = "Nokia",
                    ProductImage = Properties.Resources.Nokia
                }
            };

            int x = 0;
            int y = 0;

            foreach (var item in productList)
            {
                var product = new UserControl1();
                product.productname = item.ProductName;
                product.productdiscirption = item.ProductDescirption;
                product.productprice = item.ProductPrice.ToString();
                product.productimage = item.ProductImage;

                product.Location = new Point(x, y);
                y += 100;
                this.panel1.Controls.Add(product);
            }
        }

        public void colorRGB()
        {
            pictureBox1.BackColor = Color.FromArgb(28, 29, 33);
            pictureBox2.BackColor = Color.FromArgb(229, 122, 68);
            updateBtr1.ForeColor = Color.FromArgb(229, 122, 68);
            addBtr.ForeColor = Color.FromArgb(229, 122, 68);
        }

        private void addBtr_Click(object sender, EventArgs e)
        {
            addProduct.ShowDialog();
        }
    }

    public class Product
    {
        public string ProductName;
        public int ProductPrice;
        public string ProductDescirption;
        public Image ProductImage;
        public string ProductAddImage;

    }
}
