USE [AMD]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__purch__12FDD1B2]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__other__1209AD79]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__selli__11158940]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__waren__10216507]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__supp___0F2D40CE]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__seria__0E391C95]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__sub_c__0D44F85C]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__quant__0C50D423]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__tax_r__0B5CAFEA]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__purch__0A688BB1]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__produ__09746778]
GO

ALTER TABLE [dbo].[ip_products] DROP CONSTRAINT [DF__ip_produc__famil__0880433F]
GO

/****** Object:  Table [dbo].[ip_products]    Script Date: 5/27/2018 9:09:17 AM ******/
DROP TABLE [dbo].[ip_products]
GO

/****** Object:  Table [dbo].[ip_products]    Script Date: 5/27/2018 9:09:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
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
	[purchase_org_price] [varchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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

