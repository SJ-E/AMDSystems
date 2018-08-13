USE [AMD]
GO

/****** Object:  Table [dbo].[ip_invoices_recurring]    Script Date: 5/27/2018 8:43:29 AM ******/
DROP TABLE [dbo].[ip_invoices_recurring]
GO

/****** Object:  Table [dbo].[ip_invoices_recurring]    Script Date: 5/27/2018 8:43:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoices_recurring](
	[invoice_recurring_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[recur_start_date] [date] NOT NULL,
	[recur_end_date] [date] NOT NULL,
	[recur_frequency] [char](2) NOT NULL,
	[recur_next_date] [date] NOT NULL
) ON [PRIMARY]
GO

