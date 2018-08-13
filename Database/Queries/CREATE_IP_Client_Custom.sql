USE [AMD]
GO

/****** Object:  Table [dbo].[ip_client_custom]    Script Date: 5/6/2018 11:13:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_client_custom](
	[client_custom_id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_custom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO


