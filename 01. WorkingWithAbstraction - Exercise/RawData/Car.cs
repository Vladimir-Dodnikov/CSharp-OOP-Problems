using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        private string model;
        private int engineSpeed;
        private int enginePower;
        private int cargoWeight;
        private string cargoType;
        private Tire[] tires;
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public string Model { get => this.model; set => this.model = value; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get => this.tires; set => this.tires = value; }
    }
}
