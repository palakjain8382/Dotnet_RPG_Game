using dontnetRPG.DTO.Fight;
using dontnetRPG.Models;

namespace dontnetRPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultsDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultsDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();


    }
}
