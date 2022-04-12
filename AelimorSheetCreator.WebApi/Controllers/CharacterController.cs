using AelimorSheetCreator.BC.BuisinessComponents.CharacterValidation;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterValueRetrievalBc _characterValueRetrievalBc;
        private readonly ICharacterValidationBc _characterValidationBc;

        public CharacterController(ICharacterValueRetrievalBc characterValueRetrievalBc, ICharacterValidationBc characterValidationBc)
        {
            _characterValidationBc = characterValidationBc;
            _characterValueRetrievalBc = characterValueRetrievalBc;
        }

        // POST api/<CharacterController>
        [HttpPost]
        public async Task<Character> Post([FromBody] CharacterValues character)
        {
            Character characterResolved = await _characterValueRetrievalBc.RetrieveCharacterValues(character);
            _characterValidationBc.Validate(characterResolved);
            return characterResolved;
        }
    }
}
