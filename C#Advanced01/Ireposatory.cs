using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced01
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Delete(int id);
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
    public class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products = new();

        public void Add(Product entity) => _products.Add(entity);
        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
        public IEnumerable<Product> GetAll() => _products;
        public void Delete(int id) => _products.RemoveAll(p => p.Id == id);
    }
}
