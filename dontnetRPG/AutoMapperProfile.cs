using AutoMapper;
using dontnetRPG.DTO.Character;
using dontnetRPG.DTO.Fight;
using dontnetRPG.DTO.SKill;
using dontnetRPG.DTO.Weapon;
using dontnetRPG.Models;

namespace dontnetRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>();
            CreateMap<AddCharacterRequestDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();
        }
    }
}
