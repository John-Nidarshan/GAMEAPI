using GAMEAPI.Dtos;
using GAMEAPI.Models;

namespace GAMEAPI.Services;

    public interface IGameCharacterService
    {
    Task<CharacterResponse?> GetCharacterByIdAsync(int id);
    Task<List<CharacterResponse>> GetAllCharactersAsync();

    Task<Character> AddCharacterAsync(Character character);
    Task<Character> RemoveCharacterAsync();

    }

