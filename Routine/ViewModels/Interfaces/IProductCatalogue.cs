﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Routine.Models;

namespace Routine.ViewModels.Interfaces
{
    public interface IProductCatalogue
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProduct(int id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
