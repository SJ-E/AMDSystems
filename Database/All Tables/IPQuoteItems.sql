USE [AMD]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___1CBC4616]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___1BC821DD]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___1AD3FDA4]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___19DFD96B]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___18EBB532]
GO

ALTER TABLE [dbo].[ip_quote_items] DROP CONSTRAINT [DF__ip_quote___item___17F790F9]
GO

/****** Object:  Table [dbo].[ip_quote_items]    Script Date: 5/27/2018 9:11:58 AM ******/
DROP TABLE [dbo].[ip_quote_items]
GO

/****** Object:  Table [dbo].[ip_quote_items]    Script Date: 5/27/2018 9:11:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_quote_items](
	[item_id] [int] NOT NULL,
	[quote_id] [int] NOT NULL,
	[item_tax_rate_id] [int] NOT NULL,
	[item_product_id] [int] NULL,
	[item_date_added] [date] NOT NULL,
	[item_name] [varchar](max) NULL,
	[item_description] [varchar](max) NULL,
	[item_quantity] [decimal](20, 2) NULL,
	[item_price] [decimal](20, 2) NULL,
	[item_discount_amount] [decimal](20, 2) NULL,
	[item_order] [int] NOT NULL,
	[item_serial] [varchar](200) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT (NULL) FOR [item_product_id]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT (NULL) FOR [item_quantity]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT (NULL) FOR [item_price]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT (NULL) FOR [item_discount_amount]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT ('0') FOR [item_order]
GO

ALTER TABLE [dbo].[ip_quote_items] ADD  DEFAULT (NULL) FOR [item_serial]
GO

