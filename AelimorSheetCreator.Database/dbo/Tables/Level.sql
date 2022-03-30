CREATE TABLE [dbo].[Level] (
    [LevelId]             INT IDENTITY (1, 1) NOT NULL,
    [LevelNum]            INT NOT NULL,
    [XpAmount]            INT NOT NULL,
    [BaseHp]              INT NULL,
    [BaseIncreaseStamina] INT NULL,
    [AvailAttrib]          INT NOT NULL,
    [AvailRoles]          INT NOT NULL,
    PRIMARY KEY CLUSTERED ([LevelId] ASC)
);



