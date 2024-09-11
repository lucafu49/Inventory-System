using SafeInventory.Models;
using SafeInventory.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeInventory.Forms
{
    public partial class GridProducts : Form
    {
        private ProductServices ps;
        private CategoryServices cs;

        public GridProducts()
        {
            InitializeComponent();
            ps = new ProductServices();
            cs = new CategoryServices();
        }
        private void GridProducts_Load(object sender, EventArgs e)
        {
            FillProductGrid();
        }
        private void FillProductGrid()
        {
            var productList = ps.GetAllProductsForGrid();

            dv_product.DataSource = productList;
        }

        //CREAR PRODUCTO
        private void btn_create_Click(object sender, EventArgs e)
        {
            RegisterProduct rp = new RegisterProduct();
            rp.Show();
            this.Close();
        }

        //BORRAR PRODUCTO
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idProduct.Text))
            {
                MessageBox.Show("Hace falta completar todos los campos para registrar un producto.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idProduct = Int32.Parse(txt_idProduct.Text);

                bool wasDeleted = ps.deleteProduct(idProduct);

                if (wasDeleted)
                {
                    MessageBox.Show("Producto borrado con éxito");
                    FillProductGrid();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado. Verifica el ID e inténtalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message);
            }
        }

        private void dv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idProduct.Text= dv_product.SelectedCells[0].Value.ToString();
            txt_name.Text = dv_product.SelectedCells[1].Value.ToString();
            txt_price.Text = dv_product.SelectedCells[2].Value.ToString();
            txt_stock.Text = dv_product.SelectedCells[3].Value.ToString();
            txt_idCategory.Text = dv_product.SelectedCells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idProduct.Text) ||
                string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_price.Text) ||
                string.IsNullOrWhiteSpace(txt_stock.Text) ||
                string.IsNullOrWhiteSpace(txt_idCategory.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de actualizar el producto.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        try { 
                int idProduct = Int32.Parse(txt_idProduct.Text);

                var categoryId = cs.GetCategoryIdByName(txt_idCategory.Text);
                if (categoryId == null)
                {
                    MessageBox.Show("Categoría no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price = Decimal.Parse(txt_price.Text);
                int stock = Int32.Parse(txt_stock.Text);

                //NO USAMOS EL METODO DE PRODUCTSERVICE YA QUE NECESITAMOS EL ID DEL PRODUCTO
                Product updatedProduct = new Product
                {
                    IDProduct = idProduct,
                    Name = txt_name.Text,
                    IDCategory = categoryId.Value,
                    Price = price,
                    Stock = stock
                };

                bool wasUpdated = ps.updateProduct(updatedProduct);

                if (wasUpdated)
                {
                    MessageBox.Show("Producto actualizado con éxito.");
                    FillProductGrid();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocurrió un error al actualizar el producto: " + ex.Message);
        }

        }
    }
}
