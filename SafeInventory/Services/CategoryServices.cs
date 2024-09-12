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

        public List<dynamic> GetAllCategoriesGridView() 
        {
            var categories = db.Category.Select(p => new 
                {
                    p.IDCategory,
                    p.Name
                }).ToList<dynamic>();

            return categories;
        }

        public int? GetCategoryIdByName(string categoryName)
        {
            try
            {
                var category = db.Category.FirstOrDefault(c => c.Name == categoryName);
                return category?.IDCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la categoría: " + ex.Message);
                return null;
            }
        }

        public Category createCategory(string name)
        {
            Category category = new Category()
            {
                Name = name
            };
            return category;
        }

        //INSERT
        public void addCategory(Category category)
        {
            try
            {
                db.Category.Add(category);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la categoria: " + ex.Message);
            }
        }

        //DELETE
        public bool removeCategory(int IDCategory) 
        {
            try
            {
                var category = db.Category.Find(IDCategory);

                if (category != null)
                {
                    db.Category.Remove(category);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("Categoria no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la Categoria: " + ex.Message);
                return false;
            }
        }

        //UPDATE
        public bool updateCategory(Category category)
        {
            try
            {
                var existingCat = db.Category.Find(category.IDCategory);

                if (existingCat == null)
                {
                    Console.WriteLine("Categoria no encontrada.");
                    return false;
                }

                existingCat.Name = category.Name;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la categoria: " + ex.Message);
                return false;
            }
        }

    }
}
