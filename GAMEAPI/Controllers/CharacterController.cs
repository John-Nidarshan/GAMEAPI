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
        public async Task<ActionResult<List<Character>>> GetCharacters()
            => Ok(await service.GetAllCharactersAsync());
    }
}
 