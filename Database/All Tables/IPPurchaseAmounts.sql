USE [AMD]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] DROP CONSTRAINT [DF__ip_purcha__quote__03F0984C]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] DROP CONSTRAINT [DF__ip_purcha__quote__02FC7413]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] DROP CONSTRAINT [DF__ip_purcha__quote__02084FDA]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] DROP CONSTRAINT [DF__ip_purcha__quote__01142BA1]
GO

/****** Object:  Table [dbo].[ip_purchase_amounts]    Script Date: 5/27/2018 9:09:54 AM ******/
DROP TABLE [dbo].[ip_purchase_amounts]
GO

/****** Object:  Table [dbo].[ip_purchase_amounts]    Script Date: 5/27/2018 9:09:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_purchase_amounts](
	[quote_amount_id] [int] NOT NULL,
	[quote_id] [int] NOT NULL,
	[quote_item_subtotal] [decimal](20, 2) NULL,
	[quote_item_tax_total] [decimal](20, 2) NULL,
	[quote_tax_total] [decimal](20, 2) NULL,
	[quote_total] [decimal](20, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] ADD  DEFAULT (NULL) FOR [quote_item_subtotal]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] ADD  DEFAULT (NULL) FOR [quote_item_tax_total]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] ADD  DEFAULT (NULL) FOR [quote_tax_total]
GO

ALTER TABLE [dbo].[ip_purchase_amounts] ADD  DEFAULT (NULL) FOR [quote_total]
GO

