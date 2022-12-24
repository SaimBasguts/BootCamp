using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock= 15},
                new Product{CategoryId=2,ProductId=2,ProductName="kamera",UnitPrice=500,UnitsInStock= 3},
                new Product{CategoryId=2,ProductId=3,ProductName="telefon",UnitPrice=1500,UnitsInStock= 2},
                new Product{CategoryId=2,ProductId=4,ProductName="klavye",UnitPrice=150,UnitsInStock= 65},
                new Product{CategoryId=2,ProductId=5,ProductName="mouse",UnitPrice=85,UnitsInStock= 1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //linq
            Product productToDelete= productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(product);

            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}


            //firstordefault da olur first de olur

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        void IEntityRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Product> IEntityRepository<Product>.GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
