USE [master]
GO

/****** Object:  Database [Armor]    Script Date: 01/26/2012 00:45:51 ******/
CREATE DATABASE [Armor] ON  PRIMARY 
( NAME = N'Armor', FILENAME = N'C:\MSSQL\DATA\Armor.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Armor_log', FILENAME = N'C:\MSSQL\DATA\Armor_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Armor] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Armor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Armor] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Armor] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Armor] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Armor] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Armor] SET ARITHABORT OFF 
GO

ALTER DATABASE [Armor] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Armor] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Armor] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Armor] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Armor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Armor] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Armor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Armor] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Armor] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Armor] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Armor] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Armor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Armor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Armor] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Armor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Armor] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Armor] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Armor] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Armor] SET  READ_WRITE 
GO

ALTER DATABASE [Armor] SET RECOVERY FULL 
GO

ALTER DATABASE [Armor] SET  MULTI_USER 
GO

ALTER DATABASE [Armor] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Armor] SET DB_CHAINING OFF 
GO




























USE [Armor]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramEvaluatorStage3]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramEvaluatorStage3](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[DateTimeTakenUTC] [datetime] NOT NULL,
	[Question1] [int] NULL,
	[Question2] [int] NULL,
	[Question3] [int] NULL,
	[Question4] [int] NULL,
	[Question5] [int] NULL,
	[Question6] [int] NULL,
	[Question7] [int] NULL,
	[Question8] [int] NULL,
	[Question9] [int] NULL,
	[Question10] [int] NULL,
	[Question11] [int] NULL,
	[Question12] [nvarchar](255) NULL,
	[Question13] [nvarchar](255) NULL,
	[Question14] [nvarchar](255) NULL,
	[Question15] [nvarchar](255) NULL,
	[Question16] [nvarchar](255) NULL,
	[Question17] [nvarchar](255) NULL,
	[Question18] [nvarchar](255) NULL,
	[Question19] [nvarchar](255) NULL,
	[Question20] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProgramEvaluatorStage3] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramEvaluatorStage2]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramEvaluatorStage2](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[DateTimeTakenUTC] [datetime] NOT NULL,
	[Question1] [int] NULL,
	[Question2] [int] NULL,
	[Question3] [int] NULL,
	[Question4] [int] NULL,
	[Question5] [int] NULL,
	[Question6] [int] NULL,
	[Question7] [int] NULL,
	[Question8] [int] NULL,
	[Question9] [int] NULL,
	[Question10] [int] NULL,
	[Question11] [int] NULL,
	[Question12] [nvarchar](255) NULL,
	[Question13] [nvarchar](255) NULL,
	[Question14] [nvarchar](255) NULL,
	[Question15] [nvarchar](255) NULL,
	[Question16] [nvarchar](255) NULL,
	[Question17] [nvarchar](255) NULL,
	[Question18] [nvarchar](255) NULL,
	[Question19] [nvarchar](255) NULL,
	[Question20] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProgramEvaluatorStage2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramEvaluatorStage1]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramEvaluatorStage1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[DateTimeTakenUTC] [datetime] NOT NULL,
	[Question1] [int] NULL,
	[Question2] [int] NULL,
	[Question3] [int] NULL,
	[Question4] [int] NULL,
	[Question5] [int] NULL,
	[Question6] [int] NULL,
	[Question7] [int] NULL,
	[Question8] [int] NULL,
	[Question9] [int] NULL,
	[Question10] [int] NULL,
	[Question11] [int] NULL,
	[Question12] [nvarchar](255) NULL,
	[Question13] [nvarchar](255) NULL,
	[Question14] [nvarchar](255) NULL,
	[Question15] [nvarchar](255) NULL,
	[Question16] [nvarchar](255) NULL,
	[Question17] [nvarchar](255) NULL,
	[Question18] [nvarchar](255) NULL,
	[Question19] [nvarchar](255) NULL,
	[Question20] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProgramEvaluatorStage1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreAssessment]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreAssessment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[DateTimeTakenUTC] [datetime] NOT NULL,
	[Question1] [nvarchar](255) NULL,
	[Question2] [nvarchar](255) NULL,
	[Question3] [nvarchar](255) NULL,
	[Question4] [nvarchar](255) NULL,
	[Question5] [nvarchar](255) NULL,
	[Question6] [nvarchar](255) NULL,
	[Question7] [nvarchar](255) NULL,
	[Question8] [nvarchar](255) NULL,
	[Question9] [nvarchar](500) NULL,
	[Question10] [nvarchar](500) NULL,
	[Question11] [nvarchar](255) NULL,
	[Question12] [nvarchar](1000) NULL,
 CONSTRAINT [PK_PreAssessment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientAssessment]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientAssessment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[DateTimeTakenUTC] [datetime] NOT NULL,
	[Question1] [nvarchar](255) NULL,
	[Question2] [nvarchar](255) NULL,
	[Question3] [nvarchar](255) NULL,
	[Question4] [nvarchar](255) NULL,
	[Question5] [nvarchar](255) NULL,
	[Question6] [nvarchar](255) NULL,
	[Question7] [nvarchar](255) NULL,
	[Question8] [nvarchar](255) NULL,
	[Question9] [nvarchar](1000) NULL,
	[Question10] [nvarchar](255) NULL,
	[Question11] [nvarchar](255) NULL,
	[Question12] [nvarchar](255) NULL,
	[Question13] [nvarchar](1000) NULL,
 CONSTRAINT [PK_PatientAssessment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_UsserRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[RoleID] [int] NULL,
	[Password] [nvarchar](500) NOT NULL,
	[FirstName] [nvarchar](250) NULL,
	[LastName] [nvarchar](250) NULL,
	[EmailAddress] [nvarchar](500) NOT NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](8) NULL,
	[GSTInformation] [nvarchar](50) NULL,
	[ForgotPasswordHash] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInRoles]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInRoles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAuthenticationProfile]    Script Date: 01/26/2012 00:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAuthenticationProfile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Service] [nvarchar](100) NOT NULL,
	[ServiceUsername] [nvarchar](250) NULL,
	[Token] [nvarchar](500) NOT NULL,
	[TokenSecret] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserAuthenticationProfile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_User_RoleID]    Script Date: 01/26/2012 00:45:03 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_RoleID]  DEFAULT ((2)) FOR [RoleID]
GO
/****** Object:  ForeignKey [FK_User_UserRole]    Script Date: 01/26/2012 00:45:03 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserRole] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRole] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserRole]
GO
/****** Object:  ForeignKey [FK_UserAuthenticationProfile_User]    Script Date: 01/26/2012 00:45:03 ******/
ALTER TABLE [dbo].[UserAuthenticationProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserAuthenticationProfile_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserAuthenticationProfile] CHECK CONSTRAINT [FK_UserAuthenticationProfile_User]
GO
/****** Object:  ForeignKey [FK_UserRoles_Roles]    Script Date: 01/26/2012 00:45:03 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO
/****** Object:  ForeignKey [FK_UserRoles_UserRoles]    Script Date: 01/26/2012 00:45:03 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_UserRoles] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserRoles_UserRoles]
GO
