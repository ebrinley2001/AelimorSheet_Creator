CREATE TABLE [dbo].[RacialSkill] (
    [RacialSkillId]   INT          IDENTITY (1, 1) NOT NULL,
    [RacialSkillName] VARCHAR (15) NOT NULL,
    [StaminaCost]     INT          NULL,
    [Limit]           VARCHAR (15) NULL,
    [XpCost]          INT          NULL,
    [RaceId]          INT          NULL,
    PRIMARY KEY CLUSTERED ([RacialSkillId] ASC),
    FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId])
);



