USE [AMD]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__7E02B4CC]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__7AF13DF7]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__4A4E069C]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__3FD07829]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__3EA749C6]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__3335971A]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__2F650636]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__2116E6DF]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__1C5231C2]
GO

ALTER TABLE [dbo].[ip_client_custom] DROP CONSTRAINT [FK__ip_client__clien__084B3915]
GO

/****** Object:  Table [dbo].[ip_client_custom]    Script Date: 5/27/2018 8:36:14 AM ******/
DROP TABLE [dbo].[ip_client_custom]
GO

/****** Object:  Table [dbo].[ip_client_custom]    Script Date: 5/27/2018 8:36:14 AM ******/
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

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

ALTER TABLE [dbo].[ip_client_custom]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO


