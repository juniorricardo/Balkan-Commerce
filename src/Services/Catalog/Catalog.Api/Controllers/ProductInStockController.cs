using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Catalog.Service.Queries;
using Catalog.Service.Queries.DTOs;
using Service.Common.Collection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.Api.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class ProductInStockController : ControllerBase
    {
        private readonly ILogger<ProductInStockController> _logger;
        private readonly IProductInStockQueryService _productInStockQueryService;
        private readonly IMediator _mediator;

        public ProductInStockController(ILogger<ProductInStockController> logger, IProductInStockQueryService productInStockQueryService, IMediator mediator)
        {
            _logger = logger;
            _productInStockQueryService = productInStockQueryService;
            _mediator = mediator;
        }

        // GET: api/<ProductInStockController>
        [HttpGet]
        public async Task<DataCollection<ProductInStockDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
                products = ids.Split(',').Select(x => Convert.ToInt32(x));

            return await _productInStockQueryService.GetAllAsync(page, take, products);
        }

        // GET api/<ProductInStockController>/5
        [HttpGet("{id}")]
        public async Task<ProductInStockDto> Get(int id)
        {
            return await _productInStockQueryService.GetAsync(id);
        }

        // PUT api/<ProductInStockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    }
}
