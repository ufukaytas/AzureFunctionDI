using AzureFunctionDI.Model;
using System.Collections.Generic;

namespace AzureFunctionDI.Data
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
