using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.Entities;

namespace DomainLayer.Interfaces
{
    
        public interface IProductService
        {
            Task<IEnumerable<ProductsEntity>> GetAllAsync();
            Task<ProductsEntity> GetByIdAsync(int id);
            Task AddAsync(ProductsEntity product);
            Task UpdateAsync(ProductsEntity product);
            Task DeleteAsync(int id);
        }
    }
