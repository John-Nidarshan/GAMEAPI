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

        static List<Character> character=new List<Character>
        {
            new Character{Id=1,Name="sss",Game="ssd",Role="sdsd"},
            new Character{Id=2,Name="sss",Game="ssd",Role="sdsd"},
            new Character{Id=3,Name="sss",Game="ssd",Role="sdsd"},
            new Character{Id=4 ,Name="sss",Game="ssd",Role="sdsd"},
        };



        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
            => Ok(await service.GetAllCharactersAsync());
    }
}
 