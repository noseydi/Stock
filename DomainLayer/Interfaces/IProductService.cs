using DomainLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductsEntity>> GetAllProductsAsync();
        Task<ProductsEntity> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductsEntity product);
        Task UpdateProductAsync(ProductsEntity product);
        Task DeleteProductAsync(int id);
    }
}