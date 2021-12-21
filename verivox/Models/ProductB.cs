using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace verivox.Models
{
    public class ProductB
    {
        private const decimal baseCostInEuro = 800;
        private const decimal baseAnnualConsumptionInKWh = 4000;
        private const decimal additionalCostInCentPerKWh = 30;

        public ProductB(decimal annualConsumptionInKWh)
        {
            AnnualConsumptionInKWh = annualConsumptionInKWh;
        }

        public string TariffName { get; set; } = "Packaged Tariff";

        public decimal AnnualConsumptionInKWh { get; set; }

        public decimal AnnualCost
        {
            get
            {
                if (AnnualConsumptionInKWh > baseAnnualConsumptionInKWh)
                {
                    decimal additionalConsumption = AnnualConsumptionInKWh - baseAnnualConsumptionInKWh;
                    decimal additionalCostInEuro = additionalConsumption * additionalCostInCentPerKWh / 100;
                    return baseCostInEuro + additionalCostInEuro;
                }
                else
                {
                    return baseCostInEuro;
                }
            }

        }
    }
}
