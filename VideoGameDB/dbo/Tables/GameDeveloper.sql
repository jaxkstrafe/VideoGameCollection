CREATE TABLE [dbo].[GameDeveloper] (
    [VideoGameID] INT NOT NULL,
    [DeveloperID] INT NOT NULL,
    CONSTRAINT [PK_GameDeveloper] PRIMARY KEY CLUSTERED ([VideoGameID] ASC, [DeveloperID] ASC),
    CONSTRAINT [FK_GameDeveloper_Developer] FOREIGN KEY ([DeveloperID]) REFERENCES [dbo].[Developer] ([DeveloperID]),
    CONSTRAINT [FK_GameDeveloper_VideoGame] FOREIGN KEY ([VideoGameID]) REFERENCES [dbo].[VideoGame] ([VideoGameID])
);

