USE [AMD]
GO

ALTER TABLE [dbo].[ip_item_lookups] DROP CONSTRAINT [DF__ip_item_l__item___6D0D32F4]
GO

/****** Object:  Table [dbo].[ip_item_lookups]    Script Date: 5/27/2018 8:47:15 AM ******/
DROP TABLE [dbo].[ip_item_lookups]
GO

/****** Object:  Table [dbo].[ip_item_lookups]    Script Date: 5/27/2018 8:47:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_item_lookups](
	[item_lookup_id] [int] NOT NULL,
	[item_name] [varchar](100) NOT NULL,
	[item_description] [varchar](max) NOT NULL,
	[item_price] [decimal](10, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_item_lookups] ADD  DEFAULT ('') FOR [item_name]
GO

