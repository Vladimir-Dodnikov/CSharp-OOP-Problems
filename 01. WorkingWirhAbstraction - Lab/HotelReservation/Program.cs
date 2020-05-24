using System;

namespace HotelReservation
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            var pricePerDay = decimal.Parse(input[0]);
            var numberOfDays = int.Parse(input[1]);
            var season = input[2];
            var discountType = "None";

            if (input.Length > 3)
            {
                discountType = input[3];
            }

            PriceCalculator totalAmount = new PriceCalculator(pricePerDay, numberOfDays,
                Enum.Parse<Season>(season),
                Enum.Parse<DiscountType>(discountType));

            var total = totalAmount.GetTotalPrice();

            Console.WriteLine($"{total:f2}");
        }
    }
}
