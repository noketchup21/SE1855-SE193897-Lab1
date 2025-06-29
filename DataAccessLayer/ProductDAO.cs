using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            try
            {
                using var db = new MyStoreContext();
                return db.Products.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving products: " + e.Message);
            }
        }

        public static void SaveProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();
                context.Products.Add(p);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error saving product: " + e.Message);
            }
        }

        public static void UpdateProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Error updating product: " + e.Message);
            }
        }

        public static void DeleteProduct(Product p)
        {
            try
            {
                using var context = new MyStoreContext();
                var productToDelete = context.Products.SingleOrDefault(c => c.ProductId == p.ProductId);
                if (productToDelete != null)
                {
                    context.Products.Remove(productToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting product: " + e.Message);
            }
        }

        public static Product GetProductById(int id)
        {
            try
            {
                using var db = new MyStoreContext();
                return db.Products.FirstOrDefault(c => c.ProductId == id);
            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving product by ID: " + e.Message);
            }
        }
    }
}
