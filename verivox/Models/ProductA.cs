using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace verivox.Models
{
    public class ProductA
    {
        private const decimal baseCostInEuroPerMonth = 5;
        private const decimal consumptionCostInCentPerKWh = 22;

        public ProductA(decimal annualConsumptionInKWh = 0)
        {
            AnnualConsumptionInKWh = annualConsumptionInKWh;
        }

        public string TariffName { get; set; } = "Basic Electricity Tariff";

        public decimal AnnualConsumptionInKWh { get; set; }

        public decimal AnnualCost
        {
            get 
            {
                decimal annualBaseCostInEuro = baseCostInEuroPerMonth * 12;
                decimal annualConsumptionCostInEuro = AnnualConsumptionInKWh * consumptionCostInCentPerKWh / 100;
                return annualBaseCostInEuro + annualConsumptionCostInEuro;
            }
            
        }
    }
}
