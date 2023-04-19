CREATE TABLE [dbo].[Publisher] (
    [PublisherID]       INT           IDENTITY (1, 1) NOT NULL,
    [PublisherName]     VARCHAR (200) NOT NULL,
    [PublisherAddress1] VARCHAR (200) NOT NULL,
    [PublisherAddress2] VARCHAR (150) NOT NULL,
    [PublisherCity]     VARCHAR (100) NOT NULL,
    [PublisherState]    VARCHAR (100) NOT NULL,
    [PublisherZip]      VARCHAR (50)  NOT NULL,
    [PublisherCountry]  VARCHAR (100) NOT NULL,
    [PublisherWebsite]  VARCHAR (200) NOT NULL,
    [PublisherPhone]    VARCHAR (50)  NOT NULL,
    [PublisherLogoURL]  VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED ([PublisherID] ASC)
);



