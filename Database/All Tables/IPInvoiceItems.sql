USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___619B8048]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___60A75C0F]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___5FB337D6]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___5EBF139D]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___5DCAEF64]
GO

ALTER TABLE [dbo].[ip_invoice_items] DROP CONSTRAINT [DF__ip_invoic__item___5CD6CB2B]
GO

/****** Object:  Table [dbo].[ip_invoice_items]    Script Date: 5/27/2018 8:42:40 AM ******/
DROP TABLE [dbo].[ip_invoice_items]
GO

/****** Object:  Table [dbo].[ip_invoice_items]    Script Date: 5/27/2018 8:42:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_items](
	[item_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[item_tax_rate_id] [int] NOT NULL,
	[item_product_id] [int] NULL,
	[item_date_added] [date] NOT NULL,
	[item_name] [varchar](max) NULL,
	[item_description] [varchar](max) NULL,
	[item_quantity] [decimal](10, 2) NOT NULL,
	[item_price] [decimal](20, 2) NULL,
	[item_discount_amount] [decimal](20, 2) NULL,
	[item_order] [int] NOT NULL,
	[item_serial] [varchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT ('0') FOR [item_tax_rate_id]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT (NULL) FOR [item_product_id]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT (NULL) FOR [item_price]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT (NULL) FOR [item_discount_amount]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT ('0') FOR [item_order]
GO

ALTER TABLE [dbo].[ip_invoice_items] ADD  DEFAULT (NULL) FOR [item_serial]
GO

