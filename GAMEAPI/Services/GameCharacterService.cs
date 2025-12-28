using GAMEAPI.Data;
using GAMEAPI.Dtos;
using GAMEAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GAMEAPI.Services;

public class GameCharacterService(AppDbContext context
    ) : IGameCharacterService
{
    public async Task<CharacterResponse> AddCharacterAsync(CreateCharacterResponse character)
    {
        var newCharater = new Character
        {
            Name = character.Name,
            Game = character.Game,
            Role = character.Role,
        };
        context.Characters.Add(newCharater);
        await context.SaveChangesAsync();

        return new CharacterResponse
        {
            Id = newCharater.Id,
            Name = character.Name,
            Game = character.Game,
            Role = character.Role,
        };
    }

    public async Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest charater)
    {
        var existingCharacter = await context.Characters.FindAsync(id);
        if (existingCharacter is null) return false;
        existingCharacter.Name = charater.Name;
        existingCharacter.Game = charater.Game;

        existingCharacter.Role = charater.Role;

        await context.SaveChangesAsync();
        return true;

    }

    public async Task<List<CharacterResponse>> GetAllCharactersAsync()
        => await context.Characters.Select(c => new CharacterResponse
        {
            Id = c.Id,
            Name = c.Name,
            Game = c.Game,
            Role = c.Role,
        }).ToListAsync();

    public async Task<CharacterResponse?> GetCharacterByIdAsync(int id)
    {
        var result = await context.Characters
            .Where(c => c.Id == id)
            .Select(c => new CharacterResponse
            {
                Id = c.Id,
                Name = c.Name,
                Game = c.Game,
                Role = c.Role,
            }).FirstOrDefaultAsync();
        return result;
    }

    public async Task<bool> RemoveCharacterAsync(int id)
    {
        var existingCharacter = await context.Characters.FindAsync(id);
        if (existingCharacter is null) return false;

        context.Characters.Remove(existingCharacter);
        await context.SaveChangesAsync();
        return true;
    }
}

