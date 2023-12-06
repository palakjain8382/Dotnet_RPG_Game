using dontnetRPG.DTO.Character;
using dontnetRPG.DTO.Weapon;
using dontnetRPG.Models;

namespace dontnetRPG.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterResponseDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
