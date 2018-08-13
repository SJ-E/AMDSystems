USE [AMD]
GO

/****** Object:  Table [dbo].[ip_families]    Script Date: 5/26/2018 1:35:56 AM ******/
DROP TABLE [dbo].[ip_families]
GO

/****** Object:  Table [dbo].[ip_families]    Script Date: 5/26/2018 1:35:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_families](
	[family_id] [int] Identity(1,1) primary key,
	[family_name] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


