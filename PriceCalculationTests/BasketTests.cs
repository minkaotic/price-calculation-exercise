using NUnit.Framework;
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

        [Test]
        public void Given_the_basket_contains_one_butter_the_total_should_be_80_pence()
        {
            var basket = new Basket();
            basket.Add("butter");

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(0.80));
        }
    }
}