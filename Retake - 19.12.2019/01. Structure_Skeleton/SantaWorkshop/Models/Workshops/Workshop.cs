using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public void Craft(IPresent present, IDwarf dwarf)
        {
            while (!present.IsDone() || dwarf.Energy > 0)
            {
                foreach (var instrument in dwarf.Instruments)
                {
                    if (!instrument.IsBroken())
                    {
                        instrument.Use();
                        present.GetCrafted();

                        if (instrument.Power <= 0)
                        {
                            instrument.IsBroken();
                        }

                        if (present.IsDone())
                        {
                            break;
                        }
                        else
                        {
                            instrument.Use();
                            present.GetCrafted();
                        }
                    }
                }
            }
        }
    }
}
