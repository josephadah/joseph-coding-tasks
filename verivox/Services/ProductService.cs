using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using verivox.Models;

namespace verivox.Services
{
    public class ProductService : IProductService
    {
        public ProductA CreateProductA(decimal annualConsumptionInKWh)
        {
            return new ProductA(annualConsumptionInKWh);
        }

        public IEnumerable<ProductA> GetProductAs()
        {
            // create demo products
            var products = new List<ProductA>()
            {
                CreateProductA(3500),
                CreateProductA(4500),
                CreateProductA(6000)
            };

            return products.OrderBy(x => x.AnnualCost);
        }

        public ProductB CreateProductB(decimal annualConsumptionInKWh)
        {
            return new ProductB(annualConsumptionInKWh);
        }

        public IEnumerable<ProductB> GetProductBs()
        {
            // create demo products
            var products = new List<ProductB>()
            {
                CreateProductB(3500),
                CreateProductB(4500),
                CreateProductB(6000)
            };

            return products.OrderBy(x => x.AnnualCost);
        }
    }
}
