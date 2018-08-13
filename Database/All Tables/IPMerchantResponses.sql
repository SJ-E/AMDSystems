USE [AMD]
GO

/****** Object:  Table [dbo].[ip_merchant_responses]    Script Date: 5/27/2018 9:07:55 AM ******/
DROP TABLE [dbo].[ip_merchant_responses]
GO

/****** Object:  Table [dbo].[ip_merchant_responses]    Script Date: 5/27/2018 9:07:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_merchant_responses](
	[merchant_response_id] [int] NOT NULL,
	[invoice_id] [int] NOT NULL,
	[merchant_response_date] [date] NOT NULL,
	[merchant_response_driver] [varchar](35) NOT NULL,
	[merchant_response] [varchar](255) NOT NULL,
	[merchant_response_reference] [varchar](255) NOT NULL
) ON [PRIMARY]
GO

