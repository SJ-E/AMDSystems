USE [AMD]
GO

/****** Object:  Table [dbo].[ip_user_custom]    Script Date: 5/27/2018 9:13:50 AM ******/
DROP TABLE [dbo].[ip_user_custom]
GO

/****** Object:  Table [dbo].[ip_user_custom]    Script Date: 5/27/2018 9:13:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_user_custom](
	[user_custom_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[user_custom_bank_name] [varchar](2000) NOT NULL,
	[user_custom_account_number] [varchar](2000) NOT NULL,
	[user_custom_ifsc_code] [varchar](2000) NOT NULL,
	[user_custom_branch] [varchar](2000) NOT NULL
) ON [PRIMARY]
GO

