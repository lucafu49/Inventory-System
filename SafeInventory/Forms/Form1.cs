using SafeInventory.Forms;
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
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            GridProducts g = new GridProducts();
            g.Show();
        }
    }
}
