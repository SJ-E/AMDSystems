USE [AMD]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___0D7A0286]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___0C85DE4D]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___0B91BA14]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___0A9D95DB]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___09A971A2]
GO

ALTER TABLE [dbo].[ip_purchase_items] DROP CONSTRAINT [DF__ip_purcha__item___08B54D69]
GO

/****** Object:  Table [dbo].[ip_purchase_items]    Script Date: 5/27/2018 9:10:46 AM ******/
DROP TABLE [dbo].[ip_purchase_items]
GO

/****** Object:  Table [dbo].[ip_purchase_items]    Script Date: 5/27/2018 9:10:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_purchase_items](
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

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT (NULL) FOR [item_product_id]
GO

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT (NULL) FOR [item_quantity]
GO

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT (NULL) FOR [item_price]
GO

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT (NULL) FOR [item_discount_amount]
GO

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT ('0') FOR [item_order]
GO

ALTER TABLE [dbo].[ip_purchase_items] ADD  DEFAULT (NULL) FOR [item_serial]
GO

