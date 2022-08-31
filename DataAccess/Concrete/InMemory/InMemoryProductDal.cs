using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private readonly List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId=1, CategoryId=1, ProductName="Glass", UnitPrice=15, UnitsInStock=15 },
                new Product { ProductId=2, CategoryId=1, ProductName="Camera", UnitPrice=500, UnitsInStock=3 },
                new Product { ProductId=3, CategoryId=2, ProductName="Phone", UnitPrice=1500, UnitsInStock=2 },
                new Product { ProductId=4, CategoryId=2, ProductName="Keyboard", UnitPrice=150, UnitsInStock=65 },
                new Product { ProductId=5, CategoryId=2, ProductName="Mouse", UnitPrice=85, UnitsInStock=1 }
            };
        }

        public void Add(Product product) => _products.Add(product);

        public void Delete(Product product)
        {
            Product removedProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(removedProduct);
        }

        public List<Product> GetAll() => _products;

        public List<Product> GetAllByCategory(int categoryId) => _products.Where(p => p.CategoryId == categoryId).ToList();

        public void Update(Product product)
        {
            Product updatedProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.CategoryId = product.CategoryId;
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.UnitsInStock = product.UnitsInStock;
        }
    }
}
