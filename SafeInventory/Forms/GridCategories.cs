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
    public partial class GridCategories : Form
    {
        private CategoryServices cs;

        public GridCategories()
        {
            InitializeComponent();
            cs = new CategoryServices();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idCategory.Text = gv_categories.SelectedCells[0].Value.ToString();
            txt_name.Text = gv_categories.SelectedCells[1].Value.ToString();
        }

        private void getDataGridView()
        {
            try
            {
                var categoryList = cs.GetAllCategoriesGridView();

                gv_categories.DataSource = categoryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las categorias: " + ex.Message);
            }
        }

        private void GridCategories_Load(object sender, EventArgs e)
        {
           getDataGridView();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                var category = cs.createCategory(txt_name.Text);
                cs.addCategory(category);
                getDataGridView();
                MessageBox.Show("Se registro con exito la categoria");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la categoria: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_name.Text)||
                string.IsNullOrWhiteSpace(txt_idCategory.Text))
            {
                MessageBox.Show("Hace falta completar todos los campos para borrar una Categoria.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idCategory = Int32.Parse(txt_idCategory.Text);

                bool wasDeleted = cs.removeCategory(idCategory);

                if (wasDeleted) 
                {
                    MessageBox.Show("Categoria borrada con exito!");
                    getDataGridView();
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada. Verifica el ID e inténtalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la categoria: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_idCategory.Text))
            {
                MessageBox.Show("Hace falta completar todos los campos para editar una Categoria.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                Category updateCat = new Category
                {
                    IDCategory = Int32.Parse(txt_idCategory.Text),
                    Name = txt_name.Text
                };

                bool wasUpdated = cs.updateCategory(updateCat);

                if (wasUpdated) 
                {
                    MessageBox.Show("Categoria editada con exito!");
                    getDataGridView();
                }
                else
                {
                    MessageBox.Show("Categoria no encontrada. Verifica el ID e inténtalo de nuevo.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el producto: " + ex.Message);
            }
        }
    }
}
