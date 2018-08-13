USE [AMD]
GO

/****** Object:  Table [dbo].[ip_tax_rates]    Script Date: 5/27/2018 9:13:16 AM ******/
DROP TABLE [dbo].[ip_tax_rates]
GO

/****** Object:  Table [dbo].[ip_tax_rates]    Script Date: 5/27/2018 9:13:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_tax_rates](
	[tax_rate_id] [int] NOT NULL,
	[tax_rate_name] [varchar](max) NULL,
	[tax_rate_percent] [decimal](5, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

