﻿namespace dontnetRPG.DTO.Fight
{
    public class HighscoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
