using ToffeeTavern.DTOs;
using ToffeeTavern.Models;

namespace ToffeeTavern.Updaters.Interfaces
{
    public interface IUpdateCharacterById
    {
        Task<Character> Update(UpdateCharacterRequest request);
    }
}
