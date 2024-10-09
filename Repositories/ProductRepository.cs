using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
namespace Repositories
{
   public  class ProductRepository : IProductRepository
    {
        public void  DeleteProduct(Product P)=> ProductDAO.DeleteProduct(P);
            public void SaveProduct(Product P)=>ProductDAO.ListProducts(P);
        public void UpdateProduct(Product P)=> ProductDAO.UpdateProduct(P);
        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public Product GetProductById(int id)=>ProductDAO.GetProductById(id);
    }
}
