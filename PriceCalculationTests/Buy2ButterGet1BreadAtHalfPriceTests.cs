using System.Collections.Generic;
using NUnit.Framework;
using PriceCalculationExercise;

namespace PriceCalculationTests
{
    public class Buy2ButterGet1BreadAtHalfPriceTests
    {
        private Buy2ButterGet1BreadAtHalfPrice _offer;
        private double _currentDiscount;
        private const double NoDiscount = 0.00;
        private const double HalfPriceDiscountForBread = 0.50;
        private readonly Dictionary<string, double> _priceList = new Dictionary<string, double>
        {
            {"butter", 0.80},
            {"bread", 1.00}
        };

        [SetUp]
        public void SetUp()
        {
            _offer = new Buy2ButterGet1BreadAtHalfPrice();
            _currentDiscount = NoDiscount;
        }

        [Test]
        public void Given_there_are_sufficient_items_the_discount_is_applied()
        {
            var basketWithSufficientItems = new List<string> { "butter", "butter", "bread" };

            _currentDiscount += _offer.DiscountFor(basketWithSufficientItems, _priceList);

            Assert.That(_currentDiscount, Is.EqualTo(HalfPriceDiscountForBread));
        }

        [Test]
        public void Given_there_are_insufficient_items_the_discount_is_not_applied()
        {
            var basketWithInsufficientItems = new List<string> { "butter", "bread" };

            _currentDiscount += _offer.DiscountFor(basketWithInsufficientItems, _priceList);

            Assert.That(_currentDiscount, Is.EqualTo(NoDiscount));
        }
    }
}