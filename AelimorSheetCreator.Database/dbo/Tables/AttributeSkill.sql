﻿CREATE TABLE [dbo].[AttributeSkill] (
    [AttributeSkillId]   INT          IDENTITY (1, 1) NOT NULL,
    [AttributeSkillName] VARCHAR (15) NOT NULL,
    [XpCost]             INT          NULL,
    [AttributeId]        INT          NULL,
    [StaminaCost]        INT          NULL,
    PRIMARY KEY CLUSTERED ([AttributeSkillId] ASC),
    FOREIGN KEY ([AttributeId]) REFERENCES [dbo].[Attribute] ([AttributeId])
);


