﻿using NUnit.Framework;
using PriceCalculationExercise;

namespace PriceCalculationTests
{
    public class BasketTests
    {
        [Test]
        public void Given_the_basket_is_empty_the_total_should_be_zero()
        {
            var basket = new Basket();

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(0));
        }

        [TestCase("butter", 0.80)]
        [TestCase("milk", 1.15)]
        [TestCase("bread", 1.00)]
        public void Given_the_basket_contains_an_individual_item_the_total_should_be_correct(string item, double expectedPrice)
        {
            var basket = new Basket();
            basket.Add(item);

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(expectedPrice));
        }
    }
}