using System.Collections.Generic;
using System.Linq;

namespace PriceCalculationExercise
{
    public class Buy3MilkGet4ThFree : IOffer
    {
        public double DiscountFor(List<string> basketContents, Dictionary<string, double> priceList)
        {
            var discount = 0.0;

            var milks = basketContents.Where(x => x == "milk");
            if (milks.Count() > 3)
            {
                var numberOfMilkQuartets = milks.Count() / 4;
                discount += priceList["milk"] * numberOfMilkQuartets;
            }

            return discount;
        }
    }
}