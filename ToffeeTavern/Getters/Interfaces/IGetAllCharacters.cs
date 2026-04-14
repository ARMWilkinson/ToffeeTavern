using ToffeeTavern.Models;

namespace ToffeeTavern.Getters.Interfaces
{
    public interface IGetAllCharacters
    {
        Task<List<Character>> Get();
    }
}
