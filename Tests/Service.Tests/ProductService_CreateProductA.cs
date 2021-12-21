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
    public class ProductService_CreateProductA
    {
        private readonly IProductService _productService;
        public ProductService_CreateProductA()
        {
            _productService = new ProductService();
        }

        [Fact]
        public void CreateProductA_ShouldCreateProductA()
        {
            // arrange
            decimal annualConsumptionInKWh = 3500;

            // act
            var productA = _productService.CreateProductA(annualConsumptionInKWh);

            // assert
            Assert.IsType<ProductA>(productA);
        }

        [Fact]
        public void CreateProductA_0KWh_ReturnsAnnualCost60()
        {
            decimal annualConsumptionInKWh = 0;

            var productA = _productService.CreateProductA(annualConsumptionInKWh);

            Assert.Equal(60, productA.AnnualCost);
        }

        [Fact]
        public void CreateProductA_3500KWh_ReturnsAnnualCost830()
        {
            decimal annualConsumptionInKWh = 3500;

            var productA = _productService.CreateProductA(annualConsumptionInKWh);

            Assert.Equal(830, productA.AnnualCost);
        }

        [Fact]
        public void CreateProductA_4500KWh_ReturnsAnnualCost1050()
        {
            decimal annualConsumptionInKWh = 4500;

            var productA = _productService.CreateProductA(annualConsumptionInKWh);

            Assert.Equal(1050, productA.AnnualCost);
        }

        [Fact]
        public void CreateProductA_6000KWh_ReturnsAnnualCost1380()
        {
            decimal annualConsumptionInKWh = 6000;

            var productA = _productService.CreateProductA(annualConsumptionInKWh);

            Assert.Equal(1380, productA.AnnualCost);
        }
    }
}
