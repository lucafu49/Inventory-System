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
    }
}
