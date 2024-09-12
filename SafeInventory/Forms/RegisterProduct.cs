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

namespace SafeInventory.Forms
{
    public partial class RegisterProduct : Form
    {
        ProductServices ps;
        CategoryServices cs;
        SupplierService s;

        public RegisterProduct()
        {
            InitializeComponent();
            ps = new ProductServices();
            cs = new CategoryServices();
            s = new SupplierService();
        }
        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            try
            {
                var supplier = s.GetSuppliers();
                var categories = cs.GetCategories();

                cb_category.DataSource = categories;
                cb_category.DisplayMember = "Name";
                cb_category.ValueMember = "IDCategory";

                chb_suppliers.DataSource= supplier;
                chb_suppliers.DisplayMember = "Name";
                chb_suppliers.ValueMember = "IDSupplier";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SaveProductWithSuppliers(product);
                    MessageBox.Show("Producto agregado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message);
            }
        }

        private void SaveProductWithSuppliers(Product product)
        {
            try
            {
                foreach (var item in chb_suppliers.CheckedItems)
                {
                    var supplier = (Supplier)item; // Asumiendo que el CheckedListBox usa objetos de tipo Proveedor
                    ProductXSupplier pxt = new ProductXSupplier
                    {
                        IDProduct = product.IDProduct,
                        IDSupplier = supplier.IDSupplier
                    };

                    // Registrar en la tabla ProductoxProveedor
                    s.addProductXSupplier(pxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asociar el producto con los proveedores: " + ex.Message);
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
