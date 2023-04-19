CREATE TABLE [dbo].[GamePublisher] (
    [VideoGameID] INT NOT NULL,
    [PublisherID] INT NOT NULL,
    CONSTRAINT [PK_GamePublisher] PRIMARY KEY CLUSTERED ([VideoGameID] ASC, [PublisherID] ASC),
    CONSTRAINT [FK_GamePublisher_Publisher] FOREIGN KEY ([PublisherID]) REFERENCES [dbo].[Publisher] ([PublisherID]),
    CONSTRAINT [FK_GamePublisher_VideoGame] FOREIGN KEY ([VideoGameID]) REFERENCES [dbo].[VideoGame] ([VideoGameID])
);

