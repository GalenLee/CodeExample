using System;
using System.Collections.Generic;

namespace Example
{
    // IGNORE

    public class DataAccessLayer
    {
        public static List<SaleDto> GetPriorYearSales(int customerId)
        {
            switch (customerId)
            {
                case 1:
                    return new List<SaleDto> { new SaleDto { Amount = 1000, Date = new DateTime(2019, 1, 1) } };
                case 2:
                    return new List<SaleDto> { new SaleDto { Amount = 5000, Date = new DateTime(2019, 1, 2) } };
                case 4:
                    return new List<SaleDto>
                    {
                        new SaleDto { Amount = 4000, Date = new DateTime(2019, 1, 3) },
                        new SaleDto { Amount = 6000, Date = new DateTime(2019, 1, 4) }
                    };
                default:
                    return new List<SaleDto>();
            }
        }
    }

    public class SaleDto
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}