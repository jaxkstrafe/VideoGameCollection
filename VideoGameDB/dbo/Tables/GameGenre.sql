CREATE TABLE [dbo].[GameGenre] (
    [VideoGameID] INT NOT NULL,
    [GenreID]     INT NOT NULL,
    CONSTRAINT [PK_GameGenre] PRIMARY KEY CLUSTERED ([VideoGameID] ASC, [GenreID] ASC),
    CONSTRAINT [FK_GameGenre_Genre] FOREIGN KEY ([GenreID]) REFERENCES [dbo].[Genre] ([GenreID]),
    CONSTRAINT [FK_GameGenre_VideoGame] FOREIGN KEY ([VideoGameID]) REFERENCES [dbo].[VideoGame] ([VideoGameID])
);

