USE [AMD]
GO

/****** Object:  Table [dbo].[ip_company]    Script Date: 5/27/2018 8:39:07 AM ******/
DROP TABLE [dbo].[ip_company]
GO

/****** Object:  Table [dbo].[ip_company]    Script Date: 5/27/2018 8:39:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_company](
	[id] [int] NOT NULL,
	[company_name] [varchar](250) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO

