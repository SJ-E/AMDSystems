USE [AMD]
GO

ALTER TABLE [dbo].[ip_email_templates] DROP CONSTRAINT [DF__ip_email___email__440B1D61]
GO

ALTER TABLE [dbo].[ip_email_templates] DROP CONSTRAINT [DF__ip_email___email__4316F928]
GO

/****** Object:  Table [dbo].[ip_email_templates]    Script Date: 5/27/2018 8:39:53 AM ******/
DROP TABLE [dbo].[ip_email_templates]
GO

/****** Object:  Table [dbo].[ip_email_templates]    Script Date: 5/27/2018 8:39:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_email_templates](
	[email_template_id] [int] NOT NULL,
	[email_template_title] [varchar](max) NULL,
	[email_template_type] [varchar](255) NULL,
	[email_template_body] [varchar](max) NOT NULL,
	[email_template_subject] [varchar](max) NULL,
	[email_template_from_name] [varchar](max) NULL,
	[email_template_from_email] [varchar](max) NULL,
	[email_template_cc] [varchar](max) NULL,
	[email_template_bcc] [varchar](max) NULL,
	[email_template_pdf_template] [varchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_email_templates] ADD  DEFAULT (NULL) FOR [email_template_type]
GO

ALTER TABLE [dbo].[ip_email_templates] ADD  DEFAULT (NULL) FOR [email_template_pdf_template]
GO

