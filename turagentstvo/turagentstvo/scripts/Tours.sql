USE [master]
GO
/****** Object:  Database [ToursMD]    Script Date: 12/13/2022 8:34:55 PM ******/
CREATE DATABASE [ToursMD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ToursMD', FILENAME = N'C:\базы\ToursMD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ToursMD_log', FILENAME = N'C:\базы\ToursMD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ToursMD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ToursMD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ToursMD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ToursMD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ToursMD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ToursMD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ToursMD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ToursMD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ToursMD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ToursMD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ToursMD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ToursMD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ToursMD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ToursMD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ToursMD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ToursMD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ToursMD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ToursMD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ToursMD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ToursMD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ToursMD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ToursMD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ToursMD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ToursMD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ToursMD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ToursMD] SET  MULTI_USER 
GO
ALTER DATABASE [ToursMD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ToursMD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ToursMD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ToursMD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ToursMD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ToursMD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ToursMD] SET QUERY_STORE = OFF
GO
USE [ToursMD]
GO
/****** Object:  Table [dbo].[register]    Script Date: 12/13/2022 8:34:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[login_user] [varchar](50) NOT NULL,
	[password_user] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test_db]    Script Date: 12/13/2022 8:34:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_db](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_of] [varchar](50) NOT NULL,
	[count_of] [int] NOT NULL,
	[postavchik] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[register] ON 

INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (2, N'usr', N'54321')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (3, N'ivan', N'??????')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (4, N'pasha', N'12345')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (6, N'test', N'test')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (7, N'maneger', N'123456789')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (8, N'1111', N'1111')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (9, N'666', N'12345')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (11, N'chmonya', N'123')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (12, N'sasha', N'123')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (13, N'petya', N'12345')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (14, N'dimaaaaa', N'12345')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (16, N'senya', N'123')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (5, N'usser', N'33333')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (10, N'den', N'123')
INSERT [dbo].[register] ([id_user], [login_user], [password_user]) VALUES (15, N'klop', N'123')
SET IDENTITY_INSERT [dbo].[register] OFF
GO
SET IDENTITY_INSERT [dbo].[test_db] ON 

INSERT [dbo].[test_db] ([id], [type_of], [count_of], [postavchik], [price]) VALUES (1, N'Milk', 150, N'Post #1', 3500)
SET IDENTITY_INSERT [dbo].[test_db] OFF
GO
USE [master]
GO
ALTER DATABASE [ToursMD] SET  READ_WRITE 
GO
