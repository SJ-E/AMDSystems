USE [AMD]
GO

ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [FK__ip_quote___quote__4FD1D5C8]
GO

ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [DF__ip_quote___quote__4EDDB18F]
GO

ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [DF__ip_quote___quote__4DE98D56]
GO

ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [DF__ip_quote___quote__4CF5691D]
GO

ALTER TABLE [dbo].[ip_quote_amounts] DROP CONSTRAINT [DF__ip_quote___quote__4C0144E4]
GO

/****** Object:  Table [dbo].[ip_quote_amounts]    Script Date: 5/26/2018 2:16:35 AM ******/
DROP TABLE [dbo].[ip_quote_amounts]
GO

/****** Object:  Table [dbo].[ip_quote_amounts]    Script Date: 5/26/2018 2:16:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_quote_amounts](
	[quote_amount_id] [int] IDENTITY(1,1) NOT NULL,
	[quote_id] [int] NOT NULL,
	[quote_item_subtotal] [decimal](20, 2) NULL,
	[quote_item_tax_total] [decimal](20, 2) NULL,
	[quote_tax_total] [decimal](20, 2) NULL,
	[quote_total] [decimal](20, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[quote_amount_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_quote_amounts] ADD  DEFAULT (NULL) FOR [quote_item_subtotal]
GO

ALTER TABLE [dbo].[ip_quote_amounts] ADD  DEFAULT (NULL) FOR [quote_item_tax_total]
GO

ALTER TABLE [dbo].[ip_quote_amounts] ADD  DEFAULT (NULL) FOR [quote_tax_total]
GO

ALTER TABLE [dbo].[ip_quote_amounts] ADD  DEFAULT (NULL) FOR [quote_total]
GO

ALTER TABLE [dbo].[ip_quote_amounts]  WITH CHECK ADD FOREIGN KEY([quote_id])
REFERENCES [dbo].[ip_quotes] ([quote_id])
GO


