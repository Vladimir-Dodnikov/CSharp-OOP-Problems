using FootballTeamGenerator.DataValidation;
using System;

namespace FootballTeamGenerator.Models
{
    public class Stats
    {
        private const int minValueStats = 0;
        private const int maxValueStats = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    ValidateStats(value, nameof(this.Shooting));
                }
                this.shooting = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStats(value, nameof(this.Passing));
                    }
                }
                this.passing = value;
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStats(value, nameof(this.Dribble));
                    }
                }
                this.dribble = value;
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStats(value, nameof(this.Sprint));
                    }
                }
                this.sprint = value;
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    if (value < 0 || value > 100)
                    {
                        ValidateStats(value, nameof(this.Endurance));
                    }
                }
                this.endurance = value;
            }
        }
        public double OverallStat()
        {
            return (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        }
        private void ValidateStats(int value, string name)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(string.Format(Validation.InvalidStatException
                    , name, minValueStats, maxValueStats));
            }
        }
    }
}
