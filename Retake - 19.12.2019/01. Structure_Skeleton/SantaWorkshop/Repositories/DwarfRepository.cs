using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Repositories
{
    public class DwarfRepository : IRepository<Dwarf>
    {
        private List<Dwarf> dwarfs;
        public DwarfRepository()
        {
            this.dwarfs = new List<Dwarf>();
        }
        public IReadOnlyCollection<Dwarf> Models => this.dwarfs;

        public void Add(Dwarf model)
        {
            this.dwarfs.Add(model);
        }

        public Dwarf FindByName(string name)
        {
            return this.dwarfs.Find(d => d.Name == name);
        }

        public bool Remove(Dwarf model)
        {
            return this.dwarfs.Remove(model);
        }

    }
}
