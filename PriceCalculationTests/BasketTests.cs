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

        [TestCase("butter", 0.80)]
        [TestCase("milk", 1.15)]
        [TestCase("bread", 1.00)]
        public void Given_the_basket_contains_only_one_item_the_total_should_be_indvidual_item_price(string item, double expectedPrice)
        {
            var basket = new Basket();
            basket.Add(item);

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Given_the_basket_has_1_bread_1_butter_and_1_milk_the_total_should_be_2_95()
        {
            var basket = new Basket();
            basket.Add("bread");
            basket.Add("butter");
            basket.Add("milk");

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(2.95));
        }

        [Test]
        public void Given_the_basket_has_2_butter_and_2_bread_the_total_should_be_3_10()
        {
            var basket = new Basket();
            basket.Add("butter");
            basket.Add("butter");
            basket.Add("bread");
            basket.Add("bread");

            var total = basket.Total();

            Assert.That(total, Is.EqualTo(3.10));
        }
    }
}