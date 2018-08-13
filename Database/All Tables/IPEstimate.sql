USE [AMD]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__quote__49C3F6B7]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__quote__48CFD27E]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__quote__47DBAE45]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__quote__46E78A0C]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__quote__45F365D3]
GO

ALTER TABLE [dbo].[ip_estimate] DROP CONSTRAINT [DF__ip_estima__invoi__44FF419A]
GO

/****** Object:  Table [dbo].[ip_estimate]    Script Date: 5/27/2018 8:40:08 AM ******/
DROP TABLE [dbo].[ip_estimate]
GO

/****** Object:  Table [dbo].[ip_estimate]    Script Date: 5/27/2018 8:40:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_estimate](
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

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT ('0') FOR [invoice_id]
GO

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT ('1') FOR [quote_status_id]
GO

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT (NULL) FOR [quote_number]
GO

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT (NULL) FOR [quote_discount_amount]
GO

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT (NULL) FOR [quote_discount_percent]
GO

ALTER TABLE [dbo].[ip_estimate] ADD  DEFAULT (NULL) FOR [quote_password]
GO

