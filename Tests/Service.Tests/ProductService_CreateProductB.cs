using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using verivox.Models;
using verivox.Services;
using Xunit;

namespace Tests.Service.Tests
{
    public class ProductService_CreateProductB
    {
        private readonly IProductService _productService;
        public ProductService_CreateProductB()
        {
            _productService = new ProductService();
        }

        [Fact]
        public void CreateProductB_ShouldCreateProductB()
        {
            // arrange
            decimal annualConsumptionInKWh = 1000;

            // act
            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            // assert
            Assert.IsType<ProductB>(productB);
        }

        [Fact]
        public void CreateProductB_ConsumptionLessOrEqualTo4000KWh_ReturnsAnnualCost800()
        {
            decimal annualConsumptionInKWh = 0;

            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            Assert.Equal(800, productB.AnnualCost);
        }

        [Fact]
        public void CreateProductB_ConsumptionGreaterThan4000KWh_ReturnsAnnualCostGreaterThan800()
        {
            decimal annualConsumptionInKWh = 4100;

            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            Assert.True(productB.AnnualCost > 800, "Expected annualCost to be greater than 800");
        }

        [Fact]
        public void CreateProductB_3500KWh_ReturnsAnnualCost800()
        {
            decimal annualConsumptionInKWh = 3500;

            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            Assert.Equal(800, productB.AnnualCost);
        }

        [Fact]
        public void CreateProductB_4500KWh_ReturnsAnnualCost950()
        {
            decimal annualConsumptionInKWh = 4500;

            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            Assert.Equal(950, productB.AnnualCost);
        }

        [Fact]
        public void CreateProductB_6000KWh_ReturnsAnnualCost1400()
        {
            decimal annualConsumptionInKWh = 6000;

            var productB = _productService.CreateProductB(annualConsumptionInKWh);

            Assert.Equal(1400, productB.AnnualCost);
        }
    }
}
