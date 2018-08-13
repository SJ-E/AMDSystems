USE [AMD]
GO

/****** Object:  Table [dbo].[ip_quote_custom]    Script Date: 5/27/2018 9:11:31 AM ******/
DROP TABLE [dbo].[ip_quote_custom]
GO

/****** Object:  Table [dbo].[ip_quote_custom]    Script Date: 5/27/2018 9:11:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_quote_custom](
	[quote_custom_id] [int] NOT NULL,
	[quote_id] [int] NOT NULL
) ON [PRIMARY]
GO

