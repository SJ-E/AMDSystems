USE [AMD]
GO

/****** Object:  Table [dbo].[ip_projects]    Script Date: 5/27/2018 9:09:27 AM ******/
DROP TABLE [dbo].[ip_projects]
GO

/****** Object:  Table [dbo].[ip_projects]    Script Date: 5/27/2018 9:09:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_projects](
	[project_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[project_name] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

