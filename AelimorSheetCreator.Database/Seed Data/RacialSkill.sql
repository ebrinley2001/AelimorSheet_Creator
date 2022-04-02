set identity_insert RacialSkill on;

insert into RacialSkill (RacialSkillId, RacialSkillName, StaminaCost, Limit, XpCost, RaceId, Description, CombatSkill) values (1, 'Rally', 0, '1/L', 75, 1, 'Once per Reset per buy, a Human can give any nearby characters of their choice the strength and willpower to shake off a Status, Mental or Forceful effect. “We can’t give up now! Rally! Break Forceful!” [Audible, Mental]', 1);

set identity_insert RacialSkill off;