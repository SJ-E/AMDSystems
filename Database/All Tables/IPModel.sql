USE [AMD]
GO

/****** Object:  Table [dbo].[ip_model]    Script Date: 5/27/2018 9:08:04 AM ******/
DROP TABLE [dbo].[ip_model]
GO

/****** Object:  Table [dbo].[ip_model]    Script Date: 5/27/2018 9:08:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_model](
	[id] [int] NOT NULL,
	[modee_name] [varchar](255) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO

