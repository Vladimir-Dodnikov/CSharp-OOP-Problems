namespace HotelReservation
{
    public class PriceCalculator
    {

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, DiscountType discountType)
        {
            this.PricePerDay = pricePerDay;
            this.NumberOfDays = numberOfDays;
            this.Season = season;
            this.DiscountType = discountType;
        }

        public decimal PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public Season Season { get; set; }
        public DiscountType DiscountType { get; set; }

        public decimal GetTotalPrice()
        {
            var priceBeforeDiscount = this.PricePerDay * this.NumberOfDays * (int)Season;

            var discount = priceBeforeDiscount * (int)DiscountType / 100;

            var totalPrice = priceBeforeDiscount - discount;

            return totalPrice;
        }
    }
}
