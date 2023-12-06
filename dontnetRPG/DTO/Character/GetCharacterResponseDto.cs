using dontnetRPG.DTO.SKill;
using dontnetRPG.DTO.Weapon;
using dontnetRPG.Models;

namespace dontnetRPG.DTO.Character
{
    public class GetCharacterResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public int HitPoints { get; set; } 
        public int Strength { get; set; } 
        public int Defense { get; set; } 
        public int Intelligence { get; set; } 
        public RpgClass Class { get; set; }
        public GetWeaponDto? Weapon { get; set; }
        public List<GetSkillDto>? Skills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
