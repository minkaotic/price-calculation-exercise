using System.Collections.Generic;

namespace PriceCalculationExercise
{
    public class Basket
    {
        private List<string> _contents = new List<string>();

        public double Total()
        {
            if (_contents.Contains("butter"))
            {
                return 0.80;
            }
            else if (_contents.Contains("milk"))
            {
                return 1.15;
            }
            else if (_contents.Contains("bread"))
            {
                return 1.00;
            }
            return 0;
        }

        public void Add(string item)
        {
            _contents.Add(item);
        }
    }
}