﻿namespace Domain.Models
{
    public class Character
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public required RPGClass Class { get; set; }
    }
}
