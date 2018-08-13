USE [amd2]
GO

INSERT INTO [dbo].[ip_invoices]
           ([user_id]
           ,[client_id]
           ,[invoice_group_id]
           ,[invoice_status_id]
           ,[is_read_only]
           ,[invoice_password]
           ,[invoice_date_created]
           ,[invoice_time_created]
           ,[invoice_date_modified]
           ,[invoice_date_due]
           ,[invoice_number]
           ,[invoice_discount_amount]
           ,[invoice_discount_percent]
           ,[invoice_terms]
           ,[invoice_url_key]
           ,[payment_method]
           ,[creditinvoice_parent_id])
     VALUES
           (1
           ,3
           ,2
           ,1
           ,1
           ,'invoice'
           ,'2-11-2018'
           ,' 00:00:00.000'
           ,'2-11-2018'
          ,'2-11-2018'
          ,'in-1'
           ,10.0
           ,10.0
           ,'in-1'
           ,'in-1'
           ,1
           ,1)
GO


