USE [AMD]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__quote__3CBF0154]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__quote__3BCADD1B]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__quote__3AD6B8E2]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__quote__39E294A9]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__quote__38EE7070]
GO

ALTER TABLE [dbo].[ip_quotes] DROP CONSTRAINT [DF__ip_quotes__invoi__37FA4C37]
GO

/****** Object:  Table [dbo].[ip_quotes]    Script Date: 5/27/2018 9:12:21 AM ******/
DROP TABLE [dbo].[ip_quotes]
GO

/****** Object:  Table [dbo].[ip_quotes]    Script Date: 5/27/2018 9:12:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_quotes](
	[quote_id] [int] IDENTITY(1,1) NOT NULL,
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
	[notes] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[quote_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT ('0') FOR [invoice_id]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT ('1') FOR [quote_status_id]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT (NULL) FOR [quote_number]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT (NULL) FOR [quote_discount_amount]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT (NULL) FOR [quote_discount_percent]
GO

ALTER TABLE [dbo].[ip_quotes] ADD  DEFAULT (NULL) FOR [quote_password]
GO

