USE [AMD]
GO

/****** Object:  Table [dbo].[ip_settings]    Script Date: 5/27/2018 9:12:44 AM ******/
DROP TABLE [dbo].[ip_settings]
GO

/****** Object:  Table [dbo].[ip_settings]    Script Date: 5/27/2018 9:12:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_settings](
	[setting_id] [int] NOT NULL,
	[setting_key] [varchar](50) NOT NULL,
	[setting_value] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

