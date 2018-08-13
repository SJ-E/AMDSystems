USE [amd2]
GO

INSERT INTO [dbo].[ip_invoice_groups]
           ([invoice_group_name]
           ,[invoice_group_identifier_format]
           ,[invoice_group_next_id]
           ,[invoice_group_left_pad])
     VALUES
           ('Invoice Default'
           ,'Invoice Default'
           ,1
           ,1)
GO

INSERT INTO [dbo].[ip_invoice_groups]
           ([invoice_group_name]
           ,[invoice_group_identifier_format]
           ,[invoice_group_next_id]
           ,[invoice_group_left_pad])
     VALUES
           ('Quote Default'
           ,'Quote Default'
           ,1
           ,1)


