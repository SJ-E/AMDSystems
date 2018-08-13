USE [AMD]
GO

/****** Object:  Table [dbo].[ip_purchase_custom]    Script Date: 5/27/2018 9:10:13 AM ******/
DROP TABLE [dbo].[ip_purchase_custom]
GO

/****** Object:  Table [dbo].[ip_purchase_custom]    Script Date: 5/27/2018 9:10:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_purchase_custom](
	[quote_custom_id] [int] NOT NULL,
	[quote_id] [int] NOT NULL
) ON [PRIMARY]
GO

