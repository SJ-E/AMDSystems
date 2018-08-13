USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_custom] DROP CONSTRAINT [FK__ip_invoic__invoi__1A34DF26]
GO

/****** Object:  Table [dbo].[ip_invoice_custom]    Script Date: 5/27/2018 8:41:54 AM ******/
DROP TABLE [dbo].[ip_invoice_custom]
GO

/****** Object:  Table [dbo].[ip_invoice_custom]    Script Date: 5/27/2018 8:41:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_custom](
	[invoice_custom_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_id] [int] NOT NULL,
	[invoice_custom_delivery_note] [varchar](2000) NOT NULL,
	[invoice_custom_delivery_date] [varchar](2000) NOT NULL,
	[invoice_custom_order_no] [varchar](2000) NOT NULL,
	[invoice_custom_order_date] [varchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_custom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_custom]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[ip_invoices] ([invoice_id])
GO

