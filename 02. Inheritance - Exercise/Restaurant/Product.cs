﻿namespace Restaurant
{
    public abstract class Product
    {
        //private string  name;
        //private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; } 
        //public virtual string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //public virtual decimal Price
        //{
        //    get { return this.price; }
        //    set { this.price = value; }
        //}
    }
}
