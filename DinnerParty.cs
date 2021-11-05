using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations = 0;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }
        public void CalculateCostOfDecorations(bool decorations)
        {
            if (decorations)
            {
                CostOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30.0M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople + CostOfDecorations;
            if (healthyOption)
            {
               return totalCost * 0.95M;
            }
            else
            {
              return  totalCost;
            }
        }

    }
}
