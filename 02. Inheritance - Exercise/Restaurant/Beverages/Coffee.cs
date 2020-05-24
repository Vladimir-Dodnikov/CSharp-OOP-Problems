namespace Restaurant.Beverages
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50.0;
        private const decimal coffeePrice = 3.50m ;

        public Coffee(string name, double caffeine)
            : base(name, coffeePrice, coffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        //public override double Milliliters { get => coffeeMilliliters; }

        //public override decimal Price { get => coffeePrice; }

        public double Caffeine { get; set; }
    }
}
