using System.Collections.Generic;
using System.Linq;

namespace PriceCalculationExercise
{
    public class Basket
    {
        private List<string> _contents = new List<string>();

        private readonly Dictionary<string, double> _priceList = new Dictionary<string, double>
        {
            {"butter", 0.80},
            {"milk", 1.15},
            {"bread", 1.00}
        };

        public double Total()
        {
            var total = 0.0;
            if (_contents.Count == 0)
            {
                return total;
            }

            foreach (var item in _contents)
            {
                total += _priceList[item];
            }

            return total;
        }

        public void Add(string item)
        {
            _contents.Add(item);
        }
    }
}