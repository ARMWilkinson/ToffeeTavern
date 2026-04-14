using Microsoft.EntityFrameworkCore;
using ToffeeTavern.Data;
using ToffeeTavern.Getters.Interfaces;
using ToffeeTavern.Models;

namespace ToffeeTavern.Getters
{
    public class GetCharacterById : IGetCharacterById
    {
        private readonly ToffeeContext _context;

        public GetCharacterById(ToffeeContext context)
        {
            _context = context;
        }

        public async Task<Character> Get(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character == null)
                throw new KeyNotFoundException($"Character with id {id} not found.");
            return character;
        }
    }
}
