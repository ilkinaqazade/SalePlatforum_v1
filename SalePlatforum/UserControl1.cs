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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public Image productimage
        {
            get { return productImageBox2.Image; }
            set { productImageBox2.Image = value; }
        }

        public string productname
        {
            get { return productNameLb.Text; }
            set { productNameLb.Text = value; }
        }

        public string productdiscirption
        {
            get { return desciriptionProductLb.Text; }
            set { desciriptionProductLb.Text = value; }
        }

        public string productprice
        {
            get { return productPriceLb.Text; }
            set { productPriceLb.Text = value; }
        }


    }
}
