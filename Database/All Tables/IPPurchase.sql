USE [AMD]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__quote__00200768]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__quote__7F2BE32F]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__quote__7E37BEF6]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__quote__7D439ABD]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__quote__7C4F7684]
GO

ALTER TABLE [dbo].[ip_purchase] DROP CONSTRAINT [DF__ip_purcha__invoi__7B5B524B]
GO

/****** Object:  Table [dbo].[ip_purchase]    Script Date: 5/27/2018 9:09:41 AM ******/
DROP TABLE [dbo].[ip_purchase]
GO

/****** Object:  Table [dbo].[ip_purchase]    Script Date: 5/27/2018 9:09:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_purchase](
	[quote_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[invoice_group_id] [int] NOT NULL,
	[quote_status_id] [smallint] NOT NULL,
	[quote_date_created] [date] NOT NULL,
	[quote_date_modified] [datetime2](0) NOT NULL,
	[quote_date_expires] [date] NOT NULL,
	[quote_number] [varchar](100) NULL,
	[quote_discount_amount] [decimal](20, 2) NULL,
	[quote_discount_percent] [decimal](20, 2) NULL,
	[quote_url_key] [char](32) NOT NULL,
	[quote_password] [varchar](90) NULL,
	[notes] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT ('0') FOR [invoice_id]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT ('1') FOR [quote_status_id]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT (NULL) FOR [quote_number]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT (NULL) FOR [quote_discount_amount]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT (NULL) FOR [quote_discount_percent]
GO

ALTER TABLE [dbo].[ip_purchase] ADD  DEFAULT (NULL) FOR [quote_password]
GO

