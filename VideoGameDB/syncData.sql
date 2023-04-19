/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [dbo].[ESRB] ON 
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (1, N'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/ESRB_Everyone.svg/322px-ESRB_Everyone.svg.png?20110324231902')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (2, N'https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/ESRB_Everyone_10%2B.svg/322px-ESRB_Everyone_10%2B.svg.png?20110216153642')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (3, N'https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/ESRB_Teen.svg/322px-ESRB_Teen.svg.png?20110324232512')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (4, N'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/ESRB_Mature_17%2B.svg/322px-ESRB_Mature_17%2B.svg.png?20110324232959')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (5, N'https://upload.wikimedia.org/wikipedia/commons/2/2b/ESRB_Adults_Only_18%2B.svg')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (6, N'https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/ESRB_RP.svg/322px-ESRB_RP.svg.png?20110324235707')
GO
INSERT [dbo].[ESRB] ([ESRBID], [ESRBImageURL]) VALUES (8, N'')
GO
SET IDENTITY_INSERT [dbo].[ESRB] OFF
GO
SET IDENTITY_INSERT [dbo].[VideoGame] ON 
GO
INSERT [dbo].[VideoGame] ([VideoGameID], [GameTitle], [ReleaseDate], [Price], [ESRBID], [CriticAverage], [UserAverage], [GameImageURL]) VALUES (1, N'Star Wars BattleFront(2004)', CAST(N'2004-09-21T00:00:00.000' AS DateTime), CAST(9.99 AS Decimal(7, 2)), 2, CAST(8.0 AS Decimal(3, 1)), CAST(9.0 AS Decimal(3, 1)), N'https://upload.wikimedia.org/wikipedia/en/5/5b/Star_wars_battlefront_cover_art.jpg')
GO
INSERT [dbo].[VideoGame] ([VideoGameID], [GameTitle], [ReleaseDate], [Price], [ESRBID], [CriticAverage], [UserAverage], [GameImageURL]) VALUES (2, N'Minecraft', CAST(N'2011-11-18T00:00:00.000' AS DateTime), CAST(29.99 AS Decimal(7, 2)), 3, CAST(7.0 AS Decimal(3, 1)), CAST(9.0 AS Decimal(3, 1)), N'https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png')
GO
INSERT [dbo].[VideoGame] ([VideoGameID], [GameTitle], [ReleaseDate], [Price], [ESRBID], [CriticAverage], [UserAverage], [GameImageURL]) VALUES (3, N'Hogwarts Legacy', CAST(N'2023-02-10T00:00:00.000' AS DateTime), CAST(59.99 AS Decimal(7, 2)), 1, CAST(8.0 AS Decimal(3, 1)), CAST(9.0 AS Decimal(3, 1)), N'https://upload.wikimedia.org/wikipedia/en/7/7c/Hogwarts-Legacy-cover.jpg')
GO
INSERT [dbo].[VideoGame] ([VideoGameID], [GameTitle], [ReleaseDate], [Price], [ESRBID], [CriticAverage], [UserAverage], [GameImageURL]) VALUES (1002, N'Minecraft', CAST(N'2011-11-08T00:00:00.000' AS DateTime), CAST(29.99 AS Decimal(7, 2)), 0, CAST(8.0 AS Decimal(3, 1)), CAST(9.0 AS Decimal(3, 1)), N'https://thumbs.dreamstime.com/b/minecraft-logo-online-game-dirt-block-illustrations-concept-design-isolated-186775550.jpg')
GO
INSERT [dbo].[VideoGame] ([VideoGameID], [GameTitle], [ReleaseDate], [Price], [ESRBID], [CriticAverage], [UserAverage], [GameImageURL]) VALUES (1003, N'Fortnite', CAST(N'2017-07-21T00:00:00.000' AS DateTime), CAST(0.00 AS Decimal(7, 2)), 0, CAST(7.0 AS Decimal(3, 1)), CAST(8.0 AS Decimal(3, 1)), N'https://healthnewshub.org/wp-content/uploads/2018/03/NewsFortnite.jpg')
GO
SET IDENTITY_INSERT [dbo].[VideoGame] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (1, N'Action')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (2, N'Adventure')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (3, N'Role-playing')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (4, N'Strategy')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (5, N'Puzzle')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (6, N'Sports')
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (7, N'Shooter')
GO
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
INSERT [dbo].[GameGenre] ([VideoGameID], [GenreID]) VALUES (1002, 2)
GO
INSERT [dbo].[GameGenre] ([VideoGameID], [GenreID]) VALUES (1003, 1)
GO
INSERT [dbo].[GameGenre] ([VideoGameID], [GenreID]) VALUES (1003, 7)
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 
GO
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherAddress1], [PublisherAddress2], [PublisherCity], [PublisherState], [PublisherZip], [PublisherCountry], [PublisherWebsite], [PublisherPhone], [PublisherLogoURL]) VALUES (1, N'Nintendo', N'11-1 Hokotate-cho, Kamitoba, Minami-ku, Kyoto, Japan', N'4600 150th Ave. NE Redmond, WA', N'Kyoto', N'Japan', N'601-8501', N'Japan', N'https://www.nintendo.com/', N'1-800-255-3700', N'https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Nintendo.svg/1920px-Nintendo.svg.png')
GO
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherAddress1], [PublisherAddress2], [PublisherCity], [PublisherState], [PublisherZip], [PublisherCountry], [PublisherWebsite], [PublisherPhone], [PublisherLogoURL]) VALUES (2, N'Xbox Game Studios', N'1 Microsoft Way, Redmond, WA', N'None', N'Redmond', N'Washington', N'98052', N'United States', N'https://www.xbox.com/en-US/xbox-game-studios', N'1-800-469-9269', N'https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Xbox_Game_Studios.svg/330px-Xbox_Game_Studios.svg.png')
GO
INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublisherAddress1], [PublisherAddress2], [PublisherCity], [PublisherState], [PublisherZip], [PublisherCountry], [PublisherWebsite], [PublisherPhone], [PublisherLogoURL]) VALUES (3, N'Epic Games', N'620 Crossroads Blvd. , Cary, NC', N'None', N'Cary', N'North Carolina', N'27518', N'United States', N'https://store.epicgames.com/en-US/', N'+1 919 854 0070', N'https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Epic_Games_logo.svg/1764px-Epic_Games_logo.svg.png')
GO
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[Platform] ON 
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (1, N'PlayStation 5 ')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (2, N'Xbox One')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (3, N'PC')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (4, N'Nintendo Switch')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (5, N'Xbox 360')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (6, N'PlayStation 4')
GO
INSERT [dbo].[Platform] ([PlatformID], [PlatformName]) VALUES (1002, N'All Platforms')
GO
SET IDENTITY_INSERT [dbo].[Platform] OFF
GO
SET IDENTITY_INSERT [dbo].[Developer] ON 
GO
INSERT [dbo].[Developer] ([DeveloperID], [DevName], [DevAddress1], [DevAddress2], [DevCity], [DevState], [DevZip], [DevCountry], [DevWebsite], [DevPhone], [DevLogoURL]) VALUES (1, N'TreyArch', N'3420 Ocean Park Blvd, Santa Monica, CA', N'5454 Beethoven St, Playa Vista, CA', N'Playa Vista', N'California', N'90066', N'United States', N'https://www.treyarch.com/', N'310-255-2000', N'https://yt3.googleusercontent.com/ytc/AL5GRJW5wDxRYtWJBKWXq0d-klF4aoHG-jKXlqMeTB70sw=s900-c-k-c0x00ffffff-no-rj')
GO
INSERT [dbo].[Developer] ([DeveloperID], [DevName], [DevAddress1], [DevAddress2], [DevCity], [DevState], [DevZip], [DevCountry], [DevWebsite], [DevPhone], [DevLogoURL]) VALUES (2, N'Mojang', N'Söder Mälarstrand 43, Stockholm, Sweden', N'None', N'Stockholm', N'Stockholm', N'104 65', N'Sweden', N'https://www.minecraft.net/en-us', N'(425) 882-8080', N'https://1000logos.net/wp-content/uploads/2021/12/Mojang-logo.jpg')
GO
INSERT [dbo].[Developer] ([DeveloperID], [DevName], [DevAddress1], [DevAddress2], [DevCity], [DevState], [DevZip], [DevCountry], [DevWebsite], [DevPhone], [DevLogoURL]) VALUES (3, N'Epic Games', N'620 Crossroads Blvd. , Cary, NC', N'None', N'Cary', N'North Carolina', N'27518', N'United States', N'https://store.epicgames.com/en-US/', N'+1 919 854 0070', N'https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Epic_Games_logo.svg/1764px-Epic_Games_logo.svg.png')
GO
SET IDENTITY_INSERT [dbo].[Developer] OFF
GO


