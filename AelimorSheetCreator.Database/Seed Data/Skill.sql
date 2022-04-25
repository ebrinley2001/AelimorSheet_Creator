set identity_insert Skill on;

/* General Skills*/
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (1, 'Vigor', 50, null, null, '31L', 0, null, 19, '+1 Base Hit Point', null, null, 1, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (2, 'Stamina', 100, null, null, '21L', 0, null, 6, '+1 Base Stamina Point', null, null, 0, 1, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (3, 'Diagnose', 40, null, null, '11T', 0, null, 7, 'Basic medical knowledge', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (4, 'First Aid', 75, null, 3, '11T', 0, null, 28, 'After a 10-Count, return a Dying character to 1 Hit Point.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (5, 'Surgery', 120, null, 5, '11T', 0, null, 34, 'After a 60-Count, a target character regains one half of their missing Hit Points, rounded up.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (6, 'Adventuring Principles', 175, null, null, '21T', 1, null, 13, 'Choose one of the following: Increase Armor Wear Limit by 5, Gain 3 Stamina, Gain 4 Hit Points or Gain 5 Mana in any Source provided by one of your Classes', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (7, 'Literacy', 100, null, null, null, 0, null, 18, 'Enables a character to read and write in a language of their choosing: Mage Script, Braz'' Kzekt, Sveitlarish, Ricash, Ooflada, Vekari', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (8, 'Spirit Expansion', 300, null, null, '11T', 0, null, null, 'Increases Spirit Presence by 1.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (9, 'Cat Nap', 100, null, null, '14L', 0, null, null, 'Once per Reset per buy, after a 5 minute nap, refresh all uses of any one User/Reset skill, other than Cat Nap.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (10, 'Resist Poison', 50, null, null, '12H', 1, null, 20, 'Once per Reset per buy, negate a non-damaging poison effect at will.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (11, 'Treasure Hunter', 100, null, null, '12L', 0, null, 12, 'Once per Game Day per buy, collect up to 5 Treasure Hunter bags.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (12, 'Weapon Proficiency', 250, null, null, null, 1, null, 13, 'Deal 1 extra point of damage with a declared length of blade, bludgeon or ranged weapon.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (13, 'Lucky Break', 75, null, null, '15L', 0, null, null, 'Once per Rejuvenation, negate any weapon or packet attack.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (14, 'Resist Magic', 300, '4', null, '11T', 1, null, 26, 'When used, negate a single, non-damaging spell effect at will.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (15, 'Strike + X', 0, 'X', null, '11T', 1, null, null, 'Deal X extra points of damage with any attack that already deals damage.', null, null, 0, 0, 0, 0);

/* Attribute Skills*/
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (16, 'Will to Live', 300, null, null, '11T', 0, null, null, 'Once per Rejuvenation, return from the end of Death Count to 1 Hit Point.', 1, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (17, 'Guardian', 200, null, null, '11T', 1, null, null, 'Gain access to the Master Parry skill but it can only be used to protect others, not yourself.', 16, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (18, 'Unyielding Flesh', 350, null, null, '11T', 0, null, null, 'Reduce the damage from poisons by half, rounded down.', 20, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (19, 'One with Nature', 250, null, null, '11T', 0, null, null, 'Whenever a character is near or touching the element they are attuned to, they passively regain X MP of that Source per minute, where X = double their character level.', 17, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (20, 'Bloodlust', 350, null, null, '11T', 1, null, null, 'Whenever this character Incapacitates another creature through combat, they regain 5 Stamin Points.', 9, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (21, 'Essence Transfer', 50, null, null, '11T', 0, null, null, 'This character may use Heal Wounds X, expending X Hit Points.', 25, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (22, 'Recover', 400, null, null, '11T', 0, null, null, 'After 1 minute of intense Meditation, restore X Hit Points, where X is double the user''s character level or 5, whichever is greater but this cannot result in the caracter having more than one half of their Base HP.', 19, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (23, 'Empath', 150, null, null, '11T', 0, null, null, 'The character can Identify and Mental effects active on a target character after 5 seconds of roleplay.', 11, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (24, 'Unchakeable Courage', 250, null, null, '11T', 1, null, null, 'The character is immune to Fear and Terror effects.', 24, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (25, 'First Strike', 150, null, null, '11T', 1, null, null, 'This character''s first attack in every combat encounter deals X additional points of damage, where X is double their character level, as long at the first attack is a damaging one.', 10, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (26, 'Force Over Form', 200, null, null, '11T', 0, null, null, 'This character may treat Bladed weapons as Bludgeons at will, though not both at the same time.', 21, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (27, 'Master Craftsman', 400, null, null, '11T', 0, null, null, '1st Buy: Gain one Craft Level in each of the seven crafts. 2nd Buy: You may produce items whose level exceeds your skill in crafting. 3rd Buy: If a recipe calls for multiple copies of the same Component, you may have a single Component count as two.', 3, null, 0, 0, 0, 0); /* Fix Attribute */
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (28, 'Motivational Healer', 400, null, null, '11T', 0, null, null, 'Spend 1 60-Count of roleplay trying to encourage a Dying or Dead character to stay alive. If the 60 count is completed before the end of the target''s Death Count, they regain consciousness and 1 Hit Point.', 4, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (29, 'Pacifist', 150, null, null, '11T', 0, null, null, 'This character is immune to Rage, Psychosis and Taunt, but cannot buy or user Berserker Rage.', 28, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (30, 'Devotion', 200, null, null, '11T', 1, null, null, 'At the start of each event, choose a character. For the remainder of the event, while you are within strikin gdistance of the chosen charater or anything attacking them, you may throw yourself in the way of an incoming attack.', 15, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (31, 'Blur', 150, null, null, '11T', 1, null, null, 'Once per Reset per buy, become immune to weapon and packet attacks while moving for 5 seconds.', 22, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (32, 'Collusion', 100, null, null, '11T', 0, null, null, 'Once per Reset per buy, choose up to X other characters, where X is one half of the user''s character level, rounded up. Those characters gain 1 use of Pickpocket or Plant, chosen by the user, that must be used immediately.', 14, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (33, 'Expanded Mind', 0, null, null, '11T', 0, null, null, 'Gain attunements at one per five character levels but attuning to a Source does not alter the limitations of other Sources. All Affinities grant an additional 2 XP discount per MP bought.', 23, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (34, 'Well Prepared', 350, null, null, '11T', 0, null, null, 'Prior to each event, the character has 10 production levels to spend on any commonly available items in the Production Section of the Rulebook.', 13, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (35, 'Vigilant', 100, null, null, '11T', 0, null, null, 'Once per Reset per buy, react to an In Game effect you were not Aware of as if you were.', 12, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (36, 'All Out', 200, '2', null, '11T', 1, null, null, 'When used, deal an extra strike when dealing a Strike Flurry or Strike Surge.', 27, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (37, 'Unfazed', 200, '4', null, '11T', 0, null, null, 'When used, negate a single Mental effect.', 29, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (38, 'Dual Cast', 400, '4', null, '11T', 0, null, null, 'When used, a Mage may duplicate a spell packet or wave and cast the copy from their off-hand while only spending the MP to cast the spell once.', 2, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (39, 'Disengage', 265, '3', null, '11T', 1, null, null, 'Using this skill adds Crushing damage to a strike with any weapon.', 34, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (40, 'Resilient', 300, '5', null, '11T', 1, null, null, 'When used, gain X temporary Hit Points while Concentrating, where X is the user''s character level or 5, whichever is greater.', 6, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (41, 'Everlasting', 225, '5', null, '11T', 0, null, null, 'When used, restart the timer of any effect active on this skill''s user. An effect can only be extended 4 times, for a total of 5 timers.', 26, null, 0, 0, 0, 0);

/* Racial Skills*/

insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (42, 'Rally', 75, null, null, '11L', 1, null, null, 'Once per Reset per buy, a Human can give any nearby characters of their choice the ability to shake off a Status, Mental or Forceful effect.', null, 1, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (43, 'Strong Stomach', 75, null, null, '31T', 0, null, null, '1st Buy: When determining their level of Intoxication, double the Dwarf''s Hit Points. If they would begin Dying due to an overdose of Liquor or Ale, they fall Asleep instead. 2nd Buy: Ingested damaging poisons deal half damage, rounded down. 3rd Buy: Increase the Addiction Level of all Addictives by 1.', null, 2, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (44, 'Wary', 50, null, null, '11L', 1, null, null, 'Once per Reset per buy, negate a Sleep, Blind, Lights Out, Knockout or Taunt effect from any origin.', null, 3, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (45, 'Lucky Dodge', 75, null, null, '11L', 0, null, null, 'Once per Reset per buy, a Halfling may negate any weapon of packet attack.', null, 4, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (46, 'Natural Swordsman', 350, null, null, '11T', 1, null, null, 'When buying this skill, choose either Disengage or Master Parry. This skill can only be used with a bladed weapon.', null, 5, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (47, 'Playing Possum', 100, null, null, '11T', 0, null, null, 'A Goblin Playing Possum may lie when Diagnosed, responding with Asleep, Unconscious, Dying or Dead as they desire. They may also choose to take 2 damage directly to HP rather than a Killing Blow.', null, 6, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (48, 'Refuse', 200, '4', null, '11T', 1, null, null, 'When used, an Orc may negate a Mental effect.', null, 7, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (49, 'Naturally Muscular', 600, null, null, '11T', 0, null, null, 'This skill counts as a buy of Strength and no game effect can cause them to lose Strengths.', null, 8, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (50, 'Artificial Skin', 50, null, null, '21L', 0, null, null, 'Gain 1 Hit Point and 1 point of Natural Armor.', null, 9, 1, 0, 0, 1);
/*insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (51, 'Fill - Not sure how you are handling Ferkin'; */
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (52, 'Spirit Manifestation', 50, null, null, '11L', 1, null, null, 'Once per Reset per buy, do one of the following: Manifest a physical embodiment of their humanoid form while transformed as equipment. This manifestation may then wield the transformed Nauvoo. Or, create an additional piece of equipment when transforming.', null, 11, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (53, 'Endless Curiosity', 50, null, null, '11T', 0, null, null, 'When bought, this skill gives the Gnome an additional Attribute, seperate from the normal limit of 3. This attribute does not discount skills, only unlocking another rare skill and providing the RP benefits.', null, 12, 0, 0, 0, 0);
/*insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (54, 'Fill - Not sure how you are handling Folifolk'; */
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (55, 'Mysticism', 100, null, null, '13L', 0, null, null, 'Once per Reset per buy, use Flash of Insight with X effective Lore levels toward a magic-related question, where X is double the Mediolyn''s character level.', null, 14, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (56, 'Bliss', 100, null, null, '13L', 0, null, null, 'Once per Reset per buy, become immune to all Mental effects for 10 minutes.', null, 15, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (57, 'Foresight', 100, null, null,  '13L', 0, null, null, 'Once per Reset per buy, ask Out of Game whether a character would react well, poorly or indifferently to a given question or statement.', null, 16, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (58, 'Into the Trees', 75, null, null, '12L', 0, null, null, 'Once per Reset per buy, if in an encounter in a natural environment that has a Flee Point, the Eipah may attempt to flee the encounter without reaching the Flee Point. They must escape any engagement with hostile characters in the encounter for at least 10 seconds.', null, 17, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (59, 'Danger Sense', 100, null, null, '13L', 0, null, null, 'Once per Reset per buy, ask Plot directly how difficult an encounter will be, prior to embarking on it.', null, 18, 0, 0, 0, 0);



/* Class Skills*/

/*Fighter*/
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (60, 'Strength', 700, null, null, '11T', 0, 1, 21, 'Deal X additional points of damage with all melee or thrown weapon attacks, where X is one half the user''s character level rounded up or 2, whichever is greater.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (61, 'Armor Training', 125, null, null, '21T', 1, 1, 22, 'For each buy, increase the Fighter''s Armor Wear Limit by 5 points.', null, null, 0, 0, 5, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (62, 'Warrior''s Spirit', 450, null, null, null, 0, 1, 6, 'You may spend 10 Staminia and increase your melee and thrown weapon damage by 1. So long as you do not recover that 10 Stamina, the damage remains. You may do this with your entire Stamina Pool but not with bonus or temporary Stamina points.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (63, 'Sunder', 75, '1', null, '11T', 1, 1, 21, 'When used, deal an extra X points of damage with a weapon attack, where X is one half of the user''s character level, rounded up, or 3, whichever is greater.', null, null,  0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (64, 'Crushing Strike', 250, '3', null, '11T', 1, 1, 9, 'When used, add Crushing damage to a strike with a Bludgeon weapon.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (65, 'Overpower', 200, '4', null, '11T', 0, 1, 9, 'When used, deal a Numb effect with a melee weapon. Great & largers weapons deal this effect for 2 Stamina.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (66, 'Parry', 350, '3', null, '11T', 1, 1, 34, 'When used, nagete the damage of any Weapon, Packet or Wave attack that deals X or less damage, where X = 10 * character level or X = 10 * Strength Check, whichever is higher. You must be Aware of the attack to Parry it.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (67, 'Critical Strike', 350, '4', null, '11T', 1, 1, 12, 'When used, double the damage dealt by the next weapon attack. Other modifiers are added up before doubleing. Great & larger weapons deal this effect for 3 Stamina.', null, null, 0, 0, 0, 0);
insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description, AttributeSkillId, RacialSkillId, Hp, Stamina, WearLimit, NatArmor) values (68, 'Pommel Strke', 300, '4', 64, '11T', 0, 1, 9, 'Crushing Strike Knockback. Great & larger weapons deal this effect for 2 Stamina.', null, null, 0, 0, 0, 0);

/*Rogue*/



set identity_insert Skill off;