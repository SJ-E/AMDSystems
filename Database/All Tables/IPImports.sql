USE [AMD]
GO

/****** Object:  Table [dbo].[ip_imports]    Script Date: 5/27/2018 8:41:18 AM ******/
DROP TABLE [dbo].[ip_imports]
GO

/****** Object:  Table [dbo].[ip_imports]    Script Date: 5/27/2018 8:41:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_imports](
	[import_id] [int] NOT NULL,
	[import_date] [datetime2](0) NOT NULL
) ON [PRIMARY]
GO

