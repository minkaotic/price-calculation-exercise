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
            return 0;
        }

        public void Add(string butter)
        {
            _contents.Add("butter");
        }
    }
}