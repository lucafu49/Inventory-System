using SafeInventory.Models;
using SafeInventory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProductServices ps = new ProductServices();
            List<Product> products = new List<Product>();
            products = ps.GetProducts();
            foreach (Product p in products)
            {
                MessageBox.Show(p.Name);
            }
        }
    }
}
