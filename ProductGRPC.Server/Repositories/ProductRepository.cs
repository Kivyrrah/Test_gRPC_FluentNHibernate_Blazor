// ProductGRPC.Server/Repositories/ProductRepository.cs
using NHibernate;
using NHibernate.Linq; // Cho .ToListAsync()
using ProductGRPC.Server.Data;
using ProductGRPC.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductGRPC.Server.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<Product?> GetByIdAsync(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return await session.GetAsync<Product>(id);
            }
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return await session.Query<Product>().ToListAsync();
            }
        }

        public async Task AddAsync(Product product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                await session.SaveAsync(product);
                await transaction.CommitAsync();
            }
        }

        public async Task UpdateAsync(Product product)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                await session.UpdateAsync(product);
                await transaction.CommitAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var product = await session.GetAsync<Product>(id);
                if (product != null)
                {
                    await session.DeleteAsync(product);
                    await transaction.CommitAsync();
                }
                // Nếu không tìm thấy product, transaction sẽ tự rollback khi dispose
                // hoặc bạn có thể throw exception
            }
        }
    }
}