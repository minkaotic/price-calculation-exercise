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
            if (_contents.Count == 0)
            {
                return 0;
            }

            return _priceList[_contents.First()];
        }

        public void Add(string item)
        {
            _contents.Add(item);
        }
    }
}