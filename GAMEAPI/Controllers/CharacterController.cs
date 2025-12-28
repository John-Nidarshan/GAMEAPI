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
        public async Task<ActionResult<CharacterResponse>>GetCharacter(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            return character is null ? NotFound("Charater with given ID was not not found") : Ok(character);
        }
    }
}
 