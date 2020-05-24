using PizzaCalories.Validation;
using System;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;

            private set
            {
                if (value.ToLower() != "meat" &&
                    value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" &&
                    value.ToLower() != "sauce")
                {
                    throw new ArgumentException(string.Format(MessageValidation.InvalidToppingType, value));
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < LengthValidation.MinToppingWeight || value > LengthValidation.MaxToppingWeight)
                {
                    throw new ArgumentException(string.Format(MessageValidation.InvalidToppingWeight, this.Type));
                }

                this.weight = value;
            }
        }

        public double TotalCalories()
        {
            double result = 2 * this.Weight;

            result = ExecuteToppingType(result);

            return result;
        }

        private double ExecuteToppingType(double result)
        {
            switch (this.Type.ToLower())
            {
                case "meat":
                    result *= 1.2;
                    break;

                case "veggies":
                    result *= 0.8;
                    break;

                case "cheese":
                    result *= 1.1;
                    break;

                case "sauce":
                    result *= 0.9;
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
