using dontnetRPG.Models;

namespace dontnetRPG.DTO.Character
{
    public class AddCharacterRequestDto
    {
        public string? Name { get; set; } = "Panda";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
