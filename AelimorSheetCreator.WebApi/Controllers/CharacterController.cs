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
        public async Task<CharacterSheet> Post([FromBody] CharacterValues character)
        {
            Character characterResolved = await _characterValueRetrievalBc.RetrieveCharacterValues(character);
            string validateMessage = _characterValidationBc.Validate(characterResolved);

            if (validateMessage != "Valid")
            {
                throw new ArgumentException(validateMessage);
            }

            //Maybe temporary but a condensed version of the sheet gets returned so you can read it easier
            var characterReturn = new CharacterSheet();

            characterReturn.CharacterName = characterResolved.CharacterName;
            characterReturn.XpTotal = characterResolved.XpTotal;
            characterReturn.XpSpent = characterResolved.XpSpent;
            characterReturn.LevelNum = characterResolved.Level.LevelNum;
            characterReturn.RaceName = characterResolved.Race.RaceName;

            var classes = new List<string>();

            foreach (var characterClass in characterResolved.Classes)
            {
                classes.Add(characterClass.ClassName);
            }
            characterReturn.Classes = classes;

            var attributes = new List<string>();

            foreach (var attribute in characterResolved.Attributes)
            {
                attributes.Add(attribute.AttributeName);
            }
            characterReturn.Attributes = attributes;

            characterReturn.Hp = characterResolved.Hp;
            characterReturn.Stamina = characterResolved.Stamina;
            characterReturn.WearLimit = characterResolved.WearLimit;
            characterReturn.NatArmor = characterResolved.NatArmor;

            var skills = new Dictionary<string, int>();

            foreach (var skill in characterResolved.Skills)
            {
                skills.Add(skill.Key.SkillName, skill.Value);
            }
            characterReturn.Skills = skills;

            return characterReturn;
        }
    }
}
