using System.Collections.Generic;
using System.Linq;

namespace PriceCalculationExercise
{
    public class Buy2ButterGet1BreadAtHalfPrice : IOffer
    {
        public double DiscountFor(List<string> basketContents, Dictionary<string, double> priceList)
        {
            var discount = 0.0;

            var butters = basketContents.Where(x => x == "butter");
            if (butters.Count() == 2 && basketContents.Contains("bread"))
            {
                discount += priceList["bread"] / 2;
            }
            return discount;
        }
    }
}