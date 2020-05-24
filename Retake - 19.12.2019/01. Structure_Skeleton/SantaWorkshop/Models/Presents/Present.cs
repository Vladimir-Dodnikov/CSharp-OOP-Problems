using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Presents
{
    public class Present : IPresent
    {
        private string name;
        private int energy;
        public Present(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPresentName));
                }
                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get => this.energy;
            private set
            {
                if (value < 0)
                {
                    this.energy = 0;
                }
                this.energy = value;
            }
        }

        public void GetCrafted()
        {
            if (this.energy > 0)
            {
                this.energy -= 10;
            }
        }

        public bool IsDone()
        {
            return this.EnergyRequired == 0;
        }
    }
}
