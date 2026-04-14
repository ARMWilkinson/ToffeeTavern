using ToffeeTavern.Models;

namespace ToffeeTavern.Getters.Interfaces
{
    public interface IGetCharacterById
    {
        Task<Character> Get(int id);
    }
}
