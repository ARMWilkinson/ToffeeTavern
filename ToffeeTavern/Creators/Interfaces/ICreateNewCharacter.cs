using ToffeeTavern.DTOs;
using ToffeeTavern.Models;

namespace ToffeeTavern.Creators.Interfaces
{
    public interface ICreateNewCharacter
    {
        Task<Character> Create(CreateCharacterRequest request);
    }
}
