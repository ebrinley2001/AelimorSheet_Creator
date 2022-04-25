CREATE TABLE [dbo].[Class] (
    [ClassId]     INT          IDENTITY (1, 1) NOT NULL,
    [ClassName]   VARCHAR (30) NOT NULL,
    [BaseStamina] INT          NULL,
    [WeaponProf]  VARCHAR (50) NULL,
    [Description] VARCHAR(1000) NULL, 
    [Profession] BIT NOT NULL, 
    [BaseHp] INT NULL, 
    [BaseWearLimit] INT NULL, 
    [BaseNatArmor] INT NULL, 
    PRIMARY KEY CLUSTERED ([ClassId] ASC)
);



