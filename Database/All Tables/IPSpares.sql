USE [AMD]
GO

/****** Object:  Table [dbo].[ip_Spares]    Script Date: 5/27/2018 9:12:55 AM ******/
DROP TABLE [dbo].[ip_Spares]
GO

/****** Object:  Table [dbo].[ip_Spares]    Script Date: 5/27/2018 9:12:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_Spares](
	[id] [int] NOT NULL,
	[JobId] [varchar](255) NOT NULL,
	[Spares_name] [varchar](255) NOT NULL,
	[status] [int] NOT NULL,
	[Amount] [decimal](10, 0) NOT NULL
) ON [PRIMARY]
GO

