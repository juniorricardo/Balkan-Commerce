using Catalog.Persistence.DataBase;
using Catalog.Service.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Service.Queries
{
    public interface IProductInStockQueryService
    {
        Task<DataCollection<ProductInStockDto>> GetAllAsync(int page,
            int take,
            IEnumerable<int> products = null);

        Task<ProductInStockDto> GetAsync(int id);
    }


    public class ProductInStockQueryService : IProductInStockQueryService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductInStockQueryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DataCollection<ProductInStockDto>> GetAllAsync(int page, 
            int take, 
            IEnumerable<int> products = null)
        {
            var collection = await _dbContext.Stocks
                .Where(x => products == null || products.Contains(x.ProductId))
                .OrderByDescending(x => x.ProductId)
                .GetPagedAsync(page,
                    take);

            return collection.MapTo<DataCollection<ProductInStockDto>>();
        }

        public async Task<ProductInStockDto> GetAsync(int id)
        {
            return (await _dbContext.Stocks
                .SingleAsync(x => x.ProductInStockId == id))
                .MapTo<ProductInStockDto>();
        }
    }
}