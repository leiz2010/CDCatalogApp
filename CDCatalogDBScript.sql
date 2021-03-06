USE [master]
GO
/****** Object:  Database [CDCatalog]    Script Date: 6/15/2014 5:40:16 PM ******/
CREATE DATABASE [CDCatalog]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CDCatalog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CDCatalog.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CDCatalog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CDCatalog_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CDCatalog] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CDCatalog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CDCatalog] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CDCatalog] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CDCatalog] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CDCatalog] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CDCatalog] SET ARITHABORT OFF 
GO
ALTER DATABASE [CDCatalog] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CDCatalog] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CDCatalog] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CDCatalog] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CDCatalog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CDCatalog] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CDCatalog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CDCatalog] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CDCatalog] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CDCatalog] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CDCatalog] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CDCatalog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CDCatalog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CDCatalog] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CDCatalog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CDCatalog] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CDCatalog] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CDCatalog] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CDCatalog] SET RECOVERY FULL 
GO
ALTER DATABASE [CDCatalog] SET  MULTI_USER 
GO
ALTER DATABASE [CDCatalog] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CDCatalog] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CDCatalog] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CDCatalog] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CDCatalog', N'ON'
GO
USE [CDCatalog]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[AlbumID] [int] IDENTITY(1,1) NOT NULL,
	[AlbumYear] [int] NOT NULL,
	[ArtistID] [int] NOT NULL,
	[AlbumTitle] [nvarchar](50) NOT NULL,
	[AlbumRating] [int] NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Artist]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[ArtistID] [int] IDENTITY(1,1) NOT NULL,
	[ArtistName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[ArtistID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Genre]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Song]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song](
	[SongID] [int] IDENTITY(1,1) NOT NULL,
	[SongTitle] [nvarchar](50) NOT NULL,
	[ArtistID] [int] NOT NULL,
	[AlbumID] [int] NOT NULL,
	[SongTrackNumber] [int] NOT NULL,
	[GenreID] [int] NOT NULL,
	[SongTrackLength] [int] NOT NULL,
	[SongRating] [int] NOT NULL,
 CONSTRAINT [PK_Song_1] PRIMARY KEY CLUSTERED 
(
	[SongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[AlbumByGenre]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AlbumByGenre]
AS
SELECT DISTINCT dbo.Genre.GenreID, dbo.Genre.GenreName, dbo.Song.AlbumID
FROM            dbo.Genre INNER JOIN
                dbo.Song ON dbo.Genre.GenreID = dbo.Song.GenreID


GO
/****** Object:  View [dbo].[AlbumSongs]    Script Date: 6/15/2014 5:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AlbumSongs]
AS
SELECT Top 100 Percent dbo.Album.AlbumYear, 
	dbo.Album.AlbumTitle, 
	dbo.Song.SongTitle, 
	dbo.Song.ArtistID, 
	dbo.Song.SongTrackNumber, 
	dbo.Song.GenreID, 
	dbo.Song.SongTrackLength, 
	dbo.Song.SongRating, 
	dbo.Song.SongID, 
	dbo.Album.AlbumID
FROM            dbo.Album INNER JOIN
                dbo.Song ON dbo.Album.AlbumID = dbo.Song.AlbumID
ORDER BY AlbumTitle


GO
SET IDENTITY_INSERT [dbo].[Album] ON 

INSERT [dbo].[Album] ([AlbumID], [AlbumYear], [ArtistID], [AlbumTitle], [AlbumRating]) VALUES (16, 2013, 13, N'Prism', 5)
INSERT [dbo].[Album] ([AlbumID], [AlbumYear], [ArtistID], [AlbumTitle], [AlbumRating]) VALUES (17, 2008, 13, N'One of the Boys', 4)
SET IDENTITY_INSERT [dbo].[Album] OFF
SET IDENTITY_INSERT [dbo].[Artist] ON 

INSERT [dbo].[Artist] ([ArtistID], [ArtistName]) VALUES (13, N'Katy Perry')
SET IDENTITY_INSERT [dbo].[Artist] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (4, N'Pop')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Song] ON 

INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (12, N'Roar', 13, 16, 1, 4, 4, 4)
INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (13, N'Legendary Lovers', 13, 16, 2, 4, 4, 3)
INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (14, N'Birthday', 13, 16, 3, 4, 3, 3)
INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (15, N'Walking on Air', 13, 16, 4, 4, 4, 2)
INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (16, N'Unconditionally', 13, 16, 5, 4, 4, 5)
INSERT [dbo].[Song] ([SongID], [SongTitle], [ArtistID], [AlbumID], [SongTrackNumber], [GenreID], [SongTrackLength], [SongRating]) VALUES (17, N'I kissed a girl', 13, 17, 2, 4, 2, 5)
SET IDENTITY_INSERT [dbo].[Song] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Artist_Unique]    Script Date: 6/15/2014 5:40:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Artist_Unique] ON [dbo].[Artist]
(
	[ArtistName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Album_Artist] FOREIGN KEY([ArtistID])
REFERENCES [dbo].[Artist] ([ArtistID])
GO
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Album_Artist]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_Album] FOREIGN KEY([AlbumID])
REFERENCES [dbo].[Album] ([AlbumID])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_Album]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_Artist] FOREIGN KEY([ArtistID])
REFERENCES [dbo].[Artist] ([ArtistID])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_Artist]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Song_Genre] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genre] ([GenreID])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Song_Genre]
GO
USE [master]
GO
ALTER DATABASE [CDCatalog] SET  READ_WRITE 
GO
