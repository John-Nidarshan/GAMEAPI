using GAMEAPI.Dtos;

namespace GAMEAPI.Services;

public interface IGameCharacterService
{
    Task<CharacterResponse?> GetCharacterByIdAsync(int id);
    Task<List<CharacterResponse>> GetAllCharactersAsync();

    Task<CharacterResponse> AddCharacterAsync(CreateCharacterResponse character);
    Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest charater);
    Task<bool> RemoveCharacterAsync(int id);

}

