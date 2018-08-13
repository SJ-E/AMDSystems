USE [AMD]
GO

ALTER TABLE [dbo].[ip_users] DROP CONSTRAINT [DF__ip_users__user_p__12C8C788]
GO

ALTER TABLE [dbo].[ip_users] DROP CONSTRAINT [DF__ip_users__user_a__11D4A34F]
GO

ALTER TABLE [dbo].[ip_users] DROP CONSTRAINT [DF__ip_users__user_t__10E07F16]
GO

/****** Object:  Table [dbo].[ip_users]    Script Date: 5/27/2018 9:15:46 AM ******/
DROP TABLE [dbo].[ip_users]
GO

/****** Object:  Table [dbo].[ip_users]    Script Date: 5/27/2018 9:15:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_type] [int] NOT NULL,
	[user_active] [smallint] NULL,
	[user_date_created] [datetime2](0) NOT NULL,
	[user_date_modified] [datetime2](0) NOT NULL,
	[user_name] [varchar](max) NULL,
	[user_company] [varchar](max) NULL,
	[user_address_1] [varchar](max) NULL,
	[user_address_2] [varchar](max) NULL,
	[user_city] [varchar](max) NULL,
	[user_state] [varchar](max) NULL,
	[user_zip] [varchar](max) NULL,
	[user_country] [varchar](max) NULL,
	[user_phone] [varchar](max) NULL,
	[user_fax] [varchar](max) NULL,
	[user_mobile] [varchar](max) NULL,
	[user_email] [varchar](max) NULL,
	[user_password] [varchar](60) NOT NULL,
	[user_web] [varchar](max) NULL,
	[user_vat_id] [varchar](max) NULL,
	[user_tax_code] [varchar](max) NULL,
	[user_psalt] [varchar](max) NULL,
	[user_passwordreset_token] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_users] ADD  DEFAULT ('0') FOR [user_type]
GO

ALTER TABLE [dbo].[ip_users] ADD  DEFAULT ('1') FOR [user_active]
GO

ALTER TABLE [dbo].[ip_users] ADD  DEFAULT ('') FOR [user_passwordreset_token]
GO

