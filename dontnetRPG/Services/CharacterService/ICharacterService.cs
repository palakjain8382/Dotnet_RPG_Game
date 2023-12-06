using dontnetRPG.DTO.Character;
using dontnetRPG.Models;

namespace dontnetRPG.Services.CharacterService
{
    public interface ICharacterService
    {
        public Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters();
        public Task<ServiceResponse<GetCharacterResponseDto>> GetCharacterById(int id);
        public Task<ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter);
        public Task<ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        public Task<ServiceResponse<List<GetCharacterResponseDto>>> DeleteCharacter(int id);
        Task<ServiceResponse<GetCharacterResponseDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
