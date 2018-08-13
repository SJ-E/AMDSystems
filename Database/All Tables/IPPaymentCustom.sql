USE [AMD]
GO

/****** Object:  Table [dbo].[ip_payment_custom]    Script Date: 5/27/2018 9:08:33 AM ******/
DROP TABLE [dbo].[ip_payment_custom]
GO

/****** Object:  Table [dbo].[ip_payment_custom]    Script Date: 5/27/2018 9:08:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_payment_custom](
	[payment_custom_id] [int] NOT NULL,
	[payment_id] [int] NOT NULL
) ON [PRIMARY]
GO

