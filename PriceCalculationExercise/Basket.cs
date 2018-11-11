using System.Collections.Generic;
using System.Linq;

namespace PriceCalculationExercise
{
    public class Basket
    {
        private readonly List<string> _contents = new List<string>();

        private readonly Dictionary<string, double> _priceList = new Dictionary<string, double>
        {
            {"butter", 0.80},
            {"milk", 1.15},
            {"bread", 1.00}
        };

        public void Add(string item)
        {
            _contents.Add(item);
        }

        public double Total()
        {
            var total = 0.0;
            if (_contents.Count == 0)
            {
                return total;
            }

            total += CalculateRegularTotal();
            total -= CalculateDiscounts();

            return total;
        }

        private double CalculateRegularTotal()
        {
            var total = 0.0;
            foreach (var item in _contents)
            {
                total += _priceList[item];
            }
            return total;
        }

        private double CalculateDiscounts()
        {
            var discount = 0.0;
            var butters = _contents.Where(x => x == "butter");
            if (butters.Count() == 2 && _contents.Contains("bread"))
            {
                discount += _priceList["bread"]/2;
            }
            return discount;
        }
    }
}