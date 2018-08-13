USE [AMD]
GO

/****** Object:  Table [dbo].[ip_uploads]    Script Date: 5/27/2018 9:13:26 AM ******/
DROP TABLE [dbo].[ip_uploads]
GO

/****** Object:  Table [dbo].[ip_uploads]    Script Date: 5/27/2018 9:13:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_uploads](
	[upload_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
	[url_key] [char](32) NOT NULL,
	[file_name_original] [varchar](max) NOT NULL,
	[file_name_new] [varchar](max) NOT NULL,
	[uploaded_date] [date] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

