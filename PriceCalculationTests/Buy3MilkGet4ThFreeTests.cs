using System.Collections.Generic;
using NUnit.Framework;
using PriceCalculationExercise;

namespace PriceCalculationTests
{
    public class Buy3MilkGet4ThFreeTests
    {
        private Buy3MilkGet4ThFree _offer;
        private double _currentDiscount;
        private const double NoDiscount = 0.00;
        private const double DiscountForFreeMilk = 1.15;

        private readonly Dictionary<string, double> _priceList = new Dictionary<string, double>
        {
            {"milk", 1.15}
        };

        [SetUp]
        public void SetUp()
        {
            _offer = new Buy3MilkGet4ThFree();
            _currentDiscount = NoDiscount;
        }

        [Test]
        public void Given_there_are_sufficient_items_the_discount_is_applied()
        {
            var basketWithSufficientItems = new List<string> {"milk", "milk", "milk", "milk"};

            _currentDiscount += _offer.DiscountFor(basketWithSufficientItems, _priceList);

            Assert.That(_currentDiscount, Is.EqualTo(DiscountForFreeMilk));
        }

        [Test]
        public void Given_there_are_sufficient_items_the_discount_is_applied_multiple_times()
        {
            var basketWithSufficientItems = new List<string> {"milk", "milk", "milk", "milk", "milk", "milk", "milk", "milk" };

            _currentDiscount += _offer.DiscountFor(basketWithSufficientItems, _priceList);

            Assert.That(_currentDiscount, Is.EqualTo(DiscountForFreeMilk * 2));
        }

        [Test]
        public void Given_there_are_insufficient_items_the_discount_is_not_applied()
        {
            var basketWithInsufficientItems = new List<string> {"milk", "milk", "milk"};

            _currentDiscount += _offer.DiscountFor(basketWithInsufficientItems, _priceList);

            Assert.That(_currentDiscount, Is.EqualTo(NoDiscount));
        }
    }
}