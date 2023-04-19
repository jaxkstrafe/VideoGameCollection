CREATE TABLE [dbo].[Developer] (
    [DeveloperID] INT           IDENTITY (1, 1) NOT NULL,
    [DevName]     VARCHAR (200) NOT NULL,
    [DevAddress1] VARCHAR (200) NOT NULL,
    [DevAddress2] VARCHAR (150) NOT NULL,
    [DevCity]     VARCHAR (100) NOT NULL,
    [DevState]    VARCHAR (100) NOT NULL,
    [DevZip]      VARCHAR (50)  NOT NULL,
    [DevCountry]  VARCHAR (100) NOT NULL,
    [DevWebsite]  VARCHAR (200) NOT NULL,
    [DevPhone]    VARCHAR (50)  NOT NULL,
    [DevLogoURL]  VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Developer] PRIMARY KEY CLUSTERED ([DeveloperID] ASC)
);



