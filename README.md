# Price Calculation Exercise

## Task
Create a customer basket that allows a customer to add products and provides a total cost of the
basket including applicable discounts.

### Available products

| Product  | Cost   |
| -------- |:------:|
| butter   | £0.80  |
| milk     | £1.15  |
| bread    | £1.00  |

### Offers

- Buy 2 Butter and get a Bread at 50% off
- Buy 3 Milk and get the 4th milk for free

### Scenarios
- Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total
should be £2.95
- Given the basket has 2 butter and 2 bread when I total the basket then the total should be
£3.10
- Given the basket has 4 milk when I total the basket then the total should be £3.45
- Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total
should be £9.00

## Approach
#### Software used:
- Visual Studio 2015 Community Edition
- C# (Net Framework 4.6.1)
- Nunit 3
- Resharper

#### Testing:
All code was test-driven. In addition to the scenarios requested, I began with two more basic test scenarios, covering:
- Empty basket behaviour (for this I assumed that an empty basket should total 0)
- Implicit acceptance criteria around individual item prices, based on the price table above.

Apart from these, I have limited the implementation to the scenarios requested, and not dealt with tests or implementation for other scenarios or edge cases. For example, at present, the "Buy 2 Butter and get a Bread at 50% off" discount would only get applied to a basket once, even if multiple sets of these items were added.

#### Future development:
In the real world, it would be likely that the item prices and discount logic would change frequently. In this case it would make sense to inject both the `_priceList` and `_offers` into the constructor of the `Basket` class, rather than them being hardcoded in the class itself. To make this easy and obvious for future change, I've moved the assignment of these two fields into the constructor.

Once there is a need for more discounts, it would also make sense to refactor the offer classes to be more flexible, so they can work for varying items and quantities. These parameters could again be passed into the offer via the constructor, along the lines of:

```
public class BuyNGetNFreeOffer : IOffer
{
   public BuyNGetNFreeOffer(string item, int numberToTriggerDiscount, int numberOfFreeItems)
   {
       ...
   }
   ...
 }
```

(For the purpose of this exercise, this would have felt like overengineering, as it isn't presently required by the existing scenarios.)
