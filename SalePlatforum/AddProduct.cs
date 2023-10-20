using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePlatforum
{
    public partial class AddProduct : Form
    {
        string imageLocation = "";
        Form1 form1 = new Form1();
        public AddProduct()
        {
            InitializeComponent();
        }

        public void addProdcutFunc()
        {
            form1.productList.Add(new Product
            {
                ProductName = productName.Text,
                ProductPrice = Convert.ToInt32(prictBox.Text),
                ProductDescirption = productDescirption.Text,
                ProductImage = imageLocation
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog1.FileName.ToString();
                }


            }
        }
    }
}
