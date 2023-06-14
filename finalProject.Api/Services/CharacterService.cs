using finalProject.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Api.Services
{
    public class CharacterService
    {
        private readonly AppDbContext _db;

        public CharacterService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<PDCharacter>> GetCharactersAsync()
        {
            var characters = await _db.PDCharacters
                .OrderByDescending(x => x.CharacterId)
                .ToListAsync();

            return characters;
        }
    }
}
