using FootballTeamGenerator.DataValidation;
using System;

namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        public Player(string name, Stats stat)
        {
            this.Name = name;
            this.Stat = stat;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Validation.EmptyNameException);


                }
                this.name = value;
            }
        }
        public double OverallSkill => this.Stat.OverallStat();
        public Stats Stat { get; private set; }
    }
}
