USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_tax_rates] DROP CONSTRAINT [DF__ip_invoic__invoi__6383C8BA]
GO

ALTER TABLE [dbo].[ip_invoice_tax_rates] DROP CONSTRAINT [DF__ip_invoic__inclu__628FA481]
GO

/****** Object:  Table [dbo].[ip_invoice_tax_rates]    Script Date: 5/27/2018 8:42:55 AM ******/
DROP TABLE [dbo].[ip_invoice_tax_rates]
GO

/****** Object:  Table [dbo].[ip_invoice_tax_rates]    Script Date: 5/27/2018 8:42:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_tax_rates](
	[invoice_tax_rate_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[tax_rate_id] [int] NOT NULL,
	[include_item_tax] [int] NOT NULL,
	[invoice_tax_rate_amount] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_tax_rates] ADD  DEFAULT ('0') FOR [include_item_tax]
GO

ALTER TABLE [dbo].[ip_invoice_tax_rates] ADD  DEFAULT ('0.00') FOR [invoice_tax_rate_amount]
GO

