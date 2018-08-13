USE [AMD]
GO

ALTER TABLE [dbo].[ip_tasks] DROP CONSTRAINT [DF__ip_tasks__task_p__282DF8C2]
GO

/****** Object:  Table [dbo].[ip_tasks]    Script Date: 5/27/2018 9:13:04 AM ******/
DROP TABLE [dbo].[ip_tasks]
GO

/****** Object:  Table [dbo].[ip_tasks]    Script Date: 5/27/2018 9:13:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_tasks](
	[task_id] [int] NOT NULL,
	[project_id] [varchar](max) NOT NULL,
	[task_name] [varchar](max) NULL,
	[task_description] [varchar](max) NOT NULL,
	[task_price] [varchar](500) NULL,
	[task_finish_date] [varchar](500) NOT NULL,
	[task_status] [varchar](500) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_tasks] ADD  DEFAULT (NULL) FOR [task_price]
GO

