USE [UrlLinkTest]
GO
/****** Object:  Table [dbo].[Environment_Summariz]    Script Date: 3/12/2024 9:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Environment_Summariz](
	[FunctionName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Url]    Script Date: 3/12/2024 9:32:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Url](
	[Environment] [nvarchar](max) NULL,
	[Information] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/12/2024 9:32:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Privilege] [nvarchar](50) NULL,
	[UserName] [nvarchar](max) NULL,
	[PassWord] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
