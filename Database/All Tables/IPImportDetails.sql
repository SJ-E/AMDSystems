USE [AMD]
GO

/****** Object:  Table [dbo].[ip_import_details]    Script Date: 5/27/2018 8:41:00 AM ******/
DROP TABLE [dbo].[ip_import_details]
GO

/****** Object:  Table [dbo].[ip_import_details]    Script Date: 5/27/2018 8:41:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_import_details](
	[import_detail_id] [int] NOT NULL,
	[import_id] [int] NOT NULL,
	[import_lang_key] [varchar](35) NOT NULL,
	[import_table_name] [varchar](35) NOT NULL,
	[import_record_id] [int] NOT NULL
) ON [PRIMARY]
GO

