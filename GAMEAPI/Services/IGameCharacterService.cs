using GAMEAPI.Models;

namespace GAMEAPI.Services;

    public interface IGameCharacterService
    {
    Task<List<Character>> GetCharacterByIdAsync(int id);
    Task<List<Character>> GetAllCharactersAsync();

    Task<Character> AddCharacterAsync(Character character);
    Task<Character> RemoveCharacterAsync();

    }

