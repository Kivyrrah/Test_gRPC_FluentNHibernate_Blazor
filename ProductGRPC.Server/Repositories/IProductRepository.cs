// ProductGRPC.Server/Repositories/IProductRepository.cs
using ProductGRPC.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductGRPC.Server.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
        Task<IList<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}