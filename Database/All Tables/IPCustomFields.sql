USE [AMD]
GO

ALTER TABLE [dbo].[ip_custom_fields] DROP CONSTRAINT [DF__ip_custom__custo__4222D4EF]
GO

/****** Object:  Table [dbo].[ip_custom_fields]    Script Date: 5/27/2018 8:39:39 AM ******/
DROP TABLE [dbo].[ip_custom_fields]
GO

/****** Object:  Table [dbo].[ip_custom_fields]    Script Date: 5/27/2018 8:39:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_custom_fields](
	[custom_field_id] [int] NOT NULL,
	[custom_field_table] [varchar](255) NULL,
	[custom_field_label] [varchar](max) NULL,
	[custom_field_column] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_custom_fields] ADD  DEFAULT (NULL) FOR [custom_field_table]
GO

