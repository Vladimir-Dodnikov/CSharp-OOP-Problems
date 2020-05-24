﻿namespace FoodShortage
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthdate;
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name
        {
            get => name;
            private set => name = value;
        }
        public string Birthdate
        {
            get => birthdate;
            private set => birthdate = value;
        }
    }
}
