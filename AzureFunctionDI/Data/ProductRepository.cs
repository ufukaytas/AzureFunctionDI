using AzureFunctionDI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunctionDI.Data
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product{Id = 1, Name = "Product 1", Price = 10},
                new Product{Id = 2, Name = "Product 2", Price = 15},
                new Product{Id = 3, Name = "Product 3", Price = 25},
                new Product{Id = 4, Name = "Product 4", Price = 20},
                new Product{Id = 5, Name = "Product 5", Price = 50},
            };

            
        }
    }
}
