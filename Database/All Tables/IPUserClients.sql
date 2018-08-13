USE [AMD]
GO

/****** Object:  Table [dbo].[ip_user_clients]    Script Date: 5/27/2018 9:13:38 AM ******/
DROP TABLE [dbo].[ip_user_clients]
GO

/****** Object:  Table [dbo].[ip_user_clients]    Script Date: 5/27/2018 9:13:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_user_clients](
	[user_client_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[client_id] [int] NOT NULL
) ON [PRIMARY]
GO

