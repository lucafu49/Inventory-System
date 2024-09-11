using SafeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeInventory.Services
{
    public class ProductServices
    {
        private SafeInventoryEntities db;
        
        public ProductServices() {
            db = new SafeInventoryEntities();
        }

        public List<Product> GetProducts() { 
            return db.Product.ToList();
        }

        public List<dynamic> GetAllProductsForGrid()
        {
            var products = db.Product.Select(p => new
            {
                p.IDProduct,
                p.Name,
                p.Price,
                p.Stock,
                CategoryName = p.Category.Name
            }).ToList<dynamic>();

            return products;
        }

        //INSERT
        public void AddProduct(Product product)
        {
            try
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Error al agregar el producto: " + ex.Message);
            }
        }

        //DELETE/
        public bool deleteProduct(int idProduct)
        {
            try
            {
                var product = db.Product.Find(idProduct);

                if (product != null)
                {
                    db.Product.Remove(product);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                return false;
            }
        }

        //UPDATE
        public bool updateProduct(Product product)
        {
            try
            {
                var existingProduct = db.Product.Find(product.IDProduct);

                if (existingProduct == null)
                {
                    Console.WriteLine("Producto no encontrado.");
                    return false;
                }

                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.IDCategory = product.IDCategory;
                existingProduct.Stock = product.Stock;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el producto: " + ex.Message);
                return false;
            }
        }

        public Product createProduct(string name, int categoryId, int stock, decimal price) {
            Product var = new Product()
            {
                Name = name,
                IDCategory = categoryId,
                Price = price,
                Stock = stock
            };
            return var;
        }
    }
}
