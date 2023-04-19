CREATE TABLE [dbo].[Genre] (
    [GenreID]   INT           IDENTITY (1, 1) NOT NULL,
    [GenreName] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED ([GenreID] ASC)
);



