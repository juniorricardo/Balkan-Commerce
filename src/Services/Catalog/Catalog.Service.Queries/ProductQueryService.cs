﻿using Catalog.Persistence.DataBase;
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
    public interface IProductQueryService
    {
        Task<DataCollection<ProductDto>> GetAllAsync(int page,
            int take,
            IEnumerable<int> products = null);

        Task<ProductDto> GetAsync(int id);
    }

    public class ProductQueryService : IProductQueryService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductQueryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DataCollection<ProductDto>> GetAllAsync(int page,
            int take,
            IEnumerable<int> products = null)
        {
            var collection = await _dbContext.Products.Where(x => products == null || products.Contains(x.ProductId))
                .OrderByDescending(x => x.ProductId)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductDto>>();
        }

        public async Task<ProductDto> GetAsync(int id) => 
            (await _dbContext.Products.SingleAsync(x => x.ProductId == id)).MapTo<ProductDto>();
    }

}