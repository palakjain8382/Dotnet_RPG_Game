﻿using Dotnet_RPG6.Models;

namespace Dotnet_RPG6.DTOs.Character
{
    public class AddCharacterDTO
    {
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RPGClass Class { get; set; } = RPGClass.Knight;
    }
}
