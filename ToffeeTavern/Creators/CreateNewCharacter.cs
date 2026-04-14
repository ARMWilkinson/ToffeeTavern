using ToffeeTavern.Creators.Interfaces;
using ToffeeTavern.Data;
using ToffeeTavern.DTOs;
using ToffeeTavern.Models;

namespace ToffeeTavern.Creators
{
    public class CreateNewCharacter : ICreateNewCharacter
    {
        private readonly ToffeeContext _context;

        public CreateNewCharacter(ToffeeContext context)
        {
            _context = context;
        }

        public async Task<Character> Create(CreateCharacterRequest request)
        {
            var newCharacter = new Character
            {
                Name = request.Name,
                Level = request.Level
            };
            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();
            return newCharacter;
        }
    }
}
