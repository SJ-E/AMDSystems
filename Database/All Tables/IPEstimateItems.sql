USE [AMD]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__clien__5165187F]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__clien__5070F446]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4F7CD00D]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4E88ABD4]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4D94879B]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4CA06362]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4BAC3F29]
GO

ALTER TABLE [dbo].[ip_estimate_items] DROP CONSTRAINT [DF__ip_estima__item___4AB81AF0]
GO

/****** Object:  Table [dbo].[ip_estimate_items]    Script Date: 5/27/2018 8:40:24 AM ******/
DROP TABLE [dbo].[ip_estimate_items]
GO

/****** Object:  Table [dbo].[ip_estimate_items]    Script Date: 5/27/2018 8:40:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_estimate_items](
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
	[item_serial] [varchar](200) NULL,
	[clientname] [varchar](450) NULL,
	[clientnum] [varchar](1000) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [item_product_id]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [item_quantity]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [item_price]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [item_discount_amount]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT ('0') FOR [item_order]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [item_serial]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [clientname]
GO

ALTER TABLE [dbo].[ip_estimate_items] ADD  DEFAULT (NULL) FOR [clientnum]
GO

