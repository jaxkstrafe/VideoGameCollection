CREATE TABLE [dbo].[GamePlatform] (
    [VideoGameID] INT NOT NULL,
    [PlatformID]  INT NOT NULL,
    CONSTRAINT [PK_GamePlatform] PRIMARY KEY CLUSTERED ([VideoGameID] ASC, [PlatformID] ASC),
    CONSTRAINT [FK_GamePlatform_Platform] FOREIGN KEY ([PlatformID]) REFERENCES [dbo].[Platform] ([PlatformID]),
    CONSTRAINT [FK_GamePlatform_VideoGame] FOREIGN KEY ([VideoGameID]) REFERENCES [dbo].[VideoGame] ([VideoGameID])
);

