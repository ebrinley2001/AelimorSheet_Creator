CREATE TABLE [dbo].[Skill] (
    [SkillId]     INT          IDENTITY (1, 1) NOT NULL,
    [SkillName]   VARCHAR (15) NOT NULL,
    [XpCost]      INT          NOT NULL,
    [StaminaCost] VARCHAR (5)  NULL,
    [Prereqs]     VARCHAR (15) NULL,
    [Limit]       VARCHAR (15) NULL,
    [CombatSkill] BIT          NULL,
    [ClassId]     INT          NULL,
    [AttributeId] INT          NULL,
    [Description] VARCHAR(500) NULL, 
    PRIMARY KEY CLUSTERED ([SkillId] ASC),
    FOREIGN KEY ([AttributeId]) REFERENCES [dbo].[Attribute] ([AttributeId]),
    FOREIGN KEY ([ClassId]) REFERENCES [dbo].[Class] ([ClassId])
);



