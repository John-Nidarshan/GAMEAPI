using GAMEAPI.Data;
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

    public Task<List<Character>> GetAllCharactersAsync()
        => context.Characters.ToListAsync();

    public Task<List<Character>> GetCharacterByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Character> RemoveCharacterAsync()
    {
        throw new NotImplementedException();
    }
}

