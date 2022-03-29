CREATE TABLE [dbo].[Class] (
    [ClassId]     INT          IDENTITY (1, 1) NOT NULL,
    [ClassName]   VARCHAR (15) NOT NULL,
    [BaseStamina] INT          NULL,
    [WeaponProf]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ClassId] ASC)
);



