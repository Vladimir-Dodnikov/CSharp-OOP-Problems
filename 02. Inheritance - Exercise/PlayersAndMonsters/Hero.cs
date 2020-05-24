﻿using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string userName, int level)
        {
            this.Username = userName;
            this.Level = level;
        }
        public string Username { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}");

            return sb.ToString();
        }
    }
}
