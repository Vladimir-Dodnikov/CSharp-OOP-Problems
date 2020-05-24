namespace Restaurant.FoodProducts
{
    public class Cake : Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal cakePrice = 5m;

        public Cake(string name)
            : base(name, cakePrice, grams, calories)
        {
            //this.Name = name;
        }
        //public override decimal Price { get => cakePrice; }

        //public override double Grams { get => grams; }

        //public override double Calories { get => calories; }

    }
}
