USE [AMD]
GO

ALTER TABLE [dbo].[ip_payments] DROP CONSTRAINT [DF__ip_paymen__payme__6EF57B66]
GO

ALTER TABLE [dbo].[ip_payments] DROP CONSTRAINT [DF__ip_paymen__payme__6E01572D]
GO

/****** Object:  Table [dbo].[ip_payments]    Script Date: 5/27/2018 9:09:06 AM ******/
DROP TABLE [dbo].[ip_payments]
GO

/****** Object:  Table [dbo].[ip_payments]    Script Date: 5/27/2018 9:09:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_payments](
	[payment_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[payment_method_id] [int] NOT NULL,
	[payment_date] [date] NOT NULL,
	[payment_amount] [decimal](20, 2) NULL,
	[payment_note] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_payments] ADD  DEFAULT ('0') FOR [payment_method_id]
GO

ALTER TABLE [dbo].[ip_payments] ADD  DEFAULT (NULL) FOR [payment_amount]
GO

