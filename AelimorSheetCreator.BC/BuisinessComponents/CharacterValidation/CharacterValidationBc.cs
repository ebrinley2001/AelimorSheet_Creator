using AelimorSheetCreator.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AelimorSheetCreator.BC.BuisinessComponents.CharacterValidation
{
    public class CharacterValidationBc : ICharacterValidationBc
    {
        private int professionCount = 0;
        private int classCount = 0;

        private List<int> classIds = new List<int>();
        private List<int> attributeIds = new List<int>();
        private List<int> skillIds = new List<int>();

        private Regex limitPattern = new Regex(@"(?<amount>\d)(?<multiplier>\d)(?<dependantAttribute>\w)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public void Validate(Character characterValues)
        {
            if (characterValues.XpSpent! > characterValues.XpTotal && characterValues.Attributes.Count <= characterValues.Level.AvailAttrib) //Check the XpSpent vs XpTotal and the number of attributes you can buy vs the amount submitted
            {
                classCount = characterValues.Classes.Count; //Get Count of total classes
                foreach (var characterClass in characterValues.Classes) //Seperate classes and Professions
                {
                    if (characterClass.Profession)
                    {
                        professionCount += 1;
                        classCount -= 1;
                    }
                    classIds.Add(characterClass.ClassId); //Add ClassIds to list for use in skill validation
                }

                foreach (var characterAttribute in characterValues.Attributes) //Add AttributesIds to list for use in skill validation
                {
                    attributeIds.Add(characterAttribute.AttributeId);
                }
                foreach (var characterSkill in characterValues.Skills) //Add SkillIds to list for use in skill validation
                {
                    skillIds.Add(characterSkill.Value.SkillId);
                }

                if (professionCount + classCount <= characterValues.Level.AvailRoles && classCount != characterValues.Level.AvailRoles) //Makes sure the profession slot is used and that the total avalible roles arent bypassed
                {

                    foreach (var skill in characterValues.Skills)
                    { //Verifies that each skill with a ClassId, AttributeSkillId, Prereq, or RacialSkillId is met on the character
                        if ((skill.Value.ClassId == null || classIds.Contains((int)skill.Value.ClassId)) && (skill.Value.AttributeSkillId == null || attributeIds.Contains((int)skill.Value.AttributeSkillId)) && (skill.Value.RacialSkillId == null || characterValues.Race.RaceId == skill.Value.RacialSkillId) && (skill.Value.Prereqs == null || skillIds.Contains((int)skill.Value.Prereqs)))
                        {

                            if (skill.Value.Limit != null) //Check if there is a limit on the skill
                            {
                                var match = limitPattern.Match(skill.Value.Limit);
                                if (match.Success) //Verify pattern match
                                { //Deconstruct values
                                    string dependantAttribute = match.Groups["dependantAttribute"].Value;
                                    int amount = Int32.Parse(match.Groups["amount"].Value);
                                    int multiplier = Int32.Parse(match.Groups["multiplier"].Value);

                                    if (dependantAttribute == "T") //Check vs Total aka 11T or 1 total
                                    {
                                        if (skill.Key! <= amount)
                                        {
                                            throw new ArgumentException($"You cannot purchase {skill.Key} of {skill.Value.SkillName}. Your limit is {amount}: Total");
                                        }
                                    }
                                    else if (dependantAttribute == "L") //Check vs Level aka 13L or 1 per 3 levels 21L is 2 per 1 level
                                    {
                                        if (skill.Key! <= amount * multiplier / characterValues.Level.LevelNum)
                                        {
                                            throw new ArgumentException($"You cannot purchase {skill.Key} of {skill.Value.SkillName}. Your limit is {amount * multiplier / characterValues.Level.LevelNum}: Level");
                                        }
                                    }
                                    else if (dependantAttribute == "H") // Check vs health aka 13H 1 per every 3 hp
                                    {
                                        if (skill.Key! <= amount * multiplier / characterValues.Hp)
                                        {
                                            throw new ArgumentException($"You cannot purchase {skill.Key} of {skill.Value.SkillName}. Your limit is {amount * multiplier / characterValues.Hp}: Level");
                                        }
                                    }
                                }
                                else
                                {
                                    throw new ArgumentException($"Invalid REGEX limit expression {skill.Value.Limit}");
                                }
                            }
                        }
                        else
                        {
                            if (skill.Value.ClassId != null && !classIds.Contains((int)skill.Value.ClassId))
                            {
                                throw new ArgumentException($"You do not have the required class {skill.Value.ClassId} to purchase this skill {skill.Value.SkillName}");
                            }
                            else if (skill.Value.AttributeSkillId != null && !attributeIds.Contains((int)skill.Value.AttributeSkillId))
                            {
                                throw new ArgumentException($"You do not have the required attribute {skill.Value.AttributeSkillId} to purchase this skill {skill.Value.SkillName}");
                            }
                            else if (skill.Value.RacialSkillId != null && characterValues.Race.RaceId != skill.Value.RacialSkillId)
                            {
                                throw new ArgumentException($"You do not have the required race {skill.Value.RacialSkillId} to purchase this skill {skill.Value.SkillName}");
                            }
                            else if (skill.Value.Prereqs != null &&  !skillIds.Contains((int)skill.Value.Prereqs))
                            {
                                throw new ArgumentException($"You do not have the required prerequisite skill {skill.Value.Prereqs} to purchase this skill {skill.Value.SkillName}");
                            }
                        }
                    }
                }
                else
                {
                    throw new ArgumentException($"The amount of classes {characterValues.Classes.Count} you have selected is more than the amount avalible {characterValues.Level.AvailRoles}. Professions {professionCount}");
                }
            }
            else
            {
                if (characterValues.XpSpent > characterValues.XpTotal)
                {
                    throw new ArgumentException($"Your XpSpent {characterValues.XpSpent} is more than your XpTotal {characterValues.XpTotal}");
                }
                else if (characterValues.Attributes.Count <= characterValues.Level.AvailAttrib)
                {
                    throw new ArgumentException($"The amount of attributes {characterValues.Attributes.Count} you have selected is is more than the amount avalible {characterValues.Level.AvailAttrib}");
                }

            }
        }
    }
}
