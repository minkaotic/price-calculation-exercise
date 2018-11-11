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

All code was test-driven. I began with a few more basic test scenarios in order to get started with small slices.
For the purpose of this exercise, I have limited the implementation to the scenarios requested, and not dealt with tests or implementation for other scenarios or edge cases. For example, at present, the "Buy 2 Butter and get a Bread at 50% off" discount would only get applied to a basket once, even if multiple sets of these items were added.
