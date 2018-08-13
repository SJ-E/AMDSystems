USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [FK__ip_invoic__invoi__1758727B]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__16644E42]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__15702A09]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__147C05D0]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__1387E197]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__1293BD5E]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] DROP CONSTRAINT [DF__ip_invoic__invoi__119F9925]
GO

/****** Object:  Table [dbo].[ip_invoice_amounts]    Script Date: 5/26/2018 5:02:14 AM ******/
DROP TABLE [dbo].[ip_invoice_amounts]
GO

/****** Object:  Table [dbo].[ip_invoice_amounts]    Script Date: 5/26/2018 5:02:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_amounts](
	[invoice_amount_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_id] [int] NOT NULL,
	[invoice_item_subtotal] [decimal](20, 2) NULL,
	[invoice_item_tax_total] [decimal](20, 2) NULL,
	[invoice_tax_total] [decimal](20, 2) NULL,
	[invoice_total] [decimal](20, 2) NULL,
	[invoice_paid] [decimal](20, 2) NULL,
	[invoice_balance] [decimal](20, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_amount_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_item_subtotal]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_item_tax_total]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_tax_total]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_total]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_paid]
GO

ALTER TABLE [dbo].[ip_invoice_amounts] ADD  DEFAULT (NULL) FOR [invoice_balance]
GO

ALTER TABLE [dbo].[ip_invoice_amounts]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[ip_invoices] ([invoice_id])
GO


