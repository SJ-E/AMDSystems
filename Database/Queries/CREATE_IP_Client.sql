USE [AMD]
GO

/****** Object:  Table [dbo].[ip_clients]    Script Date: 5/6/2018 11:10:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_clients](
	[client_id] [int] IDENTITY(1,1) NOT NULL,
	[client_date_created] [datetime] NOT NULL,
	[client_date_modified] [datetime] NOT NULL,
	[client_name] [varchar](max) NULL,
	[client_address_1] [varchar](max) NULL,
	[client_address_2] [varchar](max) NULL,
	[client_city] [varchar](max) NULL,
	[client_state] [varchar](max) NULL,
	[client_zip] [varchar](max) NULL,
	[client_country] [varchar](max) NULL,
	[client_phone] [varchar](max) NULL,
	[client_fax] [varchar](max) NULL,
	[client_mobile] [varchar](max) NULL,
	[client_email] [varchar](max) NULL,
	[client_web] [varchar](max) NULL,
	[client_vat_id] [varchar](max) NULL,
	[client_tax_code] [varchar](max) NULL,
	[client_active] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_clients] ADD  DEFAULT ('1') FOR [client_active]
GO


