using ToffeeTavern.Data;
using ToffeeTavern.DTOs;
using ToffeeTavern.Models;
using ToffeeTavern.Updaters.Interfaces;

namespace ToffeeTavern.Updaters
{
    public class UpdateCharacterById : IUpdateCharacterById
    {
        private readonly ToffeeContext _context;

        public UpdateCharacterById(ToffeeContext context)
        {
            _context = context;
        }

        public async Task<Character> Update(UpdateCharacterRequest request)
        {
            var character = await _context.Characters.FindAsync(request.Id);
            if (character == null)
            {
                throw new Exception("Character not found");
            }
            character.Name = request.Name;
            character.Level = request.Level;
            await _context.SaveChangesAsync();
            return character;
        }
    }
}
