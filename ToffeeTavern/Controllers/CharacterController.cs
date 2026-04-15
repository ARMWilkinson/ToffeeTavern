using Microsoft.AspNetCore.Mvc;
using ToffeeTavern.Creators.Interfaces;
using ToffeeTavern.Deleters.Interfaces;
using ToffeeTavern.DTOs;
using ToffeeTavern.Getters.Interfaces;
using ToffeeTavern.Updaters.Interfaces;

namespace ToffeeTavern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IGetAllCharacters _getAllCharacters;
        private readonly IGetCharacterById _getCharacterById;
        private readonly ICreateNewCharacter _createNewCharacter;
        private readonly IUpdateCharacterById _updateCharacterById;
        private readonly IDeleteCharacterById _deleteCharacterById;

        public CharacterController(
            IGetAllCharacters getAllCharacters,
            IGetCharacterById getCharacterById,
            ICreateNewCharacter createNewCharacter,
            IUpdateCharacterById updateCharacterById,
            IDeleteCharacterById deleteCharacterById
            )
        {
            _getAllCharacters = getAllCharacters;
            _getCharacterById = getCharacterById;
            _createNewCharacter = createNewCharacter;
            _updateCharacterById = updateCharacterById;
            _deleteCharacterById = deleteCharacterById;
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

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCharacterRequest request)
        {
            var updatedCharacter = await _updateCharacterById.Update(request);
            return Ok(updatedCharacter);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _deleteCharacterById.Delete(id);
            return NoContent();
        }
    }
}
