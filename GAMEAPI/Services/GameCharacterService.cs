using GAMEAPI.Data;
using GAMEAPI.Dtos;
using GAMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GAMEAPI.Services;

public class GameCharacterService(AppDbContext context
    ) : IGameCharacterService
{
    public Task<Character> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CharacterResponse>> GetAllCharactersAsync()
        => await context.Characters.Select(c=> new CharacterResponse
        {
            Name = c.Name,
            Game=c.Game,
            Role=c.Role,
        }).ToListAsync();

    public async Task<CharacterResponse?> GetCharacterByIdAsync(int id)
    {
        var result= await context.Characters
            .Where(c=>c.Id==id)
            .Select(c=> new CharacterResponse
            {
                Name = c.Name,
                Game=c.Game,
                Role=c.Role,
            }).FirstOrDefaultAsync();
        return result;
    }

    public Task<Character> RemoveCharacterAsync()
    {
        throw new NotImplementedException();
    }
}

