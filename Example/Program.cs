using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer ID");
            var customerId = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Enter sale amount");
            var saleAmount = double.Parse(Console.ReadLine() ?? "");
            var discount = ExampleA.GetDiscount(saleAmount, customerId);
            Console.WriteLine("Discount = " + discount);
            Console.WriteLine("Hit enter to exit");
            Console.ReadLine();
        }
    }
}
