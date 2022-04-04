set identity_insert Skill on;

insert into Skill (SkillId, SkillName, XpCost, StaminaCost, Prereqs, Limit, CombatSkill, ClassId, AttributeId, Description) values (1, 'Vigor', 50, 0, null, '3/L', 0, null, 19, '+1 Base Hit Point');

set identity_insert Skill off;