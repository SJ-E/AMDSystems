USE [AMD]
GO

ALTER TABLE [dbo].[ip_sessions] DROP CONSTRAINT [CK__ip_sessio__last___2BFE89A6]
GO

ALTER TABLE [dbo].[ip_sessions] DROP CONSTRAINT [DF__ip_sessio__last___2739D489]
GO

ALTER TABLE [dbo].[ip_sessions] DROP CONSTRAINT [DF__ip_sessio__ip_ad__2645B050]
GO

ALTER TABLE [dbo].[ip_sessions] DROP CONSTRAINT [DF__ip_sessio__sessi__25518C17]
GO

/****** Object:  Table [dbo].[ip_sessions]    Script Date: 5/27/2018 9:12:32 AM ******/
DROP TABLE [dbo].[ip_sessions]
GO

/****** Object:  Table [dbo].[ip_sessions]    Script Date: 5/27/2018 9:12:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_sessions](
	[session_id] [varchar](40) NOT NULL,
	[ip_address] [varchar](45) NOT NULL,
	[user_agent] [varchar](120) NOT NULL,
	[last_activity] [int] NOT NULL,
	[user_data] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_sessions] ADD  DEFAULT ('0') FOR [session_id]
GO

ALTER TABLE [dbo].[ip_sessions] ADD  DEFAULT ('0') FOR [ip_address]
GO

ALTER TABLE [dbo].[ip_sessions] ADD  DEFAULT ('0') FOR [last_activity]
GO

ALTER TABLE [dbo].[ip_sessions]  WITH CHECK ADD CHECK  (([last_activity]>(0)))
GO

