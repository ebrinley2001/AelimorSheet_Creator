﻿using AelimorSheetCreator.Models;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC.BuisinessComponents.CharacterValidation
{
    public class BaseValueRetrievalBc
    {
        private readonly ILevelBc _levelBc;
        private readonly IRaceBc _raceBc;
        private readonly IClassBc _classBc;
        private readonly ISkillBc _skillBc;
        private readonly IAttributeBc _attributeBc;

        public BaseValueRetrievalBc(ILevelBc levelBc, IRaceBc raceBc, IClassBc classBc, ISkillBc skillBc, IAttributeBc attribute)
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

                if (values.AttributeIds.Contains(skill.AttributeId))
                {
                    double discountedSkill = (double)skill.XpCost * .90;
                    character.XpSpent += (int)discountedSkill;
                }
                else if (!values.AttributeIds.Contains(skill.AttributeId))
                {
                    character.XpSpent += skill.XpCost;
                }
            }

            return character;
        }
    }
}
