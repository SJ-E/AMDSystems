USE [AMD]
GO

/****** Object:  Table [dbo].[ip_families]    Script Date: 5/27/2018 8:40:38 AM ******/
DROP TABLE [dbo].[ip_families]
GO

/****** Object:  Table [dbo].[ip_families]    Script Date: 5/27/2018 8:40:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_families](
	[family_id] [int] IDENTITY(1,1) NOT NULL,
	[family_name] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[family_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

