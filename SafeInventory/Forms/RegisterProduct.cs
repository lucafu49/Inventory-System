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

namespace SafeInventory.Forms
{
    public partial class RegisterProduct : Form
    {
        ProductServices ps;
        CategoryServices cs;

        public RegisterProduct()
        {
            InitializeComponent();
            ps = new ProductServices();
            cs = new CategoryServices();
        }
        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = cs.GetCategories();

                cb_category.DataSource = categories;
                cb_category.DisplayMember = "Name";
                cb_category.ValueMember = "IDCategory";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                cb_category.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txt_price.Text) ||
                string.IsNullOrWhiteSpace(txt_stock.Text))
            {
                MessageBox.Show("Hace falta completar todos los campos para registrar un producto.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_stock.Text, out int stock) || stock <= 0)
            {
                MessageBox.Show("Por favor, introduce un valor válido para el stock.", "Error en stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Por favor, introduce un valor válido para el precio.", "Error en precio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_category.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId;
            try
            {
                
                categoryId = (int)cb_category.SelectedValue;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("La categoría seleccionada no es válida.", "Error de categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var product = ps.createProduct(txt_name.Text, categoryId, stock, price);

                if (product != null)
                {
                    ps.AddProduct(product);
                    MessageBox.Show("Producto agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message);
            }
        }

        private void RegisterProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            GridProducts gp = new GridProducts();
            gp.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
