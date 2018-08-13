USE [AMD]
GO

ALTER TABLE [dbo].[ip_quote_tax_rates] DROP CONSTRAINT [DF__ip_quote___quote__1EA48E88]
GO

ALTER TABLE [dbo].[ip_quote_tax_rates] DROP CONSTRAINT [DF__ip_quote___inclu__1DB06A4F]
GO

/****** Object:  Table [dbo].[ip_quote_tax_rates]    Script Date: 5/27/2018 9:12:10 AM ******/
DROP TABLE [dbo].[ip_quote_tax_rates]
GO

/****** Object:  Table [dbo].[ip_quote_tax_rates]    Script Date: 5/27/2018 9:12:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_quote_tax_rates](
	[quote_tax_rate_id] [int] NOT NULL,
	[quote_id] [int] NOT NULL,
	[tax_rate_id] [int] NOT NULL,
	[include_item_tax] [int] NOT NULL,
	[quote_tax_rate_amount] [decimal](20, 2) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_quote_tax_rates] ADD  DEFAULT ('0') FOR [include_item_tax]
GO

ALTER TABLE [dbo].[ip_quote_tax_rates] ADD  DEFAULT (NULL) FOR [quote_tax_rate_amount]
GO

