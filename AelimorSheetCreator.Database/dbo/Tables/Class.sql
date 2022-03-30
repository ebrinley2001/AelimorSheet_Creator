CREATE TABLE [dbo].[Class] (
    [ClassId]     INT          IDENTITY (1, 1) NOT NULL,
    [ClassName]   VARCHAR (15) NOT NULL,
    [BaseStamina] INT          NULL,
    [WeaponProf]  VARCHAR (50) NULL,
    [Description] VARCHAR(500) NULL, 
    [Profession] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ClassId] ASC)
);



