using DomainLayer.Entities;
using DomainLayer.InterFaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationLayer.DTOs;
using DomainLayer.Services;
using InfrustructureLayer.Repositories;
using DomainLayer.Interfaces;


namespace DomainLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productRepository;

        public ProductService(IProductService productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return products.Select(p => new ProductDTO
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Dimensions = p.Dimensions
            });
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product == null)
            {
                return null;
            }

            return new ProductDTO
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                Dimensions = product.Dimensions
            };
        }

        public async Task AddProductAsync(ProductDTO productDto)
        {
            var product = new ProductsEntity
            {
                ProductID = productDto.ProductID,
                ProductName = productDto.ProductName,
                Dimensions = productDto.Dimensions
            };

            await _productRepository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(ProductDTO productDto)
        {
            var product = await _productRepository.GetProductByIdAsync(productDto.ProductID);
            if (product != null)
            {
                product.ProductName = productDto.ProductName;
                product.Dimensions = productDto.Dimensions;
                await _productRepository.UpdateProductAsync(product);
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }
    }
}
}