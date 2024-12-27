using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer.Entities;
using DomainLayer.Interfaces;
namespace ApplicationLayer.Services
{
    public class ProductsService : IProductsService
    {
        private readonly List<ProductsEntity> _products = new();

        public async Task<IEnumerable<ProductsEntity>> GetAllProductsAsync()
        {
            return await Task.FromResult(_products);
        }

        public async Task<ProductsEntity> GetProductByIdAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.ProductID == productId);
            return await Task.FromResult(product);
        }

        public async Task<ProductsEntity> AddProductAsync(ProductsEntity product)
        {
            _products.Add(product);
            return await Task.FromResult(product);
        }

        public async Task<ProductsEntity> UpdateProductAsync(int productId, ProductsEntity product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.ProductID == productId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.Dimensions = product.Dimensions;
            }
            return await Task.FromResult(existingProduct);
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                _products.Remove(product);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
