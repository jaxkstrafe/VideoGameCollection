CREATE TABLE [dbo].[Platform] (
    [PlatformID]   INT           IDENTITY (1, 1) NOT NULL,
    [PlatformName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Platform] PRIMARY KEY CLUSTERED ([PlatformID] ASC)
);



