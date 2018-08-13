USE [AMD]
GO

/****** Object:  Table [dbo].[ip_invoice_custom]    Script Date: 5/26/2018 5:02:48 AM ******/
DROP TABLE [dbo].[ip_invoice_custom]
GO

/****** Object:  Table [dbo].[ip_invoice_custom]    Script Date: 5/26/2018 5:02:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_custom](
	[invoice_custom_id] [int] Identity(1,1) Primary Key,
	[invoice_id] [int] NOT NULL,
	[invoice_custom_delivery_note] [varchar](2000) NOT NULL,
	[invoice_custom_delivery_date] [varchar](2000) NOT NULL,
	[invoice_custom_order_no] [varchar](2000) NOT NULL,
	[invoice_custom_order_date] [varchar](2000) NOT NULL
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[ip_invoice_custom]  WITH CHECK ADD FOREIGN KEY([invoice_id])
REFERENCES [dbo].[ip_invoices] ([invoice_id])
GO
