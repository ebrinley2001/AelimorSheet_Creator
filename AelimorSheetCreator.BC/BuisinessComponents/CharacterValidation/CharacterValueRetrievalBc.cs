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

            foreach (var attributeId in values.AttributeIds)
            {
                character.Attributes.Add(await _attributeBc.GetByIdAsync(attributeId));
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
                var skill = await _skillBc.GetByIdAsync(skillId.Value);
                character.Skills.Add(skillId.Key, skill);

                character.Hp += skill.Hp * skillId.Key;
                character.Stamina += skill.Stamina * skillId.Key;
                character.WearLimit += skill.WearLimit * skillId.Key;
                character.NatArmor += skill.NatArmor * skillId.Key;

                if (skill.AttributeId != null && values.AttributeIds.Contains((int)skill.AttributeId) && skill.AttributeSkillId == null)
                {
                    double discountedSkill = (double)skill.XpCost * .80;
                    character.XpSpent += (int)discountedSkill;
                }
                else if (skill.AttributeId != null && !values.AttributeIds.Contains((int)skill.AttributeId))
                {
                    character.XpSpent += skill.XpCost;
                }
            }

            return character;
        }
    }
}
