USE [AMD]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] DROP CONSTRAINT [DF__ip_purcha__item___07C12930]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] DROP CONSTRAINT [DF__ip_purcha__item___06CD04F7]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] DROP CONSTRAINT [DF__ip_purcha__item___05D8E0BE]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] DROP CONSTRAINT [DF__ip_purcha__item___04E4BC85]
GO

/****** Object:  Table [dbo].[ip_purchase_item_amounts]    Script Date: 5/27/2018 9:10:31 AM ******/
DROP TABLE [dbo].[ip_purchase_item_amounts]
GO

/****** Object:  Table [dbo].[ip_purchase_item_amounts]    Script Date: 5/27/2018 9:10:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_purchase_item_amounts](
	[item_amount_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[item_subtotal] [decimal](20, 2) NULL,
	[item_tax_total] [decimal](20, 2) NULL,
	[item_discount] [decimal](20, 2) NULL,
	[item_total] [decimal](20, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] ADD  DEFAULT (NULL) FOR [item_subtotal]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] ADD  DEFAULT (NULL) FOR [item_tax_total]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] ADD  DEFAULT (NULL) FOR [item_discount]
GO

ALTER TABLE [dbo].[ip_purchase_item_amounts] ADD  DEFAULT (NULL) FOR [item_total]
GO

