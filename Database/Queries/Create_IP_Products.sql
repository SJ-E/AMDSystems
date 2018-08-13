USE [AMD]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__purch__7A672E12]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__other__797309D9]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__selli__787EE5A0]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__waren__778AC167]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__supp___76969D2E]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__seria__75A278F5]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__sub_c__74AE54BC]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__quant__73BA3083]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__tax_r__72C60C4A]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__purch__71D1E811]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__produ__70DDC3D8]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__famil__6FE99F9F]
GO

/****** Object:  Table [dbo].[ip_products]    Script Date: 5/26/2018 1:34:19 AM ******/
DROP TABLE [dbo].[ip_products]
GO

/****** Object:  Table [dbo].[ip_products]    Script Date: 5/26/2018 1:34:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_products](
	[product_id] [int] Identity(1,1) primary key,
	[family_id] [int] NULL,
	[product_sku] [varchar](max) NULL,
	[product_name] [varchar](max) NULL,
	[product_description] [varchar](max) NOT NULL,
	[product_price] [decimal](20, 2) NULL,
	[purchase_price] [decimal](20, 2) NULL,
	[provider_name] [varchar](max) NULL,
	[tax_rate_id] [int] NULL,
	[quantity] [int] NULL,
	[sub_cate] [varchar](500) NULL,
	[serial_number] [varchar](100) NULL,
	[supp_name] [varchar](500) NULL,
	[warenty_detail] [varchar](500) NULL,
	[selling_price] [varchar](450) NULL,
	[other_info] [varchar](450) NULL,
	[purchase_org_price] [varchar](450) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [family_id]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [product_price]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [purchase_price]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [tax_rate_id]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [quantity]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [sub_cate]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [serial_number]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [supp_name]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [warenty_detail]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [selling_price]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [other_info]
GO

ALTER TABLE [dbo].[ip_products] ADD  DEFAULT (NULL) FOR [purchase_org_price]
GO


