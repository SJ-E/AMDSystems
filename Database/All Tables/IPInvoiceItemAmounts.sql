USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] DROP CONSTRAINT [DF__ip_invoic__item___5BE2A6F2]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] DROP CONSTRAINT [DF__ip_invoic__item___5AEE82B9]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] DROP CONSTRAINT [DF__ip_invoic__item___59FA5E80]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] DROP CONSTRAINT [DF__ip_invoic__item___59063A47]
GO

/****** Object:  Table [dbo].[ip_invoice_item_amounts]    Script Date: 5/27/2018 8:42:27 AM ******/
DROP TABLE [dbo].[ip_invoice_item_amounts]
GO

/****** Object:  Table [dbo].[ip_invoice_item_amounts]    Script Date: 5/27/2018 8:42:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_item_amounts](
	[item_amount_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[item_subtotal] [decimal](20, 2) NULL,
	[item_tax_total] [decimal](20, 2) NULL,
	[item_discount] [decimal](20, 2) NULL,
	[item_total] [decimal](20, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] ADD  DEFAULT (NULL) FOR [item_subtotal]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] ADD  DEFAULT (NULL) FOR [item_tax_total]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] ADD  DEFAULT (NULL) FOR [item_discount]
GO

ALTER TABLE [dbo].[ip_invoice_item_amounts] ADD  DEFAULT (NULL) FOR [item_total]
GO

