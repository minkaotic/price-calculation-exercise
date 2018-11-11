using System.Collections.Generic;

namespace PriceCalculationExercise
{
    public interface IOffer
    {
        double DiscountFor(List<string> basketContents, Dictionary<string, double> priceList);
    }
}