using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class ExampleA
    {
        // CODE TO DISCUSS

        public static double GetDiscount(double saleAmount, int customerId)
        {
            var priorYearSales = DataAccessLayer.GetPriorYearSales(customerId);

            var totalSalesAmount = 0.0;
            var totalSalesCount = 0;
            foreach (var sale in priorYearSales)
            {
                totalSalesAmount = totalSalesAmount + sale.Amount;

                // Number of sales in past 6 months.
                if (12 * (DateTime.Now.Year - sale.Date.Year) +
                    (DateTime.Now.Month - sale.Date.Month) +
                    (DateTime.Now.Day >= sale.Date.Day ? 0 : -1) <= 6)
                {
                    totalSalesCount++;
                }
            }

            var discountPercent = 0.0;
            var additionalDiscountAmount = 0.0;
            if (priorYearSales.Count == 0)      // No prior sales so no Rewards Level.
                discountPercent = 0.0;
            else if (totalSalesAmount < 1000)   // Bronze level: At least on sale but less than $1,000.
                discountPercent = .025;
            else if (totalSalesAmount < 10000)  // Silver level: Sales >= $1,000 but < $10,000.
                discountPercent = .05;
            else                                // Gold level: Sales >= $10,000.
                discountPercent = .10;
                if (totalSalesCount > 5)
                {
                    additionalDiscountAmount = 50;  // Gold customer with frequent purchase
                }

            return Math.Round(saleAmount * discountPercent, 2) + additionalDiscountAmount;
        }
    }
}
