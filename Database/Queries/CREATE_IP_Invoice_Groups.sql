USE [AMD]
GO

ALTER TABLE [dbo].[ip_invoice_groups] DROP CONSTRAINT [DF__ip_invoic__invoi__6E8B6712]
GO

/****** Object:  Table [dbo].[ip_invoice_groups]    Script Date: 5/26/2018 2:09:10 AM ******/
DROP TABLE [dbo].[ip_invoice_groups]
GO

/****** Object:  Table [dbo].[ip_invoice_groups]    Script Date: 5/26/2018 2:09:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_invoice_groups](
	[invoice_group_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_group_name] [varchar](max) NULL,
	[invoice_group_identifier_format] [varchar](255) NOT NULL,
	[invoice_group_next_id] [int] NOT NULL,
	[invoice_group_left_pad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[invoice_group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_invoice_groups] ADD  DEFAULT ('0') FOR [invoice_group_left_pad]
GO


