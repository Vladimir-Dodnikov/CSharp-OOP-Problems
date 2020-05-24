using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Repositories;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Core
{
    public class Controller : IController
    {
        private DwarfRepository dwarfRepository;
        private PresentRepository presentRepository;
        public Controller()
        {
            this.dwarfRepository = new DwarfRepository();
            this.presentRepository = new PresentRepository();

        }
        public string AddDwarf(string dwarfType, string dwarfName)
        {
            Dwarf dwarf;
            if (dwarfType == "HappyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if (dwarfType == "SleepyDwarf")
            {
                dwarf = new SleepyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidDwarfType));
            }

            this.dwarfRepository.Add(dwarf);
            return string.Format(OutputMessages.DwarfAdded, dwarfType, dwarfName);
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            Instrument instrument = new Instrument(power);
            var requiredDwarf = this.dwarfRepository.GetType().Name;
            if (requiredDwarf != dwarfName)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDwarf));
            }
            else
            {
                instrument = new Instrument(power);
                this.dwarfRepository.FindByName(dwarfName).AddInstrument(instrument);
            }
            return string.Format(OutputMessages.InstrumentAdded, power, dwarfName);
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            var present = new Present(presentName, energyRequired);
            this.presentRepository.Add(present);

            return string.Format(OutputMessages.PresentAdded, presentName);
        }

        public string CraftPresent(string presentName)
        {

            var presentToCraft = this.presentRepository.Models.FirstOrDefault(p => p.Name == presentName);
            var mostReadyDwarfs = dwarfRepository.Models.Where(d => d.Energy >= 50).ToList();

            if (mostReadyDwarfs.Count == 0)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DwarfsNotReady));
            }

            foreach (var dwarf in mostReadyDwarfs)
            {
                dwarf.Work();

                if (dwarf.Energy == 0)
                {
                    this.dwarfRepository.Remove(dwarf);
                }
            }

            if (presentToCraft.IsDone())
            {
                return string.Format(OutputMessages.PresentIsDone, presentName);
            }
            else
            {
                return string.Format(OutputMessages.PresentIsNotDone, presentName);
            }
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.presentRepository.Models.Count} presents are done!");
            sb.AppendLine("Dwarfs info:");
            foreach (var dwarf in dwarfRepository.Models)
            {
                sb.AppendLine($"Name: {dwarf.Name}");
                sb.AppendLine($"Energy: {dwarf.Energy}");
                sb.AppendLine($"Instruments {dwarf.Instruments.Count} not broken left");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
