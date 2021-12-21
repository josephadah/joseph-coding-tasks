using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using verivox.Models;
using verivox.Services;

namespace verivox.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("productAs")]
        public IEnumerable<ProductA> GetProductAs()
        {
            return _productService.GetProductAs();
        }

        [HttpGet("productBs")]
        public IEnumerable<ProductB> GetProductBs()
        {
            return _productService.GetProductBs();
        }
    }
}
