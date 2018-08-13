USE [AMD]
GO

ALTER TABLE [dbo].[ip_company_profile] DROP CONSTRAINT [DF__ip_compan__Statu__412EB0B6]
GO

/****** Object:  Table [dbo].[ip_company_profile]    Script Date: 5/27/2018 8:39:21 AM ******/
DROP TABLE [dbo].[ip_company_profile]
GO

/****** Object:  Table [dbo].[ip_company_profile]    Script Date: 5/27/2018 8:39:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_company_profile](
	[Id] [int] NOT NULL,
	[CompanyName] [varchar](500) NOT NULL,
	[CompanyAddress] [varchar](1000) NOT NULL,
	[CompanyPhoneNumber] [varchar](20) NOT NULL,
	[CompanyEmailId] [varchar](100) NOT NULL,
	[CompanyLogo] [varchar](500) NOT NULL,
	[CompanyTINNumber] [varchar](100) NOT NULL,
	[Template] [varchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[SenderId] [varchar](6) NOT NULL,
	[Message] [varchar](120) NOT NULL,
	[CloseMessage] [varchar](120) NOT NULL,
	[Terms] [varchar](5000) NOT NULL,
	[Prefix] [varchar](100) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_company_profile] ADD  DEFAULT ('1') FOR [Status]
GO

