USE [AMD]
GO

ALTER TABLE [dbo].[ip_client_notes] DROP CONSTRAINT [FK__ip_client__clien__7B264821]
GO

/****** Object:  Table [dbo].[ip_client_notes]    Script Date: 5/27/2018 8:38:37 AM ******/
DROP TABLE [dbo].[ip_client_notes]
GO

/****** Object:  Table [dbo].[ip_client_notes]    Script Date: 5/27/2018 8:38:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ip_client_notes](
	[client_note_id] [int] IDENTITY(1,1) NOT NULL,
	[client_id] [int] NOT NULL,
	[client_note_date] [date] NOT NULL,
	[client_note] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_note_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ip_client_notes]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[ip_clients] ([client_id])
GO

