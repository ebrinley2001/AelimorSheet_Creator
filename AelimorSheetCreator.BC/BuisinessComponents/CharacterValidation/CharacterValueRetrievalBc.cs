using AelimorSheetCreator.Models;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC.BuisinessComponents.CharacterValidation
{
    public class CharacterValueRetrievalBc : ICharacterValueRetrievalBc
    {
        private readonly ILevelBc _levelBc;
        private readonly IRaceBc _raceBc;
        private readonly IClassBc _classBc;
        private readonly ISkillBc _skillBc;
        private readonly IAttributeBc _attributeBc;

        public CharacterValueRetrievalBc(ILevelBc levelBc, IRaceBc raceBc, IClassBc classBc, ISkillBc skillBc, IAttributeBc attribute)
        {
            _levelBc = levelBc;
            _raceBc = raceBc;
            _classBc = classBc;
            _skillBc = skillBc;
            _attributeBc = attribute;
        }

        public async Task<Character> RetrieveCharacterValues(CharacterValues values)
        {
            Character character = new Character();

            Level characterLevel = await _levelBc.GetLevelByXp(values.XpTotal);

            character.CharacterName = values.CharacterName;
            character.XpTotal = values.XpTotal;
            character.Race = await _raceBc.GetByIdAsync(values.RaceId);
            character.Level = characterLevel;

            character.Hp = characterLevel.BaseHp;
            character.Stamina = characterLevel.BaseStamina;

            foreach (var attributeId in values.AttributeIds)
            {
                var attribute = await _attributeBc.GetByIdAsync(attributeId);
                character.Attributes.Add(attribute);
            }

            foreach (var classId in values.ClassIds)
            {
                var addClass = await _classBc.GetByIdAsync(classId);
                character.Classes.Add(addClass);
                character.Hp += addClass.BaseHp;
                character.Stamina += addClass.BaseStamina;
                character.WearLimit += addClass.BaseWearLimit;
                character.NatArmor += addClass.BaseNatArmor;
            }

            foreach (var skillId in values.SkillIds)
            {
                Skill skill = await _skillBc.GetByIdAsync(skillId.Key);
                character.Skills.Add(skill, skillId.Value);

                character.Hp += skill.Hp * skillId.Value;
                character.Stamina += skill.Stamina * skillId.Value;
                character.WearLimit += skill.WearLimit * skillId.Value;
                character.NatArmor += skill.NatArmor * skillId.Value;

                if (skill.AttributeId != null && values.AttributeIds.Contains((int)skill.AttributeId) && skill.AttributeSkillId == null)
                {
                    double discountedSkill = (double)skill.XpCost * .80;
                    character.XpSpent += (int)discountedSkill * skillId.Value;
                }
                else
                {
                    character.XpSpent += skill.XpCost * skillId.Value;
                }
            }

            return character;
        }
    }
}
