using finalProject.Api.Data;
using finalProject.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Api.Controllers
{
    [Route("Character")]
    [ApiController]
    public class CharacterController : Controller
    {
        private readonly CharacterService _characterService;

        public CharacterController(CharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetCharacters")]
        public async Task<IEnumerable<PDCharacter>> GetCharacters()
        {
            return await _characterService.GetCharactersAsync();
        }
    }
}
