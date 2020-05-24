using PizzaCalories.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrWhiteSpace(value) ||
                    value.Length > LengthValidation.PizzaNameMaxLength)
                {
                    throw new ArgumentException(MessageValidation.InvalidPizzaNameLength);
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            private set => this.dough = value;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == LengthValidation.MaxToppingsCount)
            {
                throw new ArgumentException(MessageValidation.InvalidToppingsCount);
            }
            else
            {
                this.toppings.Add(topping);
            }
        }

        public override string ToString()
        {
            double totalCalories = this.Dough.TotalCalories() + this.toppings.Sum(t => t.TotalCalories());
            return $"{this.Name} - {totalCalories:F2} Calories.";
        }
    }
}
