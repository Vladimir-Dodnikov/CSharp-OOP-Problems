using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public class SleepyDwarf : Dwarf
    {
        private string dwarfName;

        public SleepyDwarf(string name) 
            : base(name, 50)
        {
        }

        public override void Work()
        {
            if (this.Energy < 0)
            {
                this.Energy = 0;
            }
            this.Energy -= 10;

        }
    }
}
