CREATE TABLE [dbo].[User] (
    [Username]        VARCHAR (20)   NOT NULL,
    [Email]           VARCHAR (200)  NOT NULL,
    [UserDescription] VARCHAR (1000) NULL,
    [AvatarURL]       VARCHAR (150)  NULL,
    [Salt]            VARCHAR (25)   NOT NULL,
    [PasswordHash]    VARCHAR (300)  NOT NULL,
    [LastLogin]       DATETIME       NULL,
    [LastRating]      INT            NULL,
    [NewListCooldown] DATETIME       NOT NULL,
    [Admin]           BIT            NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Username] ASC)
);

