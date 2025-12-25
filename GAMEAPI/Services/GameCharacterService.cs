using GAMEAPI.Models;

namespace GAMEAPI.Services;

public class GameCharacterService : IGameCharacterService
{
    public Task<Character> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<List<Character>> GetAllCharactersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Character>> GetCharacterByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Character> RemoveCharacterAsync()
    {
        throw new NotImplementedException();
    }
}

