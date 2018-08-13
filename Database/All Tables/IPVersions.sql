USE [AMD]
GO

/****** Object:  Table [dbo].[ip_versions]    Script Date: 5/27/2018 9:15:56 AM ******/
DROP TABLE [dbo].[ip_versions]
GO

/****** Object:  Table [dbo].[ip_versions]    Script Date: 5/27/2018 9:15:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_versions](
	[version_id] [int] NOT NULL,
	[version_date_applied] [varchar](14) NOT NULL,
	[version_file] [varchar](45) NOT NULL,
	[version_sql_errors] [int] NOT NULL
) ON [PRIMARY]
GO

