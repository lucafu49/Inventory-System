using SafeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeInventory.Services
{
    internal class SupplierService
    {
        private SafeInventoryEntities db;

        public SupplierService()
        {
            db = new SafeInventoryEntities();
        }

        public List<Supplier> GetSuppliers() 
        {
            try
            {
                return db.Supplier.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los proveedores: " + ex.Message);
                return new List<Supplier>();
            }
        }

        public List<dynamic> getGridSupplier()
        {
            var suppliers = db.Supplier.Select(p => new
            {
                p.IDSupplier,
                p.Name,
                p.Phone
            }).ToList<dynamic>();

            return suppliers;
        }

        public void addSupplier(Supplier supplier)
        {
            try
            {
                db.Supplier.Add(supplier);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el proveedor: " + ex.Message);
            }
        }
        public void addProductXSupplier(ProductXSupplier pxs) 
        {
            try
            {
                db.ProductXSupplier.Add(pxs);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el proveedor: " + ex.Message);
            }
        }
        public Supplier createSupplier(string supplierName, string phone) 
        {
            Supplier var = new Supplier 
            {
                Name = supplierName,
                Phone = phone
            };
            return var;
        }
        public bool removeSupplier(int id) 
        {
            try
            {
                var searchSupplier = db.Supplier.Find(id);

                if (searchSupplier != null) 
                {
                    db.Supplier.Remove(searchSupplier);
                    db.SaveChanges();
                    return true;
                }
                else 
                {
                    Console.WriteLine("Proveedor no encontrado.");
                    return false;
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el proveedor: " + ex.Message);
                return false;
            }
        }
        public bool updateSupplier(int id, string name, string phone)
        {
            try
            {
                var searchSupplier = db.Supplier.Find(id);

                if (searchSupplier != null) 
                {
                    searchSupplier.Name = name;
                    searchSupplier.Phone = phone;
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    Console.WriteLine("Proveedor no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el proveedor: " + ex.Message);
                return false;
            }
        }

        public List<string> getSupplierByIDProduct(int idProduct)
        {

        }
    }
}
