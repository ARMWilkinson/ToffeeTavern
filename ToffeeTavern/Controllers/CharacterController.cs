using Microsoft.AspNetCore.Mvc;
using ToffeeTavern.Creators.Interfaces;
using ToffeeTavern.DTOs;
using ToffeeTavern.Getters.Interfaces;

namespace ToffeeTavern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IGetAllCharacters _getAllCharacters;
        private readonly IGetCharacterById _getCharacterById;
        private readonly ICreateNewCharacter _createNewCharacter;

        public CharacterController(
            IGetAllCharacters getAllCharacters, 
            IGetCharacterById getCharacterById, 
            ICreateNewCharacter createNewCharacter
            )
        {
            _getAllCharacters = getAllCharacters;
            _getCharacterById = getCharacterById;
            _createNewCharacter = createNewCharacter;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var characters = await _getAllCharacters.Get();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var character = await _getCharacterById.Get(id);
            return Ok(character);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCharacterRequest request)
        {
            var character = await _createNewCharacter.Create(request);
            return CreatedAtAction(nameof(Get), new { id = character.Id }, character);
        }
    }
}
