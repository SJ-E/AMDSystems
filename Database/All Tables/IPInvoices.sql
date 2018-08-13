USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__user___5C37ACAD]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__invoi__6E565CE8]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [FK__ip_invoic__clien__5D2BD0E6]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__credi__2D7CBDC4]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__payme__2C88998B]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__2B947552]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__2AA05119]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__29AC2CE0]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__28B808A7]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__27C3E46E]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__is_re__26CFC035]
GO

ALTER TABLE [dbo].[ip_invoices] DROP CONSTRAINT [DF__ip_invoic__invoi__25DB9BFC]
GO

/****** Object:  Table [dbo].[ip_invoices]    Script Date: 5/27/2018 8:43:12 AM ******/
DROP TABLE [dbo].[ip_invoices]
GO

/****** Object:  Table [dbo].[ip_invoices]    Script Date: 5/27/2018 8:43:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoices](
	[invoice_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[invoice_group_id] [int] NOT NULL,
	[invoice_status_id] [smallint] NOT NULL,
	[is_read_only] [smallint] NULL,
	[invoice_password] [varchar](90) NULL,
	[invoice_date_created] [date] NOT NULL,
	[invoice_time_created] [time](0) NOT NULL,
	[invoice_date_modified] [datetime2](0) NOT NULL,
	[invoice_date_due] [date] NOT NULL,
	[invoice_number] [varchar](100) NULL,
	[invoice_discount_amount] [decimal](20, 2) NULL,
	[invoice_discount_percent] [decimal](20, 2) NULL,
	[invoice_terms] [varchar](max) NOT NULL,
	[invoice_url_key] [char](32) NOT NULL,
	[payment_method] [int] NOT NULL,
	[creditinvoice_parent_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT ('1') FOR [invoice_status_id]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [is_read_only]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [invoice_password]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT ('00:00:00') FOR [invoice_time_created]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [invoice_number]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [invoice_discount_amount]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [invoice_discount_percent]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT ('0') FOR [payment_method]
GO

ALTER TABLE [dbo].[ip_invoices] ADD  DEFAULT (NULL) FOR [creditinvoice_parent_id]
GO

ALTER TABLE [dbo].[ip_invoices]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_invoices]  WITH CHECK ADD FOREIGN KEY([invoice_group_id])
REFERENCES [dbo].[ip_invoice_groups] ([invoice_group_id])
GO

ALTER TABLE [dbo].[ip_invoices]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[ip_users] ([user_id])
GO

