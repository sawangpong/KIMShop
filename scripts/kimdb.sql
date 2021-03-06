USE [master]
GO
/****** Object:  Database [KIMDb]    Script Date: 05/10/2019 4:03:01 PM ******/
CREATE DATABASE [KIMDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KIMDb', FILENAME = N'D:\SQL_DATA\KIMDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 5120KB )
 LOG ON 
( NAME = N'KIMDb_log', FILENAME = N'D:\SQL_DATA\KIMDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 2048KB )
GO
ALTER DATABASE [KIMDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KIMDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KIMDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KIMDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KIMDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KIMDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KIMDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [KIMDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [KIMDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KIMDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KIMDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KIMDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KIMDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KIMDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KIMDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KIMDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KIMDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KIMDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KIMDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KIMDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KIMDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KIMDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KIMDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KIMDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KIMDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KIMDb] SET  MULTI_USER 
GO
ALTER DATABASE [KIMDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KIMDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KIMDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KIMDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KIMDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KIMDb] SET QUERY_STORE = OFF
GO
USE [KIMDb]
GO
/****** Object:  User [sawangpong]    Script Date: 05/10/2019 4:03:01 PM ******/
CREATE USER [sawangpong] FOR LOGIN [OLDMOON\sawangpong] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sawangpong]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sawangpong]
GO
/****** Object:  Table [dbo].[ProfileItem]    Script Date: 05/10/2019 4:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfileItem](
	[itemId] [int] NOT NULL,
	[ProfileId] [int] NOT NULL,
	[ItemNo] [varchar](50) NULL,
	[RawMat] [varchar](100) NULL,
	[Unit] [varchar](15) NULL,
	[Qty] [decimal](18, 2) NOT NULL,
	[Remark] [varchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemLog]    Script Date: 05/10/2019 4:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemLog](
	[LogId] [int] NOT NULL,
	[LoginName] [varchar](50) NOT NULL,
	[LoginDT] [datetime] NOT NULL,
	[LogoutDT] [datetime] NULL,
	[ComputerName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 05/10/2019 4:03:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](15) NULL,
	[IsActive] [bit] NOT NULL,
	[PermissionClass] [int] NOT NULL,
	[PermissionName] [varchar](50) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [KIMDb] SET  READ_WRITE 
GO
