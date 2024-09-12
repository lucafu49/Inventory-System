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
    public partial class GridSupplier : Form
    {
        private SupplierService s;

        public GridSupplier()
        {
            InitializeComponent();
            s = new SupplierService();
        }

        private void GridSupplier_Load(object sender, EventArgs e)
        {
            getGridSupplier();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear un proveedor.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var supplier = s.createSupplier(txt_name.Text, txt_phone.Text);
                s.addSupplier(supplier);
                MessageBox.Show("Se registro con exito la categoria");
                getGridSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el proveedor: " + ex.Message);
            }
        }


        public void getGridSupplier()
        {
            try
            {
                var supplierGrid = s.getGridSupplier();

                gv_suplier.DataSource = supplierGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las categorias: " + ex.Message);
            }
        }

        private void gv_suplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idSupplier.Text = gv_suplier.SelectedCells[0].Value.ToString();
            txt_name.Text = gv_suplier.SelectedCells[1].Value.ToString();
            txt_phone.Text = gv_suplier.SelectedCells[2].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idSupplier.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de eliminar un proveedor.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool wasDeleted = s.removeSupplier(Int32.Parse(txt_idSupplier.Text));

                if (wasDeleted)
                {
                    MessageBox.Show("Proveedor eliminado con exito!");
                    getGridSupplier();
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada. Verifica el ID e inténtalo de nuevo.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el proveedor: " + ex.Message);
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idSupplier.Text) ||
                string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de eliminar un proveedor.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool wasUpdated = s.updateSupplier(Int32.Parse(txt_idSupplier.Text), txt_name.Text, txt_phone.Text);

                if (wasUpdated)
                {
                    MessageBox.Show("Proveedor actualizado con exito!");
                    getGridSupplier();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado. Verifica el ID e inténtalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el producto: " + ex.Message);
            }
        }
    }
}
