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

        int NumberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations;

        void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = NumberOfPeople * 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = NumberOfPeople * 20.0M;
            }
        }
        void CalculateCosOfDecrations(bool decorations)
        {
            if (decorations)
            {
                CostOfDecorations = NumberOfPeople * 15.0M + 50.0M;
            }
            else
            {
                CostOfDecorations = NumberOfPeople * 7.5M + 30.0M;
            }
        }
        decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = (CostOfFoodPerPerson + CostOfBeveragesPerPerson + CostOfDecorations) * NumberOfPeople;
            if (healthyOption)
            {
               return totalCost = totalCost * 0.95M;
            }
            else
            {
              return  totalCost;
            }
        }

    }
}
