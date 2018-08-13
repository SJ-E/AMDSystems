USE [AMD]
GO

/****** Object:  Table [dbo].[ip_job_portal]    Script Date: 5/27/2018 9:07:03 AM ******/
DROP TABLE [dbo].[ip_job_portal]
GO

/****** Object:  Table [dbo].[ip_job_portal]    Script Date: 5/27/2018 9:07:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_job_portal](
	[id] [int] NOT NULL,
	[customer_name] [varchar](500) NOT NULL,
	[customer_mobile] [varchar](500) NOT NULL,
	[customer_address] [varchar](500) NOT NULL,
	[company] [varchar](100) NOT NULL,
	[job_number] [varchar](100) NOT NULL,
	[date] [date] NOT NULL,
	[make] [varchar](100) NOT NULL,
	[model] [varchar](100) NOT NULL,
	[sl_no] [varchar](100) NOT NULL,
	[gurantee] [varchar](100) NOT NULL,
	[paidamount] [decimal](10, 0) NOT NULL,
	[problem] [varchar](100) NOT NULL,
	[remarks] [varchar](100) NOT NULL,
	[terms_conditions] [varchar](100) NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO

