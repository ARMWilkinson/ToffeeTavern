using ToffeeTavern.Data;
using ToffeeTavern.Getters.Interfaces;
using ToffeeTavern.Models;
using Microsoft.EntityFrameworkCore;

namespace ToffeeTavern.Getters
{
    public class GetAllCharacters : IGetAllCharacters
    {
        private ToffeeContext _context;

        public GetAllCharacters(ToffeeContext context)
        {
            _context = context;
        }

        public async Task<List<Character>> Get()
        {
            return await _context.Characters.ToListAsync();
        }
    }
}
