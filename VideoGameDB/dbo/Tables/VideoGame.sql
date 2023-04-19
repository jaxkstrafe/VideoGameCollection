CREATE TABLE [dbo].[VideoGame] (
    [VideoGameID]   INT            IDENTITY (1, 1) NOT NULL,
    [GameTitle]     VARCHAR (100)  NOT NULL,
    [ReleaseDate]   DATETIME       NOT NULL,
    [Price]         DECIMAL (7, 2) NOT NULL,
    [ESRBID]        INT            NOT NULL,
    [CriticAverage] DECIMAL (3, 1) NOT NULL,
    [UserAverage]   DECIMAL (3, 1) NOT NULL,
    [GameImageURL]  VARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_VideoGame_1] PRIMARY KEY CLUSTERED ([VideoGameID] ASC)
);



