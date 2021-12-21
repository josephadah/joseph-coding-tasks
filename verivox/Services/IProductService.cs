using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using verivox.Models;

namespace verivox.Services
{
    public interface IProductService
    {
        ProductA CreateProductA(decimal annualConsumptionInKWh);

        IEnumerable<ProductA> GetProductAs();

        ProductB CreateProductB(decimal annualConsumptionInKWh);

        IEnumerable<ProductB> GetProductBs();
    }
}
