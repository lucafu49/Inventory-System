using SafeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeInventory.Services
{
    internal class CategoryServices
    {
        private SafeInventoryEntities db;

        public CategoryServices() {
            db = new SafeInventoryEntities();
        }

        public List<Category> GetCategories() {
            try
            {
                return db.Category.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las categorías: " + ex.Message);
                return new List<Category>();
            }
        }

        public int? GetCategoryIdByName(string categoryName)
        {
            try
            {
                // Buscar la categoría por nombre y retornar el ID si existe
                var category = db.Category.FirstOrDefault(c => c.Name == categoryName);
                return category?.IDCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la categoría: " + ex.Message);
                return null; // Usar null si no se encuentra la categoría
            }
        }
    }
}
