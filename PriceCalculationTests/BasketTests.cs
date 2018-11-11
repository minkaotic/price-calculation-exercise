using NUnit.Framework;
using PriceCalculationExercise;

namespace PriceCalculationTests
{
    public class BasketTests
    {
        private Basket _basket;

        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
        }

        [Test]
        public void Given_the__basket_is_empty_the_total_should_be_zero()
        {
            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(0));
        }

        [TestCase("butter", 0.80)]
        [TestCase("milk", 1.15)]
        [TestCase("bread", 1.00)]
        public void Given_the__basket_contains_only_one_item_the_total_should_be_individual_item_price(string item, double expectedPrice)
        {
            _basket.Add(item);

            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Given_the__basket_has_1_bread_1_butter_and_1_milk_the_total_should_be_2_95()
        {
            _basket.Add("bread");
            _basket.Add("butter");
            _basket.Add("milk");

            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(2.95));
        }

        [Test]
        public void Given_the__basket_has_2_butter_and_2_bread_the_total_should_be_3_10()
        {
            _basket.Add("butter");
            _basket.Add("butter");
            _basket.Add("bread");
            _basket.Add("bread");

            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(3.10));
        }

        [Test]
        public void Given_the__basket_has_4_milk_the_total_should_be_3_45()
        {
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");

            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(3.45));
        }

        [Test]
        public void Given_the__basket_has_2_butter_1_bread_and_8_milk_the_total_should_be_9_00()
        {
            _basket.Add("butter");
            _basket.Add("butter");
            _basket.Add("bread");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");
            _basket.Add("milk");

            var total = _basket.Total();

            Assert.That(total, Is.EqualTo(9.00));
        }
    }
}