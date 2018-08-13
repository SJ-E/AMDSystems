USE [AMD]
GO

/****** Object:  Table [dbo].[ip_payment_methods]    Script Date: 5/27/2018 9:08:54 AM ******/
DROP TABLE [dbo].[ip_payment_methods]
GO

/****** Object:  Table [dbo].[ip_payment_methods]    Script Date: 5/27/2018 9:08:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_payment_methods](
	[payment_method_id] [int] NOT NULL,
	[payment_method_name] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

