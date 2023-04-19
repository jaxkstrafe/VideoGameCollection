CREATE TABLE [dbo].[UserList] (
    [ListID]      INT          IDENTITY (1, 1) NOT NULL,
    [ListName]    VARCHAR (25) NOT NULL,
    [Username]    VARCHAR (20) NOT NULL,
    [ListSize]    INT          NOT NULL,
    [VideoGameID] INT          NOT NULL,
    [Created]     DATETIME     NOT NULL,
    CONSTRAINT [PK_List] PRIMARY KEY CLUSTERED ([ListID] ASC),
    CONSTRAINT [FK_List_User] FOREIGN KEY ([Username]) REFERENCES [dbo].[User] ([Username]),
    CONSTRAINT [FK_List_VideoGame] FOREIGN KEY ([VideoGameID]) REFERENCES [dbo].[VideoGame] ([VideoGameID])
);

