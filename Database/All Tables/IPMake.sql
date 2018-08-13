USE [AMD]
GO

/****** Object:  Table [dbo].[ip_make]    Script Date: 5/27/2018 9:07:14 AM ******/
DROP TABLE [dbo].[ip_make]
GO

/****** Object:  Table [dbo].[ip_make]    Script Date: 5/27/2018 9:07:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_make](
	[id] [int] NOT NULL,
	[make_name] [varchar](255) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO

