using GAMEAPI.Dtos;
using GAMEAPI.Models;
using GAMEAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GAMEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController(IGameCharacterService service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<CharacterResponse>>> GetCharacters()
            => Ok(await service.GetAllCharactersAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterResponse>> GetCharacter(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("Charater with given ID was not not found") : Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<CharacterResponse>> AddCharacter(CreateCharacterResponse character)
        {
            var createdCharacter = await service.AddCharacterAsync(character);
            return CreatedAtAction(nameof(GetCharacter), new { id = createdCharacter.Id }, createdCharacter);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult> UpdateCharacter(int id, UpdateCharacterRequest character)
        {
            var updated = await service.UpdateCharacterAsync(id, character);
            return updated ? NoContent() : NotFound("Character with the givern Id was not found");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteCharacter(int id)
        {
            var deleted = await service.RemoveCharacterAsync(id);
            return deleted ? NoContent() : NotFound("Character with the givern Id was not found");
        }
    }
}
 