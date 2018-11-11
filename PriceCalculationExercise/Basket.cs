using System;
using System.Collections.Generic;

namespace PriceCalculationExercise
{
    public class Basket
    {
        private readonly List<string> _contents;
        private readonly Dictionary<string, double> _priceList;
        private readonly IEnumerable<IOffer> _offers;

        public Basket()
        {
            _contents = new List<string>();
            _priceList = new Dictionary<string, double>
            {
                {"butter", 0.80},
                {"milk", 1.15},
                {"bread", 1.00}
            };
            _offers = new List<IOffer>
            {
                new Buy3MilkGet4ThFree(),
                new Buy2ButterGet1BreadAtHalfPrice()
            };
        }

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

            return Math.Round(total, 2);
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
            foreach (var offer in _offers)
            {
                discount += offer.DiscountFor(_contents, _priceList);
            }
            return discount;
        }
    }
}